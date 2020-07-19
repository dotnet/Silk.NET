#ifndef __al_included_allegro5_aintern_xevents_h
#define __al_included_allegro5_aintern_xevents_h

#include <allegro5/internal/aintern_thread.h>

void _al_xwin_background_thread(_AL_THREAD *self, void *arg);

void _al_display_xglx_closebutton(ALLEGRO_DISPLAY *d, XEvent *xevent);

#endif
