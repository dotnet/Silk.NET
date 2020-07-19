#ifndef __al_included_allegro5_aintern_tri_soft_h
#define __al_included_allegro5_aintern_tri_soft_h

struct ALLEGRO_BITMAP;

/* Duplicated in allegro_primitives.h */
#ifndef _ALLEGRO_VERTEX_DEFINED
#define _ALLEGRO_VERTEX_DEFINED

typedef struct ALLEGRO_VERTEX ALLEGRO_VERTEX;

struct ALLEGRO_VERTEX {
  float x, y, z;
  float u, v;
  ALLEGRO_COLOR color;
};
#endif

AL_FUNC(void, _al_triangle_2d, (ALLEGRO_BITMAP* texture, ALLEGRO_VERTEX* v1, ALLEGRO_VERTEX* v2, ALLEGRO_VERTEX* v3));
AL_FUNC(void, _al_draw_soft_triangle, (
   ALLEGRO_VERTEX* v1, ALLEGRO_VERTEX* v2, ALLEGRO_VERTEX* v3, uintptr_t state,
   void (*init)(uintptr_t, ALLEGRO_VERTEX*, ALLEGRO_VERTEX*, ALLEGRO_VERTEX*),
   void (*first)(uintptr_t, int, int, int, int),
   void (*step)(uintptr_t, int),
   void (*draw)(uintptr_t, int, int, int)));

#endif
