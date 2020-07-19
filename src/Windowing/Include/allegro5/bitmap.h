#ifndef __al_included_allegro5_bitmap_h
#define __al_included_allegro5_bitmap_h

#include <allegro5/color.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Type: ALLEGRO_BITMAP
 */
typedef struct ALLEGRO_BITMAP ALLEGRO_BITMAP;


/*
 * Bitmap flags
 */
enum {
   ALLEGRO_MEMORY_BITMAP            = 0x0001,
   _ALLEGRO_KEEP_BITMAP_FORMAT      = 0x0002,	/* now a bitmap loader flag */
   ALLEGRO_FORCE_LOCKING            = 0x0004,	/* no longer honoured */
   ALLEGRO_NO_PRESERVE_TEXTURE      = 0x0008,
   _ALLEGRO_ALPHA_TEST              = 0x0010,   /* now a render state flag */
   _ALLEGRO_INTERNAL_OPENGL         = 0x0020,
   ALLEGRO_MIN_LINEAR               = 0x0040,
   ALLEGRO_MAG_LINEAR               = 0x0080,
   ALLEGRO_MIPMAP                   = 0x0100,
   _ALLEGRO_NO_PREMULTIPLIED_ALPHA  = 0x0200,	/* now a bitmap loader flag */
   ALLEGRO_VIDEO_BITMAP             = 0x0400,
   ALLEGRO_CONVERT_BITMAP           = 0x1000
};


AL_FUNC(void, al_set_new_bitmap_format, (int format));
AL_FUNC(void, al_set_new_bitmap_flags, (int flags));
AL_FUNC(int, al_get_new_bitmap_format, (void));
AL_FUNC(int, al_get_new_bitmap_flags, (void));
AL_FUNC(void, al_add_new_bitmap_flag, (int flag));

#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
AL_FUNC(int, al_get_new_bitmap_depth, (void));
AL_FUNC(void, al_set_new_bitmap_depth, (int depth));
AL_FUNC(int, al_get_new_bitmap_samples, (void));
AL_FUNC(void, al_set_new_bitmap_samples, (int samples));
#endif

AL_FUNC(int, al_get_bitmap_width, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_height, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_format, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_flags, (ALLEGRO_BITMAP *bitmap));

#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
AL_FUNC(int, al_get_bitmap_depth, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_samples, (ALLEGRO_BITMAP *bitmap));
#endif

AL_FUNC(ALLEGRO_BITMAP*, al_create_bitmap, (int w, int h));
AL_FUNC(void, al_destroy_bitmap, (ALLEGRO_BITMAP *bitmap));

AL_FUNC(void, al_put_pixel, (int x, int y, ALLEGRO_COLOR color));
AL_FUNC(void, al_put_blended_pixel, (int x, int y, ALLEGRO_COLOR color));
AL_FUNC(ALLEGRO_COLOR, al_get_pixel, (ALLEGRO_BITMAP *bitmap, int x, int y));

/* Masking */
AL_FUNC(void, al_convert_mask_to_alpha, (ALLEGRO_BITMAP *bitmap, ALLEGRO_COLOR mask_color));

/* Blending */
#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
AL_FUNC(ALLEGRO_COLOR, al_get_bitmap_blend_color, (void));
AL_FUNC(void, al_get_bitmap_blender, (int *op, int *src, int *dst));
AL_FUNC(void, al_get_separate_bitmap_blender, (int *op, int *src, int *dst, int *alpha_op, int *alpha_src, int *alpha_dst));
AL_FUNC(void, al_set_bitmap_blend_color, (ALLEGRO_COLOR color));
AL_FUNC(void, al_set_bitmap_blender, (int op, int src, int dst));
AL_FUNC(void, al_set_separate_bitmap_blender, (int op, int src, int dst, int alpha_op, int alpha_src, int alpha_dst));
AL_FUNC(void, al_reset_bitmap_blender, (void));
#endif

/* Clipping */
AL_FUNC(void, al_set_clipping_rectangle, (int x, int y, int width, int height));
AL_FUNC(void, al_reset_clipping_rectangle, (void));
AL_FUNC(void, al_get_clipping_rectangle, (int *x, int *y, int *w, int *h));

/* Sub bitmaps */
AL_FUNC(ALLEGRO_BITMAP *, al_create_sub_bitmap, (ALLEGRO_BITMAP *parent, int x, int y, int w, int h));
AL_FUNC(bool, al_is_sub_bitmap, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(ALLEGRO_BITMAP *, al_get_parent_bitmap, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_x, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(int, al_get_bitmap_y, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(void, al_reparent_bitmap, (ALLEGRO_BITMAP *bitmap,
   ALLEGRO_BITMAP *parent, int x, int y, int w, int h));

/* Miscellaneous */
AL_FUNC(ALLEGRO_BITMAP *, al_clone_bitmap, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(void, al_convert_bitmap, (ALLEGRO_BITMAP *bitmap));
AL_FUNC(void, al_convert_memory_bitmaps, (void));
#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
AL_FUNC(void, al_backup_dirty_bitmap, (ALLEGRO_BITMAP *bitmap));
#endif

#ifdef __cplusplus
   }
#endif

#endif
