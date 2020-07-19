#ifndef __al_included_allegro5_aintern_xsystem_h
#define __al_included_allegro5_aintern_xsystem_h

#ifdef ALLEGRO_XWINDOWS_WITH_XF86VIDMODE
#include <X11/extensions/xf86vmode.h>
#endif

#ifdef ALLEGRO_XWINDOWS_WITH_XINERAMA
#include <X11/extensions/Xinerama.h>
#endif

#ifdef ALLEGRO_XWINDOWS_WITH_XRANDR
#include <X11/extensions/Xrandr.h>
#endif

#ifdef ALLEGRO_XWINDOWS_WITH_XSCREENSAVER
#include <X11/extensions/scrnsaver.h>
#endif

#include <allegro5/internal/aintern_system.h>

/* This is our version of ALLEGRO_SYSTEM with driver specific extra data. */
struct ALLEGRO_SYSTEM_XGLX
{
   /* This must be the first member, we "derive" from it. */
   ALLEGRO_SYSTEM system;

   /* Driver specifics. */

   /* X11 is not thread-safe. But we use a separate thread to handle X11 events.
    * Plus, users may call OpenGL commands in the main thread, and we have no
    * way to enforce locking for them.
    * The only solution seems to be two X11 display connections. One to do our
    * input handling, and one for OpenGL graphics.
    *
    * Note: these may be NULL if we are not connected to an X server, for
    * headless command-line tools. We don't have a separate "null" system
    * driver.
    */
   /* The X11 display. You *MUST* only access this from one
    * thread at a time, use the mutex lock below to ensure it.
    */
   Display *x11display;
   /* Another X11 display we use for graphics. You *MUST*
    * only use this in the main thread.
    */
   Display *gfxdisplay;

   Atom AllegroAtom;
   Atom XEmbedAtom;

   /* Background thread to process X events.
    * Not used if GTK main loop is used.
    */
   bool have_xevents_thread;
   _AL_THREAD xevents_thread;
   _AL_MUTEX lock; /* thread lock for whenever we access internals. */
   // FIXME: One condition variable really would be enough.
   _AL_COND resized; /* Condition variable to wait for resizing a window. */
   ALLEGRO_DISPLAY *mouse_grab_display; /* Best effort: may be inaccurate. */
   int toggle_mouse_grab_keycode; /* Disabled if zero */
   unsigned int toggle_mouse_grab_modifiers;
   bool inhibit_screensaver; /* Should we inhibit the screensaver? */
   bool screen_saver_query_available;

   bool mmon_interface_inited;
#ifdef ALLEGRO_XWINDOWS_WITH_XINERAMA
   int xinerama_available;
   int xinerama_screen_count;
   XineramaScreenInfo *xinerama_screen_info;
#endif
#ifdef ALLEGRO_XWINDOWS_WITH_XF86VIDMODE
   /* For VidMode extension. */
   int xfvm_available;
   int xfvm_screen_count;
   struct {
      int mode_count;
      XF86VidModeModeInfo **modes;
      XF86VidModeModeInfo *original_mode;
   } *xfvm_screen;
#endif
#ifdef ALLEGRO_XWINDOWS_WITH_XRANDR
   int xrandr_available;
   int xrandr_event_base;
   _AL_VECTOR xrandr_screens;
   _AL_VECTOR xrandr_adaptermap;
#endif

   /* Used to keep track of how many adapters are in use, so the multi-head
    * code can bail if we try to use more than one. */
   int adapter_use_count;
   int adapter_map[32];	/* XXX magic constant */
};

#endif

/* vim: set sts=3 sw=3 et: */
