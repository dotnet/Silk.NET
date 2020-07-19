/* alplatf.h is generated from alplatf.h.cmake */
#define ALLEGRO_MINGW32
#define ALLEGRO_UNIX
#define ALLEGRO_MSVC
#define ALLEGRO_MACOSX
#define ALLEGRO_BCC32
#define ALLEGRO_IPHONE
#define ALLEGRO_ANDROID
#define ALLEGRO_RASPBERRYPI
#define ALLEGRO_CFG_NO_FPU
#define ALLEGRO_CFG_DLL_TLS
#define ALLEGRO_CFG_PTHREADS_TLS
#define ALLEGRO_CFG_RELEASE_LOGGING

#define ALLEGRO_CFG_D3D
#define ALLEGRO_CFG_D3D9EX
#define ALLEGRO_CFG_D3DX9
#define ALLEGRO_CFG_XINPUT
#define ALLEGRO_CFG_OPENGL
#define ALLEGRO_CFG_OPENGLES
#define ALLEGRO_CFG_OPENGLES1
#define ALLEGRO_CFG_OPENGLES2
#define ALLEGRO_CFG_OPENGLES3
#define ALLEGRO_CFG_OPENGL_FIXED_FUNCTION
#define ALLEGRO_CFG_OPENGL_PROGRAMMABLE_PIPELINE
#define ALLEGRO_CFG_SHADER_GLSL
#define ALLEGRO_CFG_SHADER_HLSL

#define ALLEGRO_CFG_ANDROID_LEGACY

/*---------------------------------------------------------------------------*/

/* Define to 1 if you have the corresponding header file. */
#define ALLEGRO_HAVE_DIRENT_H
#define ALLEGRO_HAVE_INTTYPES_H
#define ALLEGRO_HAVE_LINUX_AWE_VOICE_H
#define ALLEGRO_HAVE_LINUX_INPUT_H
#define ALLEGRO_HAVE_LINUX_SOUNDCARD_H
#define ALLEGRO_HAVE_MACHINE_SOUNDCARD_H
#define ALLEGRO_HAVE_SOUNDCARD_H
#define ALLEGRO_HAVE_STDBOOL_H
#define ALLEGRO_HAVE_STDINT_H
#define ALLEGRO_HAVE_SV_PROCFS_H
#define ALLEGRO_HAVE_SYS_IO_H
#define ALLEGRO_HAVE_SYS_SOUNDCARD_H
#define ALLEGRO_HAVE_SYS_STAT_H
#define ALLEGRO_HAVE_SYS_TIME_H
#define ALLEGRO_HAVE_TIME_H
#define ALLEGRO_HAVE_SYS_UTSNAME_H
#define ALLEGRO_HAVE_SYS_TYPES_H
#define ALLEGRO_HAVE_OSATOMIC_H
#define ALLEGRO_HAVE_SYS_INOTIFY_H
#define ALLEGRO_HAVE_SAL_H

/* Define to 1 if the corresponding functions are available. */
#define ALLEGRO_HAVE_GETEXECNAME
#define ALLEGRO_HAVE_MKSTEMP
#define ALLEGRO_HAVE_MMAP
#define ALLEGRO_HAVE_MPROTECT
#define ALLEGRO_HAVE_SCHED_YIELD
#define ALLEGRO_HAVE_SYSCONF
#define ALLEGRO_HAVE_SYSCTL

#define ALLEGRO_HAVE_FSEEKO
#define ALLEGRO_HAVE_FTELLO
#define ALLEGRO_HAVE_STRERROR_R
#define ALLEGRO_HAVE_STRERROR_S
#define ALLEGRO_HAVE_VA_COPY
#define ALLEGRO_HAVE_FTELLI64
#define ALLEGRO_HAVE_FSEEKI64

/* Define to 1 if procfs reveals argc and argv */
#define ALLEGRO_HAVE_PROCFS_ARGCV

/*---------------------------------------------------------------------------*/

/* Define if target machine is little endian. */
#define ALLEGRO_LITTLE_ENDIAN

/* Define if target machine is big endian. */
#define ALLEGRO_BIG_ENDIAN

/* Define if target platform is Darwin. */
#define ALLEGRO_DARWIN

/*---------------------------------------------------------------------------*/

/* Define if you need support for X-Windows. */
#define ALLEGRO_WITH_XWINDOWS

/* Define if XCursor ARGB extension is available. */
#define ALLEGRO_XWINDOWS_WITH_XCURSOR

/* Define if XF86VidMode extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XF86VIDMODE

/* Define if Xinerama extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XINERAMA

/* Define if XRandR extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XRANDR

/* Define if XScreenSaver extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XSCREENSAVER

/* Define if XIM extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XIM

/* Define if XInput 2.2 X11 extension is supported. */
#define ALLEGRO_XWINDOWS_WITH_XINPUT2

/* Define if Xpm is found. Useful on Ubuntu Unity to set icon. */
#define ALLEGRO_XWINDOWS_WITH_XPM

/*---------------------------------------------------------------------------*/

/* Define if target platform is linux. */
#define ALLEGRO_LINUX

/* Define if we are building with SDL backend. */
#define ALLEGRO_SDL

/*---------------------------------------------------------------------------*/
/* vi: set ft=c ts=3 sts=3 sw=3 et: */
