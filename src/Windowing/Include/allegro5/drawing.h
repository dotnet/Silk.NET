#ifndef __al_included_allegro5_drawing_h
#define __al_included_allegro5_drawing_h

#include <allegro5/color.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Drawing primitives */
AL_FUNC(void, al_clear_to_color, (ALLEGRO_COLOR color));
AL_FUNC(void, al_clear_depth_buffer, (float x));
AL_FUNC(void, al_draw_pixel, (float x, float y, ALLEGRO_COLOR color));


#ifdef __cplusplus
   }
#endif

#endif
/* vim: set ts=8 sts=3 sw=3 et: */
