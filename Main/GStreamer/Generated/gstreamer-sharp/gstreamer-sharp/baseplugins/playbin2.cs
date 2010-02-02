using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gst.GLib;
using Gst;
using Gst.Interfaces;

namespace Gst.BasePlugins {
#region Autogenerated code
	[GTypeName ("GstPlayBin2")]
	public sealed class PlayBin2 : Gst.Pipeline {
		public PlayBin2 (IntPtr raw) : base (raw) { }

		[DllImport("libgstreamer-0.10.dll") ]
		static extern IntPtr gst_element_factory_make (IntPtr element, IntPtr name);

		public PlayBin2 (string name) : base (IntPtr.Zero) {
			IntPtr native_name = Gst.GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_element = Gst.GLib.Marshaller.StringToPtrGStrdup ("playbin2");
			Raw = gst_element_factory_make (native_element, native_name);
			Gst.GLib.Marshaller.Free (native_name);
			Gst.GLib.Marshaller.Free (native_element);
			if (Raw == IntPtr.Zero)
				throw new Exception ("Failed to instantiate element \"playbin2\"");
		}

		public PlayBin2 () : this ((string) null) { }

		public static PlayBin2 Make (string name) {
			return Gst.ElementFactory.Make ("playbin2", name) as PlayBin2;
		}

		public static PlayBin2 Make () { return Make (null); } 

		[Gst.GLib.Property ("name")]
		public string Name {
			get {
				Gst.GLib.Value val = GetProperty ("name");
				string ret = (string) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "name");
				val.Val = value;
				SetProperty ("name", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("async-handling")]
		public bool AsyncHandling {
			get {
				Gst.GLib.Value val = GetProperty ("async-handling");
				bool ret = (bool) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "async-handling");
				val.Val = value;
				SetProperty ("async-handling", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("delay")]
		public ulong Delay {
			get {
				Gst.GLib.Value val = GetProperty ("delay");
				ulong ret = (ulong) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "delay");
				val.Val = value;
				SetProperty ("delay", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("auto-flush-bus")]
		public bool AutoFlushBus {
			get {
				Gst.GLib.Value val = GetProperty ("auto-flush-bus");
				bool ret = (bool) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "auto-flush-bus");
				val.Val = value;
				SetProperty ("auto-flush-bus", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("uri")]
		public string Uri {
			get {
				Gst.GLib.Value val = GetProperty ("uri");
				string ret = (string) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "uri");
				val.Val = value;
				SetProperty ("uri", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("suburi")]
		public string Suburi {
			get {
				Gst.GLib.Value val = GetProperty ("suburi");
				string ret = (string) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "suburi");
				val.Val = value;
				SetProperty ("suburi", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("source")]
		public Gst.Element Source {
			get {
				Gst.GLib.Value val = GetProperty ("source");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "source");
				val.Val = value;
				SetProperty ("source", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("flags")]
		public PlayFlagsType PlayFlags {
			get {
				Gst.GLib.Value val = GetProperty ("flags");
				PlayFlagsType ret = (PlayFlagsType) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "flags");
				val.Val = value;
				SetProperty ("flags", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("n-video")]
		public int NVideo {
			get {
				Gst.GLib.Value val = GetProperty ("n-video");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "n-video");
				val.Val = value;
				SetProperty ("n-video", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("current-video")]
		public int CurrentVideo {
			get {
				Gst.GLib.Value val = GetProperty ("current-video");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "current-video");
				val.Val = value;
				SetProperty ("current-video", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("n-audio")]
		public int NAudio {
			get {
				Gst.GLib.Value val = GetProperty ("n-audio");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "n-audio");
				val.Val = value;
				SetProperty ("n-audio", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("current-audio")]
		public int CurrentAudio {
			get {
				Gst.GLib.Value val = GetProperty ("current-audio");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "current-audio");
				val.Val = value;
				SetProperty ("current-audio", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("n-text")]
		public int NText {
			get {
				Gst.GLib.Value val = GetProperty ("n-text");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "n-text");
				val.Val = value;
				SetProperty ("n-text", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("current-text")]
		public int CurrentText {
			get {
				Gst.GLib.Value val = GetProperty ("current-text");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "current-text");
				val.Val = value;
				SetProperty ("current-text", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("subtitle-encoding")]
		public string SubtitleEncoding {
			get {
				Gst.GLib.Value val = GetProperty ("subtitle-encoding");
				string ret = (string) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "subtitle-encoding");
				val.Val = value;
				SetProperty ("subtitle-encoding", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("audio-sink")]
		public Gst.Element AudioSink {
			get {
				Gst.GLib.Value val = GetProperty ("audio-sink");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "audio-sink");
				val.Val = value;
				SetProperty ("audio-sink", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("video-sink")]
		public Gst.Element VideoSink {
			get {
				Gst.GLib.Value val = GetProperty ("video-sink");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "video-sink");
				val.Val = value;
				SetProperty ("video-sink", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("vis-plugin")]
		public Gst.Element VisPlugin {
			get {
				Gst.GLib.Value val = GetProperty ("vis-plugin");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "vis-plugin");
				val.Val = value;
				SetProperty ("vis-plugin", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("text-sink")]
		public Gst.Element TextSink {
			get {
				Gst.GLib.Value val = GetProperty ("text-sink");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "text-sink");
				val.Val = value;
				SetProperty ("text-sink", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("subpic-sink")]
		public Gst.Element SubpicSink {
			get {
				Gst.GLib.Value val = GetProperty ("subpic-sink");
				Gst.Element ret = (Gst.Element) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "subpic-sink");
				val.Val = value;
				SetProperty ("subpic-sink", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("volume")]
		public double Volume {
			get {
				Gst.GLib.Value val = GetProperty ("volume");
				double ret = (double) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "volume");
				val.Val = value;
				SetProperty ("volume", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("frame")]
		public Gst.Buffer Frame {
			get {
				Gst.GLib.Value val = GetProperty ("frame");
				Gst.Buffer ret = (Gst.Buffer) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "frame");
				val.Val = value;
				SetProperty ("frame", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("subtitle-font-desc")]
		public string SubtitleFontDesc {
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "subtitle-font-desc");
				val.Val = value;
				SetProperty ("subtitle-font-desc", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("connection-speed")]
		public uint ConnectionSpeed {
			get {
				Gst.GLib.Value val = GetProperty ("connection-speed");
				uint ret = (uint) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "connection-speed");
				val.Val = value;
				SetProperty ("connection-speed", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("buffer-size")]
		public int BufferSize {
			get {
				Gst.GLib.Value val = GetProperty ("buffer-size");
				int ret = (int) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "buffer-size");
				val.Val = value;
				SetProperty ("buffer-size", val);
				val.Dispose ();
			}
		}

		[Gst.GLib.Property ("buffer-duration")]
		public long BufferDuration {
			get {
				Gst.GLib.Value val = GetProperty ("buffer-duration");
				long ret = (long) val.Val;
				val.Dispose ();
				return ret;
			}
			set {
				Gst.GLib.Value val = new Gst.GLib.Value (this, "buffer-duration");
				val.Val = value;
				SetProperty ("buffer-duration", val);
				val.Dispose ();
			}
		}


		public event SignalHandler AboutToFinish {
			add {
				DynamicSignal.Connect (this, "about-to-finish", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "about-to-finish", value);
			}
		}
		public event SignalHandler VideoChanged {
			add {
				DynamicSignal.Connect (this, "video-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "video-changed", value);
			}
		}
		public event SignalHandler AudioChanged {
			add {
				DynamicSignal.Connect (this, "audio-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "audio-changed", value);
			}
		}
		public event SignalHandler TextChanged {
			add {
				DynamicSignal.Connect (this, "text-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "text-changed", value);
			}
		}
		public delegate void VideoTagsChangedHandler (object o, VideoTagsChangedArgs args);

		public class VideoTagsChangedArgs : Gst.GLib.SignalArgs {
			public int index {
				get {
					return (int) Args[0];
				}
			}

		}

		public event VideoTagsChangedHandler VideoTagsChanged {
			add {
				DynamicSignal.Connect (this, "video-tags-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "video-tags-changed", value);
			}
		}
		public delegate void AudioTagsChangedHandler (object o, AudioTagsChangedArgs args);

		public class AudioTagsChangedArgs : Gst.GLib.SignalArgs {
			public int index {
				get {
					return (int) Args[0];
				}
			}

		}

		public event AudioTagsChangedHandler AudioTagsChanged {
			add {
				DynamicSignal.Connect (this, "audio-tags-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "audio-tags-changed", value);
			}
		}
		public delegate void TextTagsChangedHandler (object o, TextTagsChangedArgs args);

		public class TextTagsChangedArgs : Gst.GLib.SignalArgs {
			public int index {
				get {
					return (int) Args[0];
				}
			}

		}

		public event TextTagsChangedHandler TextTagsChanged {
			add {
				DynamicSignal.Connect (this, "text-tags-changed", value);
			}

			remove {
				DynamicSignal.Disconnect (this, "text-tags-changed", value);
			}
		}
		public Gst.TagList GetVideoTags (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.TagList) Emit ("get-video-tags", parameters);
		}

		public Gst.TagList GetAudioTags (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.TagList) Emit ("get-audio-tags", parameters);
		}

		public Gst.TagList GetTextTags (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.TagList) Emit ("get-text-tags", parameters);
		}

		public Gst.Buffer ConvertFrame (Gst.Caps caps) {
			object[] parameters = new object[1];
			parameters[0] = caps;
			return (Gst.Buffer) Emit ("convert-frame", parameters);
		}

		public Gst.Pad GetVideoPad (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.Pad) Emit ("get-video-pad", parameters);
		}

		public Gst.Pad GetAudioPad (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.Pad) Emit ("get-audio-pad", parameters);
		}

		public Gst.Pad GetTextPad (int index) {
			object[] parameters = new object[1];
			parameters[0] = index;
			return (Gst.Pad) Emit ("get-text-pad", parameters);
		}

		[GTypeName ("GstPlayFlags")]
		public enum PlayFlagsType {
		}

#endregion
	}

}