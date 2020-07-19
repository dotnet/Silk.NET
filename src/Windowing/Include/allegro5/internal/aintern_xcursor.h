#ifndef __al_included_allegro5_aintern_xcursor_h
#define __al_included_allegro5_aintern_xcursor_h

#ifdef ALLEGRO_XWINDOWS_WITH_XCURSOR
#include <X11/Xcursor/Xcursor.h>
#endif

#include <allegro5/internal/aintern_display.h>

typedef struct ALLEGRO_MOUSE_CURSOR_XWIN ALLEGRO_MOUSE_CURSOR_XWIN;

struct ALLEGRO_MOUSE_CURSOR_XWIN
{
   Cursor cursor;
};

ALLEGRO_MOUSE_CURSOR *_al_xwin_create_mouse_cursor(ALLEGRO_BITMAP *bmp,
   int x_focus, int y_focus);
void _al_xwin_destroy_mouse_cursor(ALLEGRO_MOUSE_CURSOR *cursor);
void _al_xwin_add_cursor_functions(ALLEGRO_DISPLAY_INTERFACE *vt);

#endif

/* vim: set sts=3 sw=3 et: */
