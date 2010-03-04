package ossbuild;

import com.sun.jna.Library;
import com.sun.jna.Native;
import com.sun.jna.NativeLibrary;
import java.io.File;
import ossbuild.platform.Win32Library;

/**
 * Sets/gets the current (present) working directory, process identifier (pid),
 * and other process-related information.
 * 
 * @author David Hoyt <dhoyt@hoytsoft.org>
 */
public class Process {
	//<editor-fold defaultstate="collapsed" desc="JNA Library Declarations">
	interface ProcLibraryWindows extends Win32Library {
		//<editor-fold defaultstate="collapsed" desc="Constants">
		public static final String 
			LIB_NAME = "kernel32"
		;

		public static final ProcLibraryWindows
			INSTANCE = (ProcLibraryWindows)Native.loadLibrary(LIB_NAME, ProcLibraryWindows.class, DEFAULT_OPTIONS)
		;
		//</editor-fold>

		public int GetLastError();
		public int GetCurrentProcessId();
		public int SetCurrentDirectory(final String path);
	}

	interface ProcLibraryUnix extends Library {
		//<editor-fold defaultstate="collapsed" desc="Constants">
		public static final String
			LIB_NAME = "c"
		;

		public static final ProcLibraryUnix
			INSTANCE = (ProcLibraryUnix)Native.loadLibrary(LIB_NAME, ProcLibraryUnix.class);
		;
		//</editor-fold>

		public int getpid();
		public int chdir(final String path);
	}
	//</editor-fold>

	//<editor-fold defaultstate="collapsed" desc="Variables">
	private static final Object cwdLock = new Object();
	private static Library nativelib;
	private static String cwd;
	//</editor-fold>

	//<editor-fold defaultstate="collapsed" desc="Initialization">
	static {
		cwd = Path.workingDirectory;
		
		switch(OS.getSystemOSFamily()) {
			case Unix:
			case Mac:
				nativelib = ProcLibraryUnix.INSTANCE;
				break;
			case Windows:
				nativelib = ProcLibraryWindows.INSTANCE;
				break;
			default:
				break;
		}
	}
	//</editor-fold>

	//<editor-fold defaultstate="collapsed" desc="Public Static Methods">
	public static int getLastError() {
		if (nativelib instanceof ProcLibraryUnix)
			return NativeLibrary.getInstance(ProcLibraryUnix.LIB_NAME).getGlobalVariableAddress("errno").getInt(0L);
		else if (nativelib instanceof ProcLibraryWindows)
			return ProcLibraryWindows.INSTANCE.GetLastError();
		else
			throw new UnsatisfiedLinkError("Platform specific library for process manipulation is unavailable");

	}

	public static int getPID() {
		if (nativelib instanceof ProcLibraryUnix)
			return ProcLibraryUnix.INSTANCE.getpid();
		else if (nativelib instanceof ProcLibraryWindows)
			return ProcLibraryWindows.INSTANCE.GetCurrentProcessId();
		else
			throw new UnsatisfiedLinkError("Platform specific library for process manipulation is unavailable");
	}
	
	public static String getWorkingDirectory() {
		synchronized(cwdLock) {
			return cwd;
		}
	}

	public static boolean setWorkingDirectory(final File path) {
		if (path == null || !path.exists())
			return false;
		return setWorkingDirectory(path.getAbsolutePath());
	}

	public static boolean setWorkingDirectory(final String path) {
		if (StringUtil.isNullOrEmpty(path))
			return false;

		synchronized(cwdLock) {
			final String oldcwd = cwd;
			boolean ret = false;
			try {
				cwd = path;

				if (nativelib instanceof ProcLibraryUnix)
					ret = (ProcLibraryUnix.INSTANCE.chdir(path) == 0);
				else if (nativelib instanceof ProcLibraryWindows)
					ret = (ProcLibraryWindows.INSTANCE.SetCurrentDirectory(path) != 0);
				else
					throw new UnsatisfiedLinkError("Platform specific library for process manipulation is unavailable");
				
				return ret;
			} finally {
				if (!ret)
					cwd = oldcwd;
			}
		}
	}
	//</editor-fold>
}
