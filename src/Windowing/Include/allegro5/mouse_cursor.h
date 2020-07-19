#ifndef __al_included_allegro5_mouse_cursor_h
#define __al_included_allegro5_mouse_cursor_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

typedef struct ALLEGRO_MOUSE_CURSOR ALLEGRO_MOUSE_CURSOR;

typedef enum ALLEGRO_SYSTEM_MOUSE_CURSOR
{
   ALLEGRO_SYSTEM_MOUSE_CURSOR_NONE        =  0,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_DEFAULT     =  1,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_ARROW       =  2,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_BUSY        =  3,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_QUESTION    =  4,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_EDIT        =  5,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_MOVE        =  6,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_N    =  7,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_W    =  8,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_S    =  9,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_E    = 10,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_NW   = 11,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_SW   = 12,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_SE   = 13,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_NE   = 14,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_PROGRESS    = 15,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_PRECISION   = 16,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_LINK        = 17,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_ALT_SELECT  = 18,
   ALLEGRO_SYSTEM_MOUSE_CURSOR_UNAVAILABLE = 19,
   ALLEGRO_NUM_SYSTEM_MOUSE_CURSORS
} ALLEGRO_SYSTEM_MOUSE_CURSOR;

struct ALLEGRO_BITMAP;
struct ALLEGRO_DISPLAY;


AL_FUNC(ALLEGRO_MOUSE_CURSOR *, al_create_mouse_cursor, (
        struct ALLEGRO_BITMAP *sprite, int xfocus, int yfocus));
AL_FUNC(void, al_destroy_mouse_cursor, (ALLEGRO_MOUSE_CURSOR *));
AL_FUNC(bool, al_set_mouse_cursor, (struct ALLEGRO_DISPLAY *display,
                                    ALLEGRO_MOUSE_CURSOR *cursor));
AL_FUNC(bool, al_set_system_mouse_cursor, (struct ALLEGRO_DISPLAY *display,
                                           ALLEGRO_SYSTEM_MOUSE_CURSOR cursor_id));
AL_FUNC(bool, al_show_mouse_cursor, (struct ALLEGRO_DISPLAY *display));
AL_FUNC(bool, al_hide_mouse_cursor, (struct ALLEGRO_DISPLAY *display));


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
