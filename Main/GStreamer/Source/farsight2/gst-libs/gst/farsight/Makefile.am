libgstfarsightincludedir = $(includedir)/gstreamer-@GST_MAJORMINOR@/gst/farsight

libgstfarsightinclude_HEADERS = \
		fs-base-conference.h \
		fs-candidate.h \
		fs-codec.h \
		fs-participant.h \
		fs-session.h \
		fs-stream.h \
		fs-conference-iface.h \
		fs-transmitter.h \
		fs-stream-transmitter.h \
		fs-plugin.h \
		fs-element-added-notifier.h \
		fs-interfaces.h

nodist_libgstfarsightinclude_HEADERS = \
		fs-enum-types.h

# Don't forget to rename on ABI break
fs-enum-types.h: fs-enumtypes.h
	$(AM_V_GEN)test -L fs-enum-types.h || { rm -f fs-enum-types.h;  $(LN_S) fs-enumtypes.h fs-enum-types.h ; }

lib_LTLIBRARIES = libgstfarsight-@GST_MAJORMINOR@.la

BUILT_SOURCES = \
	$(nodist_libgstfarsight_@GST_MAJORMINOR@_la_SOURCES) \
	$(nodist_libgstfarsightinclude_HEADERS)

CLEANFILES = $(BUILT_SOURCES) fs-enumtypes.h fs-marshal.list

libgstfarsight_@GST_MAJORMINOR@_la_SOURCES = \
		fs-base-conference.c \
		fs-candidate.c \
		fs-codec.c \
		fs-participant.c \
		fs-session.c \
		fs-stream.c \
		fs-conference-iface.c \
		fs-transmitter.c \
		fs-stream-transmitter.c \
		fs-plugin.c \
		fs-element-added-notifier.c \
		fs-interfaces.c \
		fs-private.h

nodist_libgstfarsight_@GST_MAJORMINOR@_la_SOURCES = \
		fs-marshal.c \
		fs-marshal.h \
		fs-enumtypes.c


fs-marshal.list: $(libgstfarsight_@GST_MAJORMINOR@_la_SOURCES) Makefile.am
	$(AM_V_GEN) ( cd $(srcdir) && \
	sed -n -e 's/.*_fs_marshal_\([[:upper:][:digit:]]*__[[:upper:][:digit:]_]*\).*/\1/p' \
	$(libgstfarsight_@GST_MAJORMINOR@_la_SOURCES) ) \
	| sed -e 's/__/:/' -e 'y/_/,/' | sort -u > $@.tmp
	@if cmp -s $@.tmp $@; then \
		rm $@.tmp; \
		touch $@; \
	else \
		mv $@.tmp $@; \
	fi

libgstfarsight_@GST_MAJORMINOR@_la_CFLAGS = \
	$(FS2_INTERNAL_CFLAGS) $(FS2_CFLAGS) \
	$(GST_PLUGINS_BASE_CFLAGS) \
	$(GST_BASE_CFLAGS) \
	$(GST_CFLAGS)
libgstfarsight_@GST_MAJORMINOR@_la_LIBADD = \
	$(GST_BASE_LIBS) \
	$(GST_LIBS)
libgstfarsight_@GST_MAJORMINOR@_la_LDFLAGS = \
	$(FS2_LIB_LDFLAGS) \
	$(FS2_ALL_LDFLAGS) \
	$(FS2_LT_LDFLAGS) 


public_headers = fs-candidate.h \
		fs-codec.h \
		fs-participant.h \
		fs-session.h \
		fs-stream.h \
		fs-conference-iface.h

glib_enum_headers=$(public_headers)
glib_enum_define=FS
glib_gen_prefix=_fs
glib_gen_basename=fs

include $(top_srcdir)/common-modified/gst-glib-gen.mak
