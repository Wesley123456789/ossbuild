// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void TaskPoolFunctionNative(IntPtr data);

	internal class TaskPoolFunctionInvoker {

		TaskPoolFunctionNative native_cb;
		IntPtr __data;
		Gst.GLib.DestroyNotify __notify;

		~TaskPoolFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TaskPoolFunctionInvoker (TaskPoolFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TaskPoolFunctionInvoker (TaskPoolFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TaskPoolFunctionInvoker (TaskPoolFunctionNative native_cb, IntPtr data, Gst.GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.TaskPoolFunction Handler {
			get {
				return new Gst.TaskPoolFunction(InvokeNative);
			}
		}

		void InvokeNative ()
		{
			native_cb (__data);
		}
	}

	internal class TaskPoolFunctionWrapper {

		public void NativeCallback (IntPtr data)
		{
			try {
				managed ();
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TaskPoolFunctionNative NativeDelegate;
		Gst.TaskPoolFunction managed;

		public TaskPoolFunctionWrapper (Gst.TaskPoolFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TaskPoolFunctionNative (NativeCallback);
		}

		public static Gst.TaskPoolFunction GetManagedDelegate (TaskPoolFunctionNative native)
		{
			if (native == null)
				return null;
			TaskPoolFunctionWrapper wrapper = (TaskPoolFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
