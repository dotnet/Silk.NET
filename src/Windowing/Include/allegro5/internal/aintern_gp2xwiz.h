#ifndef __al_included_allegro5_aintern_gp2xwiz_h
#define __al_included_allegro5_aintern_gp2xwiz_h

#include <allegro5/allegro.h>
#include <allegro5/allegro_opengl.h>
#include <allegro5/internal/aintern.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/internal/aintern_bitmap.h>
#include <allegro5/platform/aintwiz.h>
#include <allegro5/internal/aintern_opengl.h>

#include <wiz/castor.h>

typedef struct ALLEGRO_SYSTEM_GP2XWIZ ALLEGRO_SYSTEM_GP2XWIZ;
typedef struct ALLEGRO_DISPLAY_GP2XWIZ_OGL ALLEGRO_DISPLAY_GP2XWIZ_OGL;
typedef struct ALLEGRO_DISPLAY_GP2XWIZ_FB ALLEGRO_DISPLAY_GP2XWIZ_FB;

struct ALLEGRO_SYSTEM_GP2XWIZ
{
   ALLEGRO_SYSTEM system; /* This must be the first member, we "derive" from it. */

   ALLEGRO_EXTRA_DISPLAY_SETTINGS extras;
};

/* This is our version of ALLEGRO_DISPLAY with driver specific extra data. */
struct ALLEGRO_DISPLAY_GP2XWIZ_OGL
{
   ALLEGRO_DISPLAY display; /* This must be the first member. */

   EGLDisplay egl_display;
   EGLConfig egl_config;
   EGLContext egl_context;
   EGLSurface egl_surface;
   NativeWindowType hNativeWnd;
};

/* This is our version of ALLEGRO_DISPLAY with driver specific extra data. */
struct ALLEGRO_DISPLAY_GP2XWIZ_FB
{
   ALLEGRO_DISPLAY display; /* This must be the first member. */

   ALLEGRO_BITMAP *backbuffer;
   /*
    * We create the backbuffer bitmap then points it's ->memory at
    * lc_fb1 (initialized with libcastor. This is a backup of the
    * ->memory as created by al_create_bitmap.
    */
   unsigned char *screen_mem;
};

#endif
