#ifndef __al_included_allegro5_aintern_opengl_h
#define __al_included_allegro5_aintern_opengl_h

#include <allegro5/opengl/gl_ext.h>
#include <allegro5/internal/aintern_bitmap.h>
#include <allegro5/internal/aintern_display.h>

#ifdef __cplusplus
extern "C" {
#endif


enum {
   _ALLEGRO_OPENGL_VERSION_0     = 0, /* dummy */
   _ALLEGRO_OPENGL_VERSION_1_0   = 0x01000000,
   _ALLEGRO_OPENGL_VERSION_1_1   = 0x01010000,
   _ALLEGRO_OPENGL_VERSION_1_2   = 0x01020000,
   _ALLEGRO_OPENGL_VERSION_1_2_1 = 0x01020100,
   _ALLEGRO_OPENGL_VERSION_1_3   = 0x01030000,
   _ALLEGRO_OPENGL_VERSION_1_4   = 0x01040000,
   _ALLEGRO_OPENGL_VERSION_1_5   = 0x01050000,
   _ALLEGRO_OPENGL_VERSION_2_0   = 0x02000000,
   _ALLEGRO_OPENGL_VERSION_2_1   = 0x02010000,
   _ALLEGRO_OPENGL_VERSION_3_0   = 0x03000000,
   _ALLEGRO_OPENGL_VERSION_3_1   = 0x03010000,
   _ALLEGRO_OPENGL_VERSION_3_2   = 0x03020000,
   _ALLEGRO_OPENGL_VERSION_3_3   = 0x03030000,
   _ALLEGRO_OPENGL_VERSION_4_0   = 0x04000000
};

#define ALLEGRO_MAX_OPENGL_FBOS 8

enum {
   FBO_INFO_UNUSED      = 0,
   FBO_INFO_TRANSIENT   = 1,  /* may be destroyed for another bitmap */
   FBO_INFO_PERSISTENT  = 2   /* exclusive to the owner bitmap */
};

typedef struct ALLEGRO_FBO_BUFFERS
{
   /* It is not easy to determine the best lifetime for these. Unlike
    * FBOs they are heavy objects and re-creating them can be costly.
    * However if we make them part of ALLEGRO_BITMAP_EXTRA_OPENGL
    * below, there is no way to release them. I.e. if you create
    * many bitmaps in the beginning of your game and need depth and/or
    * multisampling for them, the only way to free the buffers would be
    * to copy those bitmaps and then destroy them.
    *
    * By tying them to the FBO struct, there is a limit of how many
    * buffers Allegro will create before recycling them. This will
    * work very well in the case where you only have one or a few
    * bitmaps you regularly draw into.
    */
   GLuint depth_buffer;
   int dw, dh, depth;
   
   GLuint multisample_buffer;
   int mw, mh, samples;
} ALLEGRO_FBO_BUFFERS;

typedef struct ALLEGRO_FBO_INFO
{
   int fbo_state;
   GLuint fbo;

   ALLEGRO_FBO_BUFFERS buffers;
      
   ALLEGRO_BITMAP *owner;
   double last_use_time;
} ALLEGRO_FBO_INFO;

typedef struct ALLEGRO_BITMAP_EXTRA_OPENGL
{
   /* Driver specifics. */

   int true_w;
   int true_h;

   GLuint texture; /* 0 means, not uploaded yet. */

   ALLEGRO_FBO_INFO *fbo_info;

   /* When an OpenGL bitmap is locked, the locked region is usually backed by a
    * temporary memory buffer pointed to by lock_buffer.
    *
    * On GLES, a locked backbuffer may be backed by a texture bitmap pointed to
    * by lock_proxy instead, and lock_buffer is NULL.  Upon unlocking the proxy
    * bitmap is drawn onto the backbuffer.
    */
   unsigned char *lock_buffer;
   ALLEGRO_BITMAP *lock_proxy;

   float left, top, right, bottom; /* Texture coordinates. */
   bool is_backbuffer; /* This is not a real bitmap, but the backbuffer. */
} ALLEGRO_BITMAP_EXTRA_OPENGL;

typedef struct OPENGL_INFO {
   uint32_t version;       /* OpenGL version */
   int max_texture_size;   /* Maximum texture size */
   int is_voodoo3_and_under; /* Special cases for Voodoo 1-3 */
   int is_voodoo;          /* Special cases for Voodoo cards */
   int is_matrox_g200;     /* Special cases for Matrox G200 boards */
   int is_ati_rage_pro;    /* Special cases for ATI Rage Pro boards */
   int is_ati_radeon_7000; /* Special cases for ATI Radeon 7000 */
   int is_ati_r200_chip;	/* Special cases for ATI card with chip R200 */
   int is_mesa_driver;     /* Special cases for MESA */
   int is_intel_hd_graphics_3000;
} OPENGL_INFO;


typedef struct ALLEGRO_OGL_VARLOCS
{
   /* Cached shader variable locations. */
   GLint pos_loc;
   GLint color_loc;
   GLint projview_matrix_loc;
   GLint texcoord_loc;
   GLint use_tex_loc;
   GLint tex_loc;
   GLint use_tex_matrix_loc;
   GLint tex_matrix_loc;
   GLint alpha_test_loc;
   GLint alpha_func_loc;
   GLint alpha_test_val_loc;
   GLint user_attr_loc[_ALLEGRO_PRIM_MAX_USER_ATTR];
} ALLEGRO_OGL_VARLOCS;

typedef struct ALLEGRO_OGL_EXTRAS
{
   /* A list of extensions supported by Allegro, for this context. */
   ALLEGRO_OGL_EXT_LIST *extension_list;
   /* A list of extension API, loaded by Allegro, for this context. */
   ALLEGRO_OGL_EXT_API *extension_api;
   /* Various info about OpenGL implementation. */
   OPENGL_INFO ogl_info;

   ALLEGRO_BITMAP *opengl_target;

   ALLEGRO_BITMAP *backbuffer;

   /* True if display resources are shared among displays. */
   bool is_shared;

   ALLEGRO_FBO_INFO fbos[ALLEGRO_MAX_OPENGL_FBOS];

   /* In non-programmable pipe mode this should be zero.
    * In programmable pipeline mode this should be non-zero.
    */
   GLuint program_object;
   ALLEGRO_OGL_VARLOCS varlocs;

   /* For OpenGL 3.0+ we use a single vao and vbo. */
   GLuint vao, vbo;

} ALLEGRO_OGL_EXTRAS;

typedef struct ALLEGRO_OGL_BITMAP_VERTEX
{
   float x, y, z;
   float tx, ty;
   float r, g, b, a;
} ALLEGRO_OGL_BITMAP_VERTEX;


/* extensions */
int  _al_ogl_look_for_an_extension(const char *name, const GLubyte *extensions);
void _al_ogl_set_extensions(ALLEGRO_OGL_EXT_API *ext);
void _al_ogl_manage_extensions(ALLEGRO_DISPLAY *disp);
void _al_ogl_unmanage_extensions(ALLEGRO_DISPLAY *disp);

/* bitmap */
int _al_ogl_get_glformat(int format, int component);
ALLEGRO_BITMAP *_al_ogl_create_bitmap(ALLEGRO_DISPLAY *d, int w, int h,
    int format, int flags);
void _al_ogl_upload_bitmap_memory(ALLEGRO_BITMAP *bitmap, int format, void *ptr);

/* locking */
#ifndef ALLEGRO_CFG_OPENGLES
   ALLEGRO_LOCKED_REGION *_al_ogl_lock_region_new(ALLEGRO_BITMAP *bitmap,
      int x, int y, int w, int h, int format, int flags);
   void _al_ogl_unlock_region_new(ALLEGRO_BITMAP *bitmap);
#else
   ALLEGRO_LOCKED_REGION *_al_ogl_lock_region_gles(ALLEGRO_BITMAP *bitmap,
      int x, int y, int w, int h, int format, int flags);
   void _al_ogl_unlock_region_gles(ALLEGRO_BITMAP *bitmap);
#endif

int _al_ogl_pixel_alignment(int pixel_size, bool compressed);

/* framebuffer objects */
GLint _al_ogl_bind_framebuffer(GLint fbo);
void _al_ogl_reset_fbo_info(ALLEGRO_FBO_INFO *info);
bool _al_ogl_create_persistent_fbo(ALLEGRO_BITMAP *bitmap);
ALLEGRO_FBO_INFO *_al_ogl_persist_fbo(ALLEGRO_DISPLAY *display,
                                      ALLEGRO_FBO_INFO *transient_fbo_info);
void _al_ogl_setup_fbo(ALLEGRO_DISPLAY *display, ALLEGRO_BITMAP *bitmap);
bool _al_ogl_setup_fbo_non_backbuffer(ALLEGRO_DISPLAY *display,
                                      ALLEGRO_BITMAP *bitmap);
void _al_ogl_del_fbo(ALLEGRO_FBO_INFO *info);

/* common driver */
void _al_ogl_setup_gl(ALLEGRO_DISPLAY *d);
void _al_ogl_set_target_bitmap(ALLEGRO_DISPLAY *display, ALLEGRO_BITMAP *bitmap);
void _al_ogl_unset_target_bitmap(ALLEGRO_DISPLAY *display, ALLEGRO_BITMAP *bitmap);
void _al_ogl_finalize_fbo(ALLEGRO_DISPLAY *display, ALLEGRO_BITMAP *bitmap);
void _al_ogl_setup_bitmap_clipping(const ALLEGRO_BITMAP *bitmap);
ALLEGRO_BITMAP *_al_ogl_get_backbuffer(ALLEGRO_DISPLAY *d);
ALLEGRO_BITMAP* _al_ogl_create_backbuffer(ALLEGRO_DISPLAY *disp);
void _al_ogl_destroy_backbuffer(ALLEGRO_BITMAP *b);
bool _al_ogl_resize_backbuffer(ALLEGRO_BITMAP *b, int w, int h);
void _al_opengl_backup_dirty_bitmaps(ALLEGRO_DISPLAY *d, bool flip);

/* draw */
struct ALLEGRO_DISPLAY_INTERFACE;
void _al_ogl_add_drawing_functions(struct ALLEGRO_DISPLAY_INTERFACE *vt);

AL_FUNC(bool, _al_opengl_set_blender, (ALLEGRO_DISPLAY *disp));
AL_FUNC(char const *, _al_gl_error_string, (GLenum e));

void _al_ogl_update_render_state(ALLEGRO_DISPLAY *display);

/* shader */
#ifdef ALLEGRO_CFG_SHADER_GLSL
   bool _al_glsl_set_projview_matrix(GLint projview_matrix_loc,
      const ALLEGRO_TRANSFORM *t);
   void _al_glsl_init_shaders(void);
   void _al_glsl_shutdown_shaders(void);
   void _al_glsl_unuse_shaders(void);
#endif


#ifdef __cplusplus
}
#endif

#endif
