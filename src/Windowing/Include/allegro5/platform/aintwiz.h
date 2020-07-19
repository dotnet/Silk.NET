#ifndef __al_included_allegro5_aintwiz_h
#define __al_included_allegro5_aintwiz_h

#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_bitmap.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/system.h>
#include <allegro5/platform/aintunix.h>

ALLEGRO_DISPLAY_INTERFACE *_al_display_gp2xwiz_opengl_driver(void);
ALLEGRO_DISPLAY_INTERFACE *_al_display_gp2xwiz_framebuffer_driver(void);
ALLEGRO_SYSTEM_INTERFACE *_al_system_gp2xwiz_driver(void);
ALLEGRO_BITMAP_INTERFACE *_al_bitmap_gp2xwiz_driver(void);

#endif

