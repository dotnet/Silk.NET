#ifndef __al_included_allegro5_aintern_bitmap_h
#define __al_included_allegro5_aintern_bitmap_h

#include <allegro5/bitmap.h>
#include <allegro5/bitmap_lock.h>
#include <allegro5/display.h>
#include <allegro5/render_state.h>
#include <allegro5/transformations.h>
#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_list.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct ALLEGRO_BITMAP_INTERFACE ALLEGRO_BITMAP_INTERFACE;

struct ALLEGRO_BITMAP
{
   ALLEGRO_BITMAP_INTERFACE *vt;

   /*
    * When this is a sub-bitmap, these are inherited from the parent. Don't
    * access them directly, but use al_get_bitmap_format/flags or
    * _al_get_bitmap_display unless you are super sure this is not a sub-bitmap
    * (e.g. when you're creating a new bitmap).
    */
   int _format;
   int _flags;
   int _depth;
   int _samples;
   ALLEGRO_DISPLAY *_display;
   /* What format is used for the backing memory
    * (can be different from _format, for e.g. compressed bitmaps) */
   int _memory_format;

   int w, h;
   /*
    * The number of bytes between a pixel at (x,y) and (x,y+1).
    * This is larger than w * pixel_size if there is padding between lines.
    */
   int pitch;
   /* 
    * clip left, right, top, bottom
    * Clip anything outside of this. cr/cb are exclusive, that is (0, 0, 1, 1)
    * is the single pixel spawning a rectangle from floating point 0/0 to 1/1 -
    * or in other words, the single pixel 0/0.
    *
    * There is always confusion as to whether cr/cb are exclusive, leading to
    * subtle bugs.  The suffixes are supposed to help with that.
    */
   int cl;
   int cr_excl;
   int ct;
   int cb_excl;
   /*
    * Locking info.
    *
    * These values represent the actual locking dimensions, which may be different
    * from what was passed in to al_lock_bitmap_region. This is transparent to the
    * user, but the internal drawing functions must take this into account. To
    * that end, use this lock_data parameter value and NOT the one in locked_region.
    *
    * locked - locked or not?
    * lock_x/y - top left of the locked region
    * lock_w/h - width and height of the locked region
    * lock_flags - flags the region was locked with
    * lock_data - the pointer to the real locked data (see above)
    * locked_region - a copy of the locked rectangle
    */
   bool locked;
   int lock_x;
   int lock_y;
   int lock_w;
   int lock_h;
   void* lock_data;
   int lock_flags;
   ALLEGRO_LOCKED_REGION locked_region;

   /* Transformation for this bitmap */
   ALLEGRO_TRANSFORM transform;
   ALLEGRO_TRANSFORM inverse_transform;
   bool              inverse_transform_dirty;
   ALLEGRO_TRANSFORM proj_transform;

   /* Blender for this bitmap (if not set, use TLS) */
   bool            use_bitmap_blender;
   ALLEGRO_BLENDER blender;

   /* Shader applied to this bitmap.  Set this field with
    * _al_set_bitmap_shader_field to maintain invariants.
    */
   ALLEGRO_SHADER *shader;

   /* Info for sub-bitmaps */
   ALLEGRO_BITMAP *parent;
   int xofs;
   int yofs;

   /* A memory copy of the bitmap data. May be NULL for an empty bitmap. */
   unsigned char *memory;

   /* Extra data for display bitmaps, like texture id and so on. */
   void *extra;

   _AL_LIST_ITEM *dtor_item;

   /* set_target_bitmap and lock_bitmap mark bitmaps as dirty for preservation */
   bool dirty;
};

struct ALLEGRO_BITMAP_INTERFACE
{
   int id;

   void (*draw_bitmap_region)(ALLEGRO_BITMAP *bitmap,
      ALLEGRO_COLOR tint,float sx, float sy,
      float sw, float sh, int flags);

   /* After the memory-copy of the bitmap has been modified, need to call this
    * to update the display-specific copy. E.g. with an OpenGL driver, this
    * might create/update a texture. Returns false on failure.
    */
   bool (*upload_bitmap)(ALLEGRO_BITMAP *bitmap);

   void (*update_clipping_rectangle)(ALLEGRO_BITMAP *bitmap);

   void (*destroy_bitmap)(ALLEGRO_BITMAP *bitmap);

   ALLEGRO_LOCKED_REGION * (*lock_region)(ALLEGRO_BITMAP *bitmap,
      int x, int y, int w, int h, int format, int flags);

   void (*unlock_region)(ALLEGRO_BITMAP *bitmap);

   ALLEGRO_LOCKED_REGION * (*lock_compressed_region)(ALLEGRO_BITMAP *bitmap,
      int x, int y, int w, int h, int flags);

   void (*unlock_compressed_region)(ALLEGRO_BITMAP *bitmap);

   /* Used to update any dangling pointers the bitmap driver might keep. */
   void (*bitmap_pointer_changed)(ALLEGRO_BITMAP *bitmap, ALLEGRO_BITMAP *old);

   /* Back up texture to system RAM */
   void (*backup_dirty_bitmap)(ALLEGRO_BITMAP *bitmap);
};

ALLEGRO_BITMAP *_al_create_bitmap_params(ALLEGRO_DISPLAY *current_display,
   int w, int h, int format, int flags, int depth, int samples);

AL_FUNC(ALLEGRO_DISPLAY*, _al_get_bitmap_display, (ALLEGRO_BITMAP *bitmap));

extern void (*_al_convert_funcs[ALLEGRO_NUM_PIXEL_FORMATS]
   [ALLEGRO_NUM_PIXEL_FORMATS])(const void *, int, void *, int,
   int, int, int, int, int, int);

/* Bitmap conversion */
void _al_convert_bitmap_data(
	const void *src, int src_format, int src_pitch,
	void *dst, int dst_format, int dst_pitch,
	int sx, int sy, int dx, int dy,
	int width, int height);

void _al_copy_bitmap_data(
   const void *src, int src_pitch, void *dst, int dst_pitch,
   int sx, int sy, int dx, int dy, int width, int height,
   int format);

/* Bitmap type conversion */ 
void _al_init_convert_bitmap_list(void);
void _al_register_convert_bitmap(ALLEGRO_BITMAP *bitmap);
void _al_unregister_convert_bitmap(ALLEGRO_BITMAP *bitmap);
void _al_convert_to_display_bitmap(ALLEGRO_BITMAP *bitmap);
void _al_convert_to_memory_bitmap(ALLEGRO_BITMAP *bitmap);

/* Simple bitmap drawing */
void _al_put_pixel(ALLEGRO_BITMAP *bitmap, int x, int y, ALLEGRO_COLOR color);

/* Bitmap I/O */
void _al_init_iio_table(void);


int _al_get_bitmap_memory_format(ALLEGRO_BITMAP *bitmap);

#ifdef __cplusplus
}
#endif

#endif
