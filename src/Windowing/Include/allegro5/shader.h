#ifndef __al_included_allegro5_shader_h
#define __al_included_allegro5_shader_h

#include <allegro5/base.h>
#include <allegro5/transformations.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Type: ALLEGRO_SHADER
 */
typedef struct ALLEGRO_SHADER ALLEGRO_SHADER;

enum ALLEGRO_SHADER_TYPE {
   ALLEGRO_VERTEX_SHADER = 1,
   ALLEGRO_PIXEL_SHADER = 2
};

/* Enum: ALLEGRO_SHADER_TYPE
 */
typedef enum ALLEGRO_SHADER_TYPE ALLEGRO_SHADER_TYPE;

enum ALLEGRO_SHADER_PLATFORM {
   ALLEGRO_SHADER_AUTO = 0,
   ALLEGRO_SHADER_GLSL = 1,
   ALLEGRO_SHADER_HLSL = 2
};

/* Enum: ALLEGRO_SHADER_PLATFORM
 */
typedef enum ALLEGRO_SHADER_PLATFORM ALLEGRO_SHADER_PLATFORM;

/* Shader variable names */
#define ALLEGRO_SHADER_VAR_COLOR             "al_color"
#define ALLEGRO_SHADER_VAR_POS               "al_pos"
#define ALLEGRO_SHADER_VAR_PROJVIEW_MATRIX   "al_projview_matrix"
#define ALLEGRO_SHADER_VAR_TEX               "al_tex"
#define ALLEGRO_SHADER_VAR_TEXCOORD          "al_texcoord"
#define ALLEGRO_SHADER_VAR_TEX_MATRIX        "al_tex_matrix"
#define ALLEGRO_SHADER_VAR_USER_ATTR         "al_user_attr_"
#define ALLEGRO_SHADER_VAR_USE_TEX           "al_use_tex"
#define ALLEGRO_SHADER_VAR_USE_TEX_MATRIX    "al_use_tex_matrix"
#define ALLEGRO_SHADER_VAR_ALPHA_TEST        "al_alpha_test"
#define ALLEGRO_SHADER_VAR_ALPHA_FUNCTION    "al_alpha_func"
#define ALLEGRO_SHADER_VAR_ALPHA_TEST_VALUE  "al_alpha_test_val"

AL_FUNC(ALLEGRO_SHADER *, al_create_shader, (ALLEGRO_SHADER_PLATFORM platform));
AL_FUNC(bool, al_attach_shader_source, (ALLEGRO_SHADER *shader,
   ALLEGRO_SHADER_TYPE type, const char *source));
AL_FUNC(bool, al_attach_shader_source_file, (ALLEGRO_SHADER *shader,
   ALLEGRO_SHADER_TYPE type, const char *filename));
AL_FUNC(bool, al_build_shader, (ALLEGRO_SHADER *shader));
AL_FUNC(const char *, al_get_shader_log, (ALLEGRO_SHADER *shader));
AL_FUNC(ALLEGRO_SHADER_PLATFORM, al_get_shader_platform, (ALLEGRO_SHADER *shader));
AL_FUNC(bool, al_use_shader, (ALLEGRO_SHADER *shader));
AL_FUNC(void, al_destroy_shader, (ALLEGRO_SHADER *shader));

AL_FUNC(bool, al_set_shader_sampler, (const char *name, ALLEGRO_BITMAP *bitmap,
   int unit));
AL_FUNC(bool, al_set_shader_matrix, (const char *name,
   const ALLEGRO_TRANSFORM *matrix));
AL_FUNC(bool, al_set_shader_int, (const char *name, int i));
AL_FUNC(bool, al_set_shader_float, (const char *name, float f));
AL_FUNC(bool, al_set_shader_int_vector, (const char *name, int num_components,
   const int *i, int num_elems));
AL_FUNC(bool, al_set_shader_float_vector, (const char *name, int num_components,
   const float *f, int num_elems));
AL_FUNC(bool, al_set_shader_bool, (const char *name, bool b));

AL_FUNC(char const *, al_get_default_shader_source, (ALLEGRO_SHADER_PLATFORM platform,
   ALLEGRO_SHADER_TYPE type));

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
