#ifndef __al_included_allegro5_aintiphone_h
#define __al_included_allegro5_aintiphone_h

#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_bitmap.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/system.h>
#include <allegro5/platform/aintunix.h>

ALLEGRO_DISPLAY_INTERFACE *_al_display_iphone(void);
ALLEGRO_SYSTEM_INTERFACE *_al_system_iphone(void);
ALLEGRO_PATH *_al_iphone_get_path(int id);

#endif

