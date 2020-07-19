#ifndef __al_included_allegro5_transformations_h
#define __al_included_allegro5_transformations_h

#include <allegro5/display.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Type: ALLEGRO_TRANSFORM
 */
typedef struct ALLEGRO_TRANSFORM ALLEGRO_TRANSFORM;

struct ALLEGRO_TRANSFORM {
   float m[4][4];
};

/* Transformations*/
AL_FUNC(void, al_use_transform, (const ALLEGRO_TRANSFORM* trans));
AL_FUNC(void, al_use_projection_transform, (const ALLEGRO_TRANSFORM* trans));
AL_FUNC(void, al_copy_transform, (ALLEGRO_TRANSFORM* dest, const ALLEGRO_TRANSFORM* src));
AL_FUNC(void, al_identity_transform, (ALLEGRO_TRANSFORM* trans));
AL_FUNC(void, al_build_transform, (ALLEGRO_TRANSFORM* trans, float x, float y, float sx, float sy, float theta));
AL_FUNC(void, al_build_camera_transform, (ALLEGRO_TRANSFORM *trans,
   float position_x, float position_y, float position_z,
   float look_x, float look_y, float look_z,
   float up_x, float up_y, float up_z));
AL_FUNC(void, al_translate_transform, (ALLEGRO_TRANSFORM* trans, float x, float y));
AL_FUNC(void, al_translate_transform_3d, (ALLEGRO_TRANSFORM *trans, float x, float y, float z));
AL_FUNC(void, al_rotate_transform, (ALLEGRO_TRANSFORM* trans, float theta));
AL_FUNC(void, al_rotate_transform_3d, (ALLEGRO_TRANSFORM *trans, float x, float y, float z, float angle));
AL_FUNC(void, al_scale_transform, (ALLEGRO_TRANSFORM* trans, float sx, float sy));
AL_FUNC(void, al_scale_transform_3d, (ALLEGRO_TRANSFORM *trans, float sx, float sy, float sz));
AL_FUNC(void, al_transform_coordinates, (const ALLEGRO_TRANSFORM* trans, float* x, float* y));
AL_FUNC(void, al_transform_coordinates_3d, (const ALLEGRO_TRANSFORM *trans,
   float *x, float *y, float *z));
AL_FUNC(void, al_transform_coordinates_4d, (const ALLEGRO_TRANSFORM *trans,
   float *x, float *y, float *z, float *w));
AL_FUNC(void, al_transform_coordinates_3d_projective, (const ALLEGRO_TRANSFORM *trans,
   float *x, float *y, float *z));
AL_FUNC(void, al_compose_transform, (ALLEGRO_TRANSFORM* trans, const ALLEGRO_TRANSFORM* other));
AL_FUNC(const ALLEGRO_TRANSFORM*, al_get_current_transform, (void));
AL_FUNC(const ALLEGRO_TRANSFORM*, al_get_current_inverse_transform, (void));
AL_FUNC(const ALLEGRO_TRANSFORM *, al_get_current_projection_transform, (void));
AL_FUNC(void, al_invert_transform, (ALLEGRO_TRANSFORM *trans));
AL_FUNC(void, al_transpose_transform, (ALLEGRO_TRANSFORM *trans));
AL_FUNC(int, al_check_inverse, (const ALLEGRO_TRANSFORM *trans, float tol));
AL_FUNC(void, al_orthographic_transform, (ALLEGRO_TRANSFORM *trans, float left, float top, float n, float right, float bottom, float f));
AL_FUNC(void, al_perspective_transform, (ALLEGRO_TRANSFORM *trans, float left, float top, float n, float right, float bottom, float f));
AL_FUNC(void, al_horizontal_shear_transform, (ALLEGRO_TRANSFORM *trans, float theta));
AL_FUNC(void, al_vertical_shear_transform, (ALLEGRO_TRANSFORM *trans, float theta));

#ifdef __cplusplus
   }
#endif

#endif
