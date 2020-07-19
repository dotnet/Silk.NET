#ifndef __al_included_allegro5_blender_h
#define __al_included_allegro5_blender_h

#include <allegro5/base.h>
#include <allegro5/color.h>

#ifdef __cplusplus
   extern "C" {
#endif


/*
 * Blending modes
 */
enum ALLEGRO_BLEND_MODE {
   ALLEGRO_ZERO                = 0,
   ALLEGRO_ONE                 = 1,
   ALLEGRO_ALPHA               = 2,
   ALLEGRO_INVERSE_ALPHA       = 3,
   ALLEGRO_SRC_COLOR           = 4,
   ALLEGRO_DEST_COLOR          = 5,
   ALLEGRO_INVERSE_SRC_COLOR   = 6,
   ALLEGRO_INVERSE_DEST_COLOR  = 7,
   ALLEGRO_CONST_COLOR         = 8,
   ALLEGRO_INVERSE_CONST_COLOR = 9,
   ALLEGRO_NUM_BLEND_MODES
};

enum ALLEGRO_BLEND_OPERATIONS {
   ALLEGRO_ADD                = 0,
   ALLEGRO_SRC_MINUS_DEST     = 1,
   ALLEGRO_DEST_MINUS_SRC     = 2,
   ALLEGRO_NUM_BLEND_OPERATIONS
};


AL_FUNC(void, al_set_blender, (int op, int source, int dest));
AL_FUNC(void, al_set_blend_color, (ALLEGRO_COLOR color));
AL_FUNC(void, al_get_blender, (int *op, int *source, int *dest));
AL_FUNC(ALLEGRO_COLOR, al_get_blend_color, (void));
AL_FUNC(void, al_set_separate_blender, (int op, int source, int dest,
   int alpha_op, int alpha_source, int alpha_dest));
AL_FUNC(void, al_get_separate_blender, (int *op, int *source, int *dest,
   int *alpha_op, int *alpha_src, int *alpha_dest));


#ifdef __cplusplus
   }
#endif

#endif
