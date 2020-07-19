#ifndef __al_included_allegro5_color_h
#define __al_included_allegro5_color_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Type: ALLEGRO_COLOR
 */
typedef struct ALLEGRO_COLOR ALLEGRO_COLOR;

struct ALLEGRO_COLOR
{
   float r, g, b, a;
};


/* Enum: ALLEGRO_PIXEL_FORMAT
 */
typedef enum ALLEGRO_PIXEL_FORMAT
{
   ALLEGRO_PIXEL_FORMAT_ANY                   = 0,
   ALLEGRO_PIXEL_FORMAT_ANY_NO_ALPHA          = 1,
   ALLEGRO_PIXEL_FORMAT_ANY_WITH_ALPHA        = 2,
   ALLEGRO_PIXEL_FORMAT_ANY_15_NO_ALPHA       = 3,
   ALLEGRO_PIXEL_FORMAT_ANY_16_NO_ALPHA       = 4,
   ALLEGRO_PIXEL_FORMAT_ANY_16_WITH_ALPHA     = 5,
   ALLEGRO_PIXEL_FORMAT_ANY_24_NO_ALPHA       = 6,
   ALLEGRO_PIXEL_FORMAT_ANY_32_NO_ALPHA       = 7,
   ALLEGRO_PIXEL_FORMAT_ANY_32_WITH_ALPHA     = 8,
   ALLEGRO_PIXEL_FORMAT_ARGB_8888             = 9,
   ALLEGRO_PIXEL_FORMAT_RGBA_8888             = 10,
   ALLEGRO_PIXEL_FORMAT_ARGB_4444             = 11,
   ALLEGRO_PIXEL_FORMAT_RGB_888               = 12, /* 24 bit format */
   ALLEGRO_PIXEL_FORMAT_RGB_565               = 13,
   ALLEGRO_PIXEL_FORMAT_RGB_555               = 14,
   ALLEGRO_PIXEL_FORMAT_RGBA_5551             = 15,
   ALLEGRO_PIXEL_FORMAT_ARGB_1555             = 16,
   ALLEGRO_PIXEL_FORMAT_ABGR_8888             = 17,
   ALLEGRO_PIXEL_FORMAT_XBGR_8888             = 18,
   ALLEGRO_PIXEL_FORMAT_BGR_888               = 19, /* 24 bit format */
   ALLEGRO_PIXEL_FORMAT_BGR_565               = 20,
   ALLEGRO_PIXEL_FORMAT_BGR_555               = 21,
   ALLEGRO_PIXEL_FORMAT_RGBX_8888             = 22,
   ALLEGRO_PIXEL_FORMAT_XRGB_8888             = 23,
   ALLEGRO_PIXEL_FORMAT_ABGR_F32              = 24,
   ALLEGRO_PIXEL_FORMAT_ABGR_8888_LE          = 25,
   ALLEGRO_PIXEL_FORMAT_RGBA_4444             = 26,
   ALLEGRO_PIXEL_FORMAT_SINGLE_CHANNEL_8      = 27,
   ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT1  = 28,
   ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT3  = 29,
   ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT5  = 30,
   ALLEGRO_NUM_PIXEL_FORMATS
} ALLEGRO_PIXEL_FORMAT;


/* Pixel mapping */
AL_FUNC(ALLEGRO_COLOR, al_map_rgb, (unsigned char r, unsigned char g, unsigned char b));
AL_FUNC(ALLEGRO_COLOR, al_map_rgba, (unsigned char r, unsigned char g, unsigned char b, unsigned char a));
AL_FUNC(ALLEGRO_COLOR, al_map_rgb_f, (float r, float g, float b));
AL_FUNC(ALLEGRO_COLOR, al_map_rgba_f, (float r, float g, float b, float a));
AL_FUNC(ALLEGRO_COLOR, al_premul_rgba,
   (unsigned char r, unsigned char g, unsigned char b, unsigned char a));
AL_FUNC(ALLEGRO_COLOR, al_premul_rgba_f,
   (float r, float g, float b, float a));

/* Pixel unmapping */
AL_FUNC(void, al_unmap_rgb, (ALLEGRO_COLOR color, unsigned char *r, unsigned char *g, unsigned char *b));
AL_FUNC(void, al_unmap_rgba, (ALLEGRO_COLOR color, unsigned char *r, unsigned char *g, unsigned char *b, unsigned char *a));
AL_FUNC(void, al_unmap_rgb_f, (ALLEGRO_COLOR color, float *r, float *g, float *b));
AL_FUNC(void, al_unmap_rgba_f, (ALLEGRO_COLOR color, float *r, float *g, float *b, float *a));

/* Pixel formats */
AL_FUNC(int, al_get_pixel_size, (int format));
AL_FUNC(int, al_get_pixel_format_bits, (int format));
AL_FUNC(int, al_get_pixel_block_size, (int format));
AL_FUNC(int, al_get_pixel_block_width, (int format));
AL_FUNC(int, al_get_pixel_block_height, (int format));

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set ts=8 sts=3 sw=3 et: */
