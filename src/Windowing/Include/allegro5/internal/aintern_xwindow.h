#ifndef __al_included_allegro5_aintern_xwindow_h
#define __al_included_allegro5_aintern_xwindow_h

void _al_xwin_set_size_hints(ALLEGRO_DISPLAY *d, int x_off, int y_off);
void _al_xwin_reset_size_hints(ALLEGRO_DISPLAY *d);
void _al_xwin_set_fullscreen_window(ALLEGRO_DISPLAY *display, int value);
void _al_xwin_set_above(ALLEGRO_DISPLAY *display, int value);
void _al_xwin_set_frame(ALLEGRO_DISPLAY *display, bool frame_on);
void _al_xwin_set_icons(ALLEGRO_DISPLAY *d,
   int num_icons, ALLEGRO_BITMAP *bitmaps[]);
void _al_xwin_maximize(ALLEGRO_DISPLAY *d, bool maximized);
void _al_xwin_check_maximized(ALLEGRO_DISPLAY *display);

#endif

/* vim: set sts=3 sw=3 et: */
