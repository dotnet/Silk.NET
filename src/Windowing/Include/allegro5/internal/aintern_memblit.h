#ifndef __al_included_allegro5_aintern_memblit_h
#define __al_included_allegro5_aintern_memblit_h

#ifdef __cplusplus
   extern "C" {
#endif


void _al_draw_bitmap_region_memory(ALLEGRO_BITMAP *bitmap,
   ALLEGRO_COLOR tint,
   int sx, int sy, int sw, int sh, int dx, int dy, int flags);


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
