#ifndef __al_included_allegro5_render_state_h
#define __al_included_allegro5_render_state_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Enum: ALLEGRO_RENDER_STATE
 */
typedef enum ALLEGRO_RENDER_STATE {
   /* ALLEGRO_ALPHA_TEST was the name of a rare bitmap flag only used on the
    * Wiz port.  Reuse the name but retain the same value.
    */
   ALLEGRO_ALPHA_TEST = 0x0010,
   ALLEGRO_WRITE_MASK,
   ALLEGRO_DEPTH_TEST,
   ALLEGRO_DEPTH_FUNCTION,
   ALLEGRO_ALPHA_FUNCTION,
   ALLEGRO_ALPHA_TEST_VALUE
} ALLEGRO_RENDER_STATE;

/* Enum: ALLEGRO_RENDER_FUNCTION
 */
typedef enum ALLEGRO_RENDER_FUNCTION {
   ALLEGRO_RENDER_NEVER,
   ALLEGRO_RENDER_ALWAYS,
   ALLEGRO_RENDER_LESS, 
   ALLEGRO_RENDER_EQUAL,     
   ALLEGRO_RENDER_LESS_EQUAL,       
   ALLEGRO_RENDER_GREATER,        
   ALLEGRO_RENDER_NOT_EQUAL, 
   ALLEGRO_RENDER_GREATER_EQUAL
} ALLEGRO_RENDER_FUNCTION;

/* Enum: ALLEGRO_WRITE_MASK_FLAGS
 */
typedef enum ALLEGRO_WRITE_MASK_FLAGS {
   ALLEGRO_MASK_RED = 1 << 0,
   ALLEGRO_MASK_GREEN = 1 << 1,
   ALLEGRO_MASK_BLUE = 1 << 2,
   ALLEGRO_MASK_ALPHA = 1 << 3,
   ALLEGRO_MASK_DEPTH = 1 << 4,
   ALLEGRO_MASK_RGB = (ALLEGRO_MASK_RED | ALLEGRO_MASK_GREEN | ALLEGRO_MASK_BLUE),
   ALLEGRO_MASK_RGBA = (ALLEGRO_MASK_RGB | ALLEGRO_MASK_ALPHA)
} ALLEGRO_WRITE_MASK_FLAGS;

AL_FUNC(void, al_set_render_state, (ALLEGRO_RENDER_STATE state, int value));

#ifdef __cplusplus
   }
#endif

#endif
