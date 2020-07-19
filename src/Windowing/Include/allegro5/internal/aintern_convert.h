// Warning: This file was created by make_converters.py - do not edit.
#ifndef __al_included_allegro5_aintern_convert_h
#define __al_included_allegro5_aintern_convert_h

#include <allegro5/allegro.h>
#include <allegro5/internal/aintern_pixels.h>
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGBA_8888(x) \
   ((((x) & 0xff000000) >> 24)        /* A */ | \
    (((x) & 0x00ffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_ARGB_4444(x) \
   ((((x) & 0xf0000000) >> 16)        /* A */ | \
    (((x) & 0x000000f0) >>  4)        /* B */ | \
    (((x) & 0x0000f000) >>  8)        /* G */ | \
    (((x) & 0x00f00000) >> 12)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGB_888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGB_565(x) \
   ((((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGB_555(x) \
   ((((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGBA_5551(x) \
   ((((x) & 0x80000000) >> 31)        /* A */ | \
    (((x) & 0x000000f8) >>  2)        /* B */ | \
    (((x) & 0x0000f800) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_ARGB_1555(x) \
   ((((x) & 0x80000000) >> 16)        /* A */ | \
    (((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_ABGR_8888(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */ | \
    ((x) & 0xff00ff00)              /* AG */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_XBGR_8888(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_BGR_888(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_BGR_565(x) \
   ((((x) & 0x000000f8) <<  8)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_BGR_555(x) \
   ((((x) & 0x000000f8) <<  7)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGBX_8888(x) \
   ((((x) & 0x00ffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_XRGB_8888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_ABGR_F32(x) \
   al_map_rgba(((x) >> 16) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 0) & 255,\
   ((x) >> 24) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ARGB_8888_TO_ABGR_8888_LE(x) \
   ((((x) & 0xff000000) >> 24)        /* A */ | \
    (((x) & 0x00ffffff) <<  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_ARGB_8888_TO_ABGR_8888_LE(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */ | \
    ((x) & 0xff00ff00)              /* AG */)   
#endif
#define ALLEGRO_CONVERT_ARGB_8888_TO_RGBA_4444(x) \
   ((((x) & 0xf0000000) >> 28)        /* A */ | \
    ((x) & 0x000000f0)              /* B */ | \
    (((x) & 0x0000f000) >>  4)        /* G */ | \
    (((x) & 0x00f00000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 16) & 0xff)
#define ALLEGRO_CONVERT_RGBA_8888_TO_ARGB_8888(x) \
   ((((x) & 0x000000ff) << 24)        /* A */ | \
    (((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_ARGB_4444(x) \
   ((((x) & 0x000000f0) <<  8)        /* A */ | \
    (((x) & 0x0000f000) >> 12)        /* B */ | \
    (((x) & 0x00f00000) >> 16)        /* G */ | \
    (((x) & 0xf0000000) >> 20)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGB_888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGB_565(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGB_555(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGBA_5551(x) \
   ((((x) & 0x00000080) >>  7)        /* A */ | \
    (((x) & 0x0000f800) >> 10)        /* B */ | \
    (((x) & 0x00f80000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_ARGB_1555(x) \
   ((((x) & 0x00000080) <<  8)        /* A */ | \
    (((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_ABGR_8888(x) \
   ((((x) & 0x000000ff) << 24)        /* A */ | \
    (((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_XBGR_8888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_BGR_888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_BGR_565(x) \
   (((x) & 0x0000f800)              /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_BGR_555(x) \
   ((((x) & 0x0000f800) >>  1)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGBX_8888(x) \
   (((x) & 0xffffff00)              /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_XRGB_8888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_ABGR_F32(x) \
   al_map_rgba(((x) >> 24) & 255,\
   ((x) >> 16) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 0) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGBA_8888_TO_ABGR_8888_LE(x) \
   (((x) & 0xffffffff)              /* ABGR */)   
#else
#define ALLEGRO_CONVERT_RGBA_8888_TO_ABGR_8888_LE(x) \
   ((((x) & 0x000000ff) << 24)        /* A */ | \
    (((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#endif
#define ALLEGRO_CONVERT_RGBA_8888_TO_RGBA_4444(x) \
   ((((x) & 0x000000f0) >>  4)        /* A */ | \
    (((x) & 0x0000f000) >>  8)        /* B */ | \
    (((x) & 0x00f00000) >> 12)        /* G */ | \
    (((x) & 0xf0000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 24) & 0xff)
#define ALLEGRO_CONVERT_ARGB_4444_TO_ARGB_8888(x) \
   ((_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x000f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGBA_8888(x) \
   ((_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x000f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 24) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGB_888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGB_565(x) \
   ((((x) & 0x000f) <<  1)        /* B */ | \
    (((x) & 0x00f0) <<  3)        /* G */ | \
    (((x) & 0x0f00) <<  4)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGB_555(x) \
   ((((x) & 0x000f) <<  1)        /* B */ | \
    (((x) & 0x00f0) <<  2)        /* G */ | \
    (((x) & 0x0f00) <<  3)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGBA_5551(x) \
   ((((x) & 0x8000) >> 15)        /* A */ | \
    (((x) & 0x000f) <<  2)        /* B */ | \
    (((x) & 0x00f0) <<  3)        /* G */ | \
    (((x) & 0x0f00) <<  4)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_ARGB_1555(x) \
   (((x) & 0x8000)              /* A */ | \
    (((x) & 0x000f) <<  1)        /* B */ | \
    (((x) & 0x00f0) <<  2)        /* G */ | \
    (((x) & 0x0f00) <<  3)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_ABGR_8888(x) \
   ((_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x000f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_XBGR_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_BGR_888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_BGR_565(x) \
   ((((x) & 0x000f) << 12)        /* B */ | \
    (((x) & 0x00f0) <<  3)        /* G */ | \
    (((x) & 0x0f00) >>  7)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_BGR_555(x) \
   ((((x) & 0x000f) << 11)        /* B */ | \
    (((x) & 0x00f0) <<  2)        /* G */ | \
    (((x) & 0x0f00) >>  7)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGBX_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 24) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_XRGB_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_ABGR_F32(x) \
   al_map_rgba(_al_rgb_scale_4[((x) >> 8) & 15],\
   _al_rgb_scale_4[((x) >> 4) & 15],\
   _al_rgb_scale_4[((x) >> 0) & 15],\
   _al_rgb_scale_4[((x) >> 12) & 15])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ARGB_4444_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x000f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_ARGB_4444_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x000f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_ARGB_4444_TO_RGBA_4444(x) \
   ((((x) & 0xf000) >> 12)        /* A */ | \
    (((x) & 0x0fff) <<  4)        /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_4444_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_4[(((x) >> 8) & 0xf)])
#define ALLEGRO_CONVERT_RGB_888_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0xffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_RGB_888_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0xffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGB_888_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x0000f0) >>  4)        /* B */ | \
    (((x) & 0x00f000) >>  8)        /* G */ | \
    (((x) & 0xf00000) >> 12)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_RGB_565(x) \
   ((((x) & 0x0000f8) >>  3)        /* B */ | \
    (((x) & 0x00fc00) >>  5)        /* G */ | \
    (((x) & 0xf80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_RGB_555(x) \
   ((((x) & 0x0000f8) >>  3)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0xf80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x0000f8) >>  2)        /* B */ | \
    (((x) & 0x00f800) >>  5)        /* G */ | \
    (((x) & 0xf80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0x0000f8) >>  3)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0xf80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x0000ff) << 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0xff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_XBGR_8888(x) \
   ((((x) & 0x0000ff) << 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0xff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_BGR_888(x) \
   ((((x) & 0x0000ff) << 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0xff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_BGR_565(x) \
   ((((x) & 0x0000f8) <<  8)        /* B */ | \
    (((x) & 0x00fc00) >>  5)        /* G */ | \
    (((x) & 0xf80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_BGR_555(x) \
   ((((x) & 0x0000f8) <<  7)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0xf80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_RGBX_8888(x) \
   ((((x) & 0xffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGB_888_TO_XRGB_8888(x) \
   (((x) & 0xffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_RGB_888_TO_ABGR_F32(x) \
   al_map_rgb(((x) >> 16) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 0) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGB_888_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0xffffff) <<  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_RGB_888_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x0000ff) << 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0xff0000) >> 16)        /* R */)   
#endif
#define ALLEGRO_CONVERT_RGB_888_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    ((x) & 0x0000f0)              /* B */ | \
    (((x) & 0x00f000) >>  4)        /* G */ | \
    (((x) & 0xf00000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_RGB_888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 16) & 0xff)
#define ALLEGRO_CONVERT_RGB_565_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x001e) >>  1)        /* B */ | \
    (((x) & 0x0780) >>  3)        /* G */ | \
    (((x) & 0xf000) >>  4)        /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_RGB_555(x) \
   (((x) & 0x001f)              /* B */ | \
    (((x) & 0xffc0) >>  1)        /* GR */)   
#define ALLEGRO_CONVERT_RGB_565_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x001f) <<  1)        /* B */ | \
    ((x) & 0xffc0)              /* GR */)   
#define ALLEGRO_CONVERT_RGB_565_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    ((x) & 0x001f)              /* B */ | \
    (((x) & 0xffc0) >>  1)        /* GR */)   
#define ALLEGRO_CONVERT_RGB_565_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_BGR_565(x) \
   ((((x) & 0x001f) << 11)        /* B */ | \
    ((x) & 0x07e0)              /* G */ | \
    (((x) & 0xf800) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_BGR_555(x) \
   ((((x) & 0x001f) << 10)        /* B */ | \
    (((x) & 0x07c0) >>  1)        /* G */ | \
    (((x) & 0xf800) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_ABGR_F32(x) \
   al_map_rgb(_al_rgb_scale_5[((x) >> 11) & 31],\
   _al_rgb_scale_6[((x) >> 5) & 63],\
   _al_rgb_scale_5[((x) >> 0) & 31])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGB_565_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_RGB_565_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_RGB_565_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0x001e) <<  3)        /* B */ | \
    (((x) & 0x0780) <<  1)        /* G */ | \
    ((x) & 0xf000)              /* R */)   
#define ALLEGRO_CONVERT_RGB_565_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 11) & 0x1f)])
#define ALLEGRO_CONVERT_RGB_555_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x01e) >>  1)        /* B */ | \
    (((x) & 0x3c0) >>  2)        /* G */ | \
    (((x) & 0x7800) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_RGB_565(x) \
   (((x) & 0x01f)              /* B */ | \
    (((x) & 0x7fe0) <<  1)        /* GR */)   
#define ALLEGRO_CONVERT_RGB_555_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x7fff) <<  1)        /* BGR */)   
#define ALLEGRO_CONVERT_RGB_555_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    ((x) & 0x7fff)              /* BGR */)   
#define ALLEGRO_CONVERT_RGB_555_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_BGR_565(x) \
   ((((x) & 0x01f) << 11)        /* B */ | \
    (((x) & 0x3e0) <<  1)        /* G */ | \
    (((x) & 0x7c00) >> 10)        /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_BGR_555(x) \
   ((((x) & 0x01f) << 10)        /* B */ | \
    ((x) & 0x3e0)              /* G */ | \
    (((x) & 0x7c00) >> 10)        /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x01f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_ABGR_F32(x) \
   al_map_rgb(_al_rgb_scale_5[((x) >> 10) & 31],\
   _al_rgb_scale_5[((x) >> 5) & 31],\
   _al_rgb_scale_5[((x) >> 0) & 31])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGB_555_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_RGB_555_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_RGB_555_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0x01e) <<  3)        /* B */ | \
    (((x) & 0x3c0) <<  2)        /* G */ | \
    (((x) & 0x7800) <<  1)        /* R */)   
#define ALLEGRO_CONVERT_RGB_555_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 10) & 0x1f)])
#define ALLEGRO_CONVERT_RGBA_5551_TO_ARGB_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x0001) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x003e) >>  1]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGBA_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x0001) >>  0]       ) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x003e) >>  1] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_ARGB_4444(x) \
   ((((x) & 0x0001) << 15)        /* A */ | \
    (((x) & 0x003c) >>  2)        /* B */ | \
    (((x) & 0x0780) >>  3)        /* G */ | \
    (((x) & 0xf000) >>  4)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0x003e) >>  1]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGB_565(x) \
   ((((x) & 0x003e) >>  1)        /* B */ | \
    ((x) & 0xffc0)              /* GR */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGB_555(x) \
   ((((x) & 0xfffe) >>  1)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_ARGB_1555(x) \
   ((((x) & 0x0001) << 15)        /* A */ | \
    (((x) & 0xfffe) >>  1)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_ABGR_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x0001) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x003e) >>  1] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x003e) >>  1] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0x003e) >>  1] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_BGR_565(x) \
   ((((x) & 0x003e) << 10)        /* B */ | \
    ((x) & 0x07c0)              /* G */ | \
    (((x) & 0xf800) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_BGR_555(x) \
   ((((x) & 0x003e) <<  9)        /* B */ | \
    (((x) & 0x07c0) >>  1)        /* G */ | \
    (((x) & 0xf800) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x003e) >>  1] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x003e) >>  1]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_ABGR_F32(x) \
   al_map_rgba(_al_rgb_scale_5[((x) >> 11) & 31],\
   _al_rgb_scale_5[((x) >> 6) & 31],\
   _al_rgb_scale_5[((x) >> 1) & 31],\
   _al_rgb_scale_1[((x) >> 0) & 1])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGBA_5551_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_1[((x) & 0x0001) >>  0]       ) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x003e) >>  1] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_RGBA_5551_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_1[((x) & 0x0001) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x003e) >>  1] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x07c0) >>  6] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_RGBA_5551_TO_RGBA_4444(x) \
   ((((x) & 0x0001) <<  3)        /* A */ | \
    (((x) & 0x003c) <<  2)        /* B */ | \
    (((x) & 0x0780) <<  1)        /* G */ | \
    ((x) & 0xf000)              /* R */)   
#define ALLEGRO_CONVERT_RGBA_5551_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 11) & 0x1f)])
#define ALLEGRO_CONVERT_ARGB_1555_TO_ARGB_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x8000) >> 15] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGBA_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x8000) >> 15]       ) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_ARGB_4444(x) \
   (((x) & 0x8000)              /* A */ | \
    (((x) & 0x001e) >>  1)        /* B */ | \
    (((x) & 0x03c0) >>  2)        /* G */ | \
    (((x) & 0x7800) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGB_565(x) \
   (((x) & 0x001f)              /* B */ | \
    (((x) & 0x7fe0) <<  1)        /* GR */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGB_555(x) \
   (((x) & 0x7fff)              /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGBA_5551(x) \
   ((((x) & 0x8000) >> 15)        /* A */ | \
    (((x) & 0x7fff) <<  1)        /* BGR */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_ABGR_8888(x) \
   ((_al_rgb_scale_1[((x) & 0x8000) >> 15] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_BGR_565(x) \
   ((((x) & 0x001f) << 11)        /* B */ | \
    (((x) & 0x03e0) <<  1)        /* G */ | \
    (((x) & 0x7c00) >> 10)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_BGR_555(x) \
   ((((x) & 0x001f) << 10)        /* B */ | \
    ((x) & 0x03e0)              /* G */ | \
    (((x) & 0x7c00) >> 10)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_ABGR_F32(x) \
   al_map_rgba(_al_rgb_scale_5[((x) >> 10) & 31],\
   _al_rgb_scale_5[((x) >> 5) & 31],\
   _al_rgb_scale_5[((x) >> 0) & 31],\
   _al_rgb_scale_1[((x) >> 15) & 1])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ARGB_1555_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_1[((x) & 0x8000) >> 15]       ) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_ARGB_1555_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_1[((x) & 0x8000) >> 15] << 24) /* A */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x03e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_ARGB_1555_TO_RGBA_4444(x) \
   ((((x) & 0x8000) >> 12)        /* A */ | \
    (((x) & 0x001e) <<  3)        /* B */ | \
    (((x) & 0x03c0) <<  2)        /* G */ | \
    (((x) & 0x7800) <<  1)        /* R */)   
#define ALLEGRO_CONVERT_ARGB_1555_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 10) & 0x1f)])
#define ALLEGRO_CONVERT_ABGR_8888_TO_ARGB_8888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    (((x) & 0x000000ff) << 16)        /* R */ | \
    ((x) & 0xff00ff00)              /* AG */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGBA_8888(x) \
   ((((x) & 0xff000000) >> 24)        /* A */ | \
    (((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_ARGB_4444(x) \
   ((((x) & 0xf0000000) >> 16)        /* A */ | \
    (((x) & 0x00f00000) >> 20)        /* B */ | \
    (((x) & 0x0000f000) >>  8)        /* G */ | \
    (((x) & 0x000000f0) <<  4)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGB_888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGB_565(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGB_555(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGBA_5551(x) \
   ((((x) & 0x80000000) >> 31)        /* A */ | \
    (((x) & 0x00f80000) >> 18)        /* B */ | \
    (((x) & 0x0000f800) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_ARGB_1555(x) \
   ((((x) & 0x80000000) >> 16)        /* A */ | \
    (((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_XBGR_8888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_BGR_888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_BGR_565(x) \
   ((((x) & 0x00f80000) >>  8)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_BGR_555(x) \
   ((((x) & 0x00f80000) >>  9)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGBX_8888(x) \
   ((((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_XRGB_8888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_ABGR_F32(x) \
   al_map_rgba(((x) >> 0) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 16) & 255,\
   ((x) >> 24) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_TO_ABGR_8888_LE(x) \
   ((((x) & 0xff000000) >> 24)        /* A */ | \
    (((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_TO_ABGR_8888_LE(x) \
   (((x) & 0xffffffff)              /* ABGR */)   
#endif
#define ALLEGRO_CONVERT_ABGR_8888_TO_RGBA_4444(x) \
   ((((x) & 0xf0000000) >> 28)        /* A */ | \
    (((x) & 0x00f00000) >> 16)        /* B */ | \
    (((x) & 0x0000f000) >>  4)        /* G */ | \
    (((x) & 0x000000f0) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_ABGR_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 0) & 0xff)
#define ALLEGRO_CONVERT_XBGR_8888_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x00f00000) >> 20)        /* B */ | \
    (((x) & 0x0000f000) >>  8)        /* G */ | \
    (((x) & 0x000000f0) <<  4)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGB_888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGB_565(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGB_555(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x00f80000) >> 18)        /* B */ | \
    (((x) & 0x0000f800) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_BGR_888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_BGR_565(x) \
   ((((x) & 0x00f80000) >>  8)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_BGR_555(x) \
   ((((x) & 0x00f80000) >>  9)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGBX_8888(x) \
   ((((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_XRGB_8888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_ABGR_F32(x) \
   al_map_rgb(((x) >> 0) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 16) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_XBGR_8888_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_XBGR_8888_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0x00ffffff)              /* BGR */)   
#endif
#define ALLEGRO_CONVERT_XBGR_8888_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0x00f00000) >> 16)        /* B */ | \
    (((x) & 0x0000f000) >>  4)        /* G */ | \
    (((x) & 0x000000f0) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_XBGR_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 0) & 0xff)
#define ALLEGRO_CONVERT_BGR_888_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0xff0000) >> 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0x0000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0xff0000) >>  8)        /* B */ | \
    (((x) & 0x00ff00) <<  8)        /* G */ | \
    (((x) & 0x0000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0xf00000) >> 20)        /* B */ | \
    (((x) & 0x00f000) >>  8)        /* G */ | \
    (((x) & 0x0000f0) <<  4)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGB_888(x) \
   ((((x) & 0xff0000) >> 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0x0000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGB_565(x) \
   ((((x) & 0xf80000) >> 19)        /* B */ | \
    (((x) & 0x00fc00) >>  5)        /* G */ | \
    (((x) & 0x0000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGB_555(x) \
   ((((x) & 0xf80000) >> 19)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0x0000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0xf80000) >> 18)        /* B */ | \
    (((x) & 0x00f800) >>  5)        /* G */ | \
    (((x) & 0x0000f8) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0xf80000) >> 19)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0x0000f8) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0xffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_BGR_888_TO_XBGR_8888(x) \
   (((x) & 0xffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_BGR_888_TO_BGR_565(x) \
   ((((x) & 0xf80000) >>  8)        /* B */ | \
    (((x) & 0x00fc00) >>  5)        /* G */ | \
    (((x) & 0x0000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_BGR_555(x) \
   ((((x) & 0xf80000) >>  9)        /* B */ | \
    (((x) & 0x00f800) >>  6)        /* G */ | \
    (((x) & 0x0000f8) >>  3)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_RGBX_8888(x) \
   ((((x) & 0xff0000) >>  8)        /* B */ | \
    (((x) & 0x00ff00) <<  8)        /* G */ | \
    (((x) & 0x0000ff) << 24)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_XRGB_8888(x) \
   ((((x) & 0xff0000) >> 16)        /* B */ | \
    ((x) & 0x00ff00)              /* G */ | \
    (((x) & 0x0000ff) << 16)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_ABGR_F32(x) \
   al_map_rgb(((x) >> 0) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 16) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_BGR_888_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0xff0000) >>  8)        /* B */ | \
    (((x) & 0x00ff00) <<  8)        /* G */ | \
    (((x) & 0x0000ff) << 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_BGR_888_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0xffffff)              /* BGR */)   
#endif
#define ALLEGRO_CONVERT_BGR_888_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0xf00000) >> 16)        /* B */ | \
    (((x) & 0x00f000) >>  4)        /* G */ | \
    (((x) & 0x0000f0) <<  8)        /* R */)   
#define ALLEGRO_CONVERT_BGR_888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 0) & 0xff)
#define ALLEGRO_CONVERT_BGR_565_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 24) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0xf000) >> 12)        /* B */ | \
    (((x) & 0x0780) >>  3)        /* G */ | \
    (((x) & 0x001e) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGB_565(x) \
   ((((x) & 0xf800) >> 11)        /* B */ | \
    ((x) & 0x07e0)              /* G */ | \
    (((x) & 0x001f) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGB_555(x) \
   ((((x) & 0xf800) >> 11)        /* B */ | \
    (((x) & 0x07c0) >>  1)        /* G */ | \
    (((x) & 0x001f) << 10)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0xf800) >> 10)        /* B */ | \
    ((x) & 0x07c0)              /* G */ | \
    (((x) & 0x001f) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0xf800) >> 11)        /* B */ | \
    (((x) & 0x07c0) >>  1)        /* G */ | \
    (((x) & 0x001f) << 10)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_BGR_555(x) \
   (((x) & 0x001f)              /* R */ | \
    (((x) & 0xffc0) >>  1)        /* BG */)   
#define ALLEGRO_CONVERT_BGR_565_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0xf800) >> 11] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 24) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0xf800) >> 11]       ) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_ABGR_F32(x) \
   al_map_rgb(_al_rgb_scale_5[((x) >> 0) & 31],\
   _al_rgb_scale_6[((x) >> 5) & 63],\
   _al_rgb_scale_5[((x) >> 11) & 31])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_BGR_565_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] <<  8) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_BGR_565_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0xf800) >> 11] << 16) /* B */ | \
    (_al_rgb_scale_6[((x) & 0x07e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x001f) >>  0]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_BGR_565_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0xf000) >>  8)        /* B */ | \
    (((x) & 0x0780) <<  1)        /* G */ | \
    (((x) & 0x001e) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_565_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 0) & 0x1f)])
#define ALLEGRO_CONVERT_BGR_555_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 24) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x7800) >> 11)        /* B */ | \
    (((x) & 0x3c0) >>  2)        /* G */ | \
    (((x) & 0x01e) <<  7)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGB_888(x) \
   ((_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGB_565(x) \
   ((((x) & 0x7c00) >> 10)        /* B */ | \
    (((x) & 0x3e0) <<  1)        /* G */ | \
    (((x) & 0x01f) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGB_555(x) \
   ((((x) & 0x7c00) >> 10)        /* B */ | \
    ((x) & 0x3e0)              /* G */ | \
    (((x) & 0x01f) << 10)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x7c00) >>  9)        /* B */ | \
    (((x) & 0x3e0) <<  1)        /* G */ | \
    (((x) & 0x01f) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0x7c00) >> 10)        /* B */ | \
    ((x) & 0x3e0)              /* G */ | \
    (((x) & 0x01f) << 10)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_XBGR_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_BGR_888(x) \
   ((_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_BGR_565(x) \
   (((x) & 0x01f)              /* R */ | \
    (((x) & 0x7fe0) <<  1)        /* BG */)   
#define ALLEGRO_CONVERT_BGR_555_TO_RGBX_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x7c00) >> 10] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 24) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_XRGB_8888(x) \
   ((_al_rgb_scale_5[((x) & 0x7c00) >> 10]       ) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 16) /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_ABGR_F32(x) \
   al_map_rgb(_al_rgb_scale_5[((x) >> 0) & 31],\
   _al_rgb_scale_5[((x) >> 5) & 31],\
   _al_rgb_scale_5[((x) >> 10) & 31])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_BGR_555_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] <<  8) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] << 16) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_BGR_555_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (_al_rgb_scale_5[((x) & 0x7c00) >> 10] << 16) /* B */ | \
    (_al_rgb_scale_5[((x) & 0x3e0) >>  5] <<  8) /* G */ | \
    (_al_rgb_scale_5[((x) & 0x01f) >>  0]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_BGR_555_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0x7800) >>  7)        /* B */ | \
    (((x) & 0x3c0) <<  2)        /* G */ | \
    (((x) & 0x01e) << 11)        /* R */)   
#define ALLEGRO_CONVERT_BGR_555_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_5[(((x) >> 0) & 0x1f)])
#define ALLEGRO_CONVERT_RGBX_8888_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    ((x) & 0xffffff00)              /* BGR */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x0000f000) >> 12)        /* B */ | \
    (((x) & 0x00f00000) >> 16)        /* G */ | \
    (((x) & 0xf0000000) >> 20)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGB_888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGB_565(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGB_555(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x0000f800) >> 10)        /* B */ | \
    (((x) & 0x00f80000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_XBGR_8888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_BGR_888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_BGR_565(x) \
   (((x) & 0x0000f800)              /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_BGR_555(x) \
   ((((x) & 0x0000f800) >>  1)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_XRGB_8888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_ABGR_F32(x) \
   al_map_rgb(((x) >> 24) & 255,\
   ((x) >> 16) & 255,\
   ((x) >> 8) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGBX_8888_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    ((x) & 0xffffff00)              /* BGR */)   
#else
#define ALLEGRO_CONVERT_RGBX_8888_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#endif
#define ALLEGRO_CONVERT_RGBX_8888_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    (((x) & 0x0000f000) >>  8)        /* B */ | \
    (((x) & 0x00f00000) >> 12)        /* G */ | \
    (((x) & 0xf0000000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_RGBX_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 24) & 0xff)
#define ALLEGRO_CONVERT_XRGB_8888_TO_ARGB_8888(x) \
   ((0xff000000)        /* A */ | \
    ((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGBA_8888(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0x00ffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_ARGB_4444(x) \
   ((0xf000)        /* A */ | \
    (((x) & 0x000000f0) >>  4)        /* B */ | \
    (((x) & 0x0000f000) >>  8)        /* G */ | \
    (((x) & 0x00f00000) >> 12)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGB_888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGB_565(x) \
   ((((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGB_555(x) \
   ((((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGBA_5551(x) \
   ((0x0001)        /* A */ | \
    (((x) & 0x000000f8) >>  2)        /* B */ | \
    (((x) & 0x0000f800) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_ARGB_1555(x) \
   ((0x8000)        /* A */ | \
    (((x) & 0x000000f8) >>  3)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >>  9)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_ABGR_8888(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_XBGR_8888(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_BGR_888(x) \
   ((((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_BGR_565(x) \
   ((((x) & 0x000000f8) <<  8)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x00f80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_BGR_555(x) \
   ((((x) & 0x000000f8) <<  7)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x00f80000) >> 19)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGBX_8888(x) \
   ((((x) & 0x00ffffff) <<  8)        /* BGR */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_ABGR_F32(x) \
   al_map_rgb(((x) >> 16) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 0) & 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_XRGB_8888_TO_ABGR_8888_LE(x) \
   ((0x000000ff)        /* A */ | \
    (((x) & 0x00ffffff) <<  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_XRGB_8888_TO_ABGR_8888_LE(x) \
   ((0xff000000)        /* A */ | \
    (((x) & 0x000000ff) << 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x00ff0000) >> 16)        /* R */)   
#endif
#define ALLEGRO_CONVERT_XRGB_8888_TO_RGBA_4444(x) \
   ((0x000f)        /* A */ | \
    ((x) & 0x000000f0)              /* B */ | \
    (((x) & 0x0000f000) >>  4)        /* G */ | \
    (((x) & 0x00f00000) >>  8)        /* R */)   
#define ALLEGRO_CONVERT_XRGB_8888_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 16) & 0xff)
#define ALLEGRO_CONVERT_ABGR_F32_TO_ARGB_8888(x) \
   (((uint32_t)((x).a * 255) << 24) | \
    ((uint32_t)((x).b * 255) << 0) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 16))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGBA_8888(x) \
   (((uint32_t)((x).a * 255) << 0) | \
    ((uint32_t)((x).b * 255) << 8) | \
    ((uint32_t)((x).g * 255) << 16) | \
    ((uint32_t)((x).r * 255) << 24))
#define ALLEGRO_CONVERT_ABGR_F32_TO_ARGB_4444(x) \
   (((uint32_t)((x).a * 15) << 12) | \
    ((uint32_t)((x).b * 15) << 0) | \
    ((uint32_t)((x).g * 15) << 4) | \
    ((uint32_t)((x).r * 15) << 8))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGB_888(x) \
   (((uint32_t)((x).b * 255) << 0) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 16))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGB_565(x) \
   (((uint32_t)((x).b * 31) << 0) | \
    ((uint32_t)((x).g * 63) << 5) | \
    ((uint32_t)((x).r * 31) << 11))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGB_555(x) \
   (((uint32_t)((x).b * 31) << 0) | \
    ((uint32_t)((x).g * 31) << 5) | \
    ((uint32_t)((x).r * 31) << 10))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGBA_5551(x) \
   (((uint32_t)((x).a * 1) << 0) | \
    ((uint32_t)((x).b * 31) << 1) | \
    ((uint32_t)((x).g * 31) << 6) | \
    ((uint32_t)((x).r * 31) << 11))
#define ALLEGRO_CONVERT_ABGR_F32_TO_ARGB_1555(x) \
   (((uint32_t)((x).a * 1) << 15) | \
    ((uint32_t)((x).b * 31) << 0) | \
    ((uint32_t)((x).g * 31) << 5) | \
    ((uint32_t)((x).r * 31) << 10))
#define ALLEGRO_CONVERT_ABGR_F32_TO_ABGR_8888(x) \
   (((uint32_t)((x).a * 255) << 24) | \
    ((uint32_t)((x).b * 255) << 16) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 0))
#define ALLEGRO_CONVERT_ABGR_F32_TO_XBGR_8888(x) \
   (((uint32_t)((x).b * 255) << 16) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 0))
#define ALLEGRO_CONVERT_ABGR_F32_TO_BGR_888(x) \
   (((uint32_t)((x).b * 255) << 16) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 0))
#define ALLEGRO_CONVERT_ABGR_F32_TO_BGR_565(x) \
   (((uint32_t)((x).b * 31) << 11) | \
    ((uint32_t)((x).g * 63) << 5) | \
    ((uint32_t)((x).r * 31) << 0))
#define ALLEGRO_CONVERT_ABGR_F32_TO_BGR_555(x) \
   (((uint32_t)((x).b * 31) << 10) | \
    ((uint32_t)((x).g * 31) << 5) | \
    ((uint32_t)((x).r * 31) << 0))
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGBX_8888(x) \
   (((uint32_t)((x).b * 255) << 8) | \
    ((uint32_t)((x).g * 255) << 16) | \
    ((uint32_t)((x).r * 255) << 24))
#define ALLEGRO_CONVERT_ABGR_F32_TO_XRGB_8888(x) \
   (((uint32_t)((x).b * 255) << 0) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 16))
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_F32_TO_ABGR_8888_LE(x) \
   (((uint32_t)((x).a * 255) << 0) | \
    ((uint32_t)((x).b * 255) << 8) | \
    ((uint32_t)((x).g * 255) << 16) | \
    ((uint32_t)((x).r * 255) << 24))
#else
#define ALLEGRO_CONVERT_ABGR_F32_TO_ABGR_8888_LE(x) \
   (((uint32_t)((x).a * 255) << 24) | \
    ((uint32_t)((x).b * 255) << 16) | \
    ((uint32_t)((x).g * 255) << 8) | \
    ((uint32_t)((x).r * 255) << 0))
#endif
#define ALLEGRO_CONVERT_ABGR_F32_TO_RGBA_4444(x) \
   (((uint32_t)((x).a * 15) << 0) | \
    ((uint32_t)((x).b * 15) << 4) | \
    ((uint32_t)((x).g * 15) << 8) | \
    ((uint32_t)((x).r * 15) << 12))
#define ALLEGRO_CONVERT_ABGR_F32_TO_SINGLE_CHANNEL_8(x) \
   (uint32_t)((x).r * 255)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_8888(x) \
   ((((x) & 0x000000ff) << 24)        /* A */ | \
    (((x) & 0xffffff00) >>  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_8888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    (((x) & 0x000000ff) << 16)        /* R */ | \
    ((x) & 0xff00ff00)              /* AG */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_8888(x) \
   (((x) & 0xffffffff)              /* ABGR */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_8888(x) \
   ((((x) & 0xff000000) >> 24)        /* A */ | \
    (((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_4444(x) \
   ((((x) & 0x000000f0) <<  8)        /* A */ | \
    (((x) & 0x0000f000) >> 12)        /* B */ | \
    (((x) & 0x00f00000) >> 16)        /* G */ | \
    (((x) & 0xf0000000) >> 20)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_4444(x) \
   ((((x) & 0xf0000000) >> 16)        /* A */ | \
    (((x) & 0x00f00000) >> 20)        /* B */ | \
    (((x) & 0x0000f000) >>  8)        /* G */ | \
    (((x) & 0x000000f0) <<  4)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_565(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_565(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_555(x) \
   ((((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGB_555(x) \
   ((((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_5551(x) \
   ((((x) & 0x00000080) >>  7)        /* A */ | \
    (((x) & 0x0000f800) >> 10)        /* B */ | \
    (((x) & 0x00f80000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 16)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_5551(x) \
   ((((x) & 0x80000000) >> 31)        /* A */ | \
    (((x) & 0x00f80000) >> 18)        /* B */ | \
    (((x) & 0x0000f800) >>  5)        /* G */ | \
    (((x) & 0x000000f8) <<  8)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_1555(x) \
   ((((x) & 0x00000080) <<  8)        /* A */ | \
    (((x) & 0x0000f800) >> 11)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 17)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ARGB_1555(x) \
   ((((x) & 0x80000000) >> 16)        /* A */ | \
    (((x) & 0x00f80000) >> 19)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) <<  7)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ABGR_8888(x) \
   ((((x) & 0x000000ff) << 24)        /* A */ | \
    (((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ABGR_8888(x) \
   (((x) & 0xffffffff)              /* ABGR */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_XBGR_8888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_XBGR_8888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_888(x) \
   ((((x) & 0x0000ff00) <<  8)        /* B */ | \
    (((x) & 0x00ff0000) >>  8)        /* G */ | \
    (((x) & 0xff000000) >> 24)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_888(x) \
   (((x) & 0x00ffffff)              /* BGR */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_565(x) \
   (((x) & 0x0000f800)              /* B */ | \
    (((x) & 0x00fc0000) >> 13)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_565(x) \
   ((((x) & 0x00f80000) >>  8)        /* B */ | \
    (((x) & 0x0000fc00) >>  5)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_555(x) \
   ((((x) & 0x0000f800) >>  1)        /* B */ | \
    (((x) & 0x00f80000) >> 14)        /* G */ | \
    (((x) & 0xf8000000) >> 27)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_BGR_555(x) \
   ((((x) & 0x00f80000) >>  9)        /* B */ | \
    (((x) & 0x0000f800) >>  6)        /* G */ | \
    (((x) & 0x000000f8) >>  3)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBX_8888(x) \
   (((x) & 0xffffff00)              /* BGR */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBX_8888(x) \
   ((((x) & 0x00ff0000) >>  8)        /* B */ | \
    (((x) & 0x0000ff00) <<  8)        /* G */ | \
    (((x) & 0x000000ff) << 24)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_XRGB_8888(x) \
   ((((x) & 0xffffff00) >>  8)        /* BGR */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_XRGB_8888(x) \
   ((((x) & 0x00ff0000) >> 16)        /* B */ | \
    ((x) & 0x0000ff00)              /* G */ | \
    (((x) & 0x000000ff) << 16)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ABGR_F32(x) \
   al_map_rgba(((x) >> 24) & 255,\
   ((x) >> 16) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 0) & 255)
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_ABGR_F32(x) \
   al_map_rgba(((x) >> 0) & 255,\
   ((x) >> 8) & 255,\
   ((x) >> 16) & 255,\
   ((x) >> 24) & 255)
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_4444(x) \
   ((((x) & 0x000000f0) >>  4)        /* A */ | \
    (((x) & 0x0000f000) >>  8)        /* B */ | \
    (((x) & 0x00f00000) >> 12)        /* G */ | \
    (((x) & 0xf0000000) >> 16)        /* R */)   
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_RGBA_4444(x) \
   ((((x) & 0xf0000000) >> 28)        /* A */ | \
    (((x) & 0x00f00000) >> 16)        /* B */ | \
    (((x) & 0x0000f000) >>  4)        /* G */ | \
    (((x) & 0x000000f0) <<  8)        /* R */)   
#endif
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 24) & 0xff)
#else
#define ALLEGRO_CONVERT_ABGR_8888_LE_TO_SINGLE_CHANNEL_8(x) \
   (((x) >> 0) & 0xff)
#endif
#define ALLEGRO_CONVERT_RGBA_4444_TO_ARGB_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGBA_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0]       ) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_ARGB_4444(x) \
   ((((x) & 0x000f) << 12)        /* A */ | \
    (((x) & 0xfff0) >>  4)        /* BGR */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGB_888(x) \
   ((_al_rgb_scale_4[((x) & 0x00f0) >>  4]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGB_565(x) \
   ((((x) & 0x00f0) >>  3)        /* B */ | \
    (((x) & 0x0f00) >>  1)        /* G */ | \
    ((x) & 0xf000)              /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGB_555(x) \
   ((((x) & 0x00f0) >>  3)        /* B */ | \
    (((x) & 0x0f00) >>  2)        /* G */ | \
    (((x) & 0xf000) >>  1)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGBA_5551(x) \
   ((((x) & 0x0008) >>  3)        /* A */ | \
    (((x) & 0x00f0) >>  2)        /* B */ | \
    (((x) & 0x0f00) >>  1)        /* G */ | \
    ((x) & 0xf000)              /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_ARGB_1555(x) \
   ((((x) & 0x0008) << 12)        /* A */ | \
    (((x) & 0x00f0) >>  3)        /* B */ | \
    (((x) & 0x0f00) >>  2)        /* G */ | \
    (((x) & 0xf000) >>  1)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_ABGR_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_XBGR_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_BGR_888(x) \
   ((_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_BGR_565(x) \
   ((((x) & 0x00f0) <<  8)        /* B */ | \
    (((x) & 0x0f00) >>  1)        /* G */ | \
    (((x) & 0xf000) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_BGR_555(x) \
   ((((x) & 0x00f0) <<  7)        /* B */ | \
    (((x) & 0x0f00) >>  2)        /* G */ | \
    (((x) & 0xf000) >> 11)        /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_RGBX_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_XRGB_8888(x) \
   ((_al_rgb_scale_4[((x) & 0x00f0) >>  4]       ) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 16) /* R */)   
#define ALLEGRO_CONVERT_RGBA_4444_TO_ABGR_F32(x) \
   al_map_rgba(_al_rgb_scale_4[((x) >> 12) & 15],\
   _al_rgb_scale_4[((x) >> 8) & 15],\
   _al_rgb_scale_4[((x) >> 4) & 15],\
   _al_rgb_scale_4[((x) >> 0) & 15])
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_RGBA_4444_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0]       ) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] <<  8) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] << 16) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12] << 24) /* R */)   
#else
#define ALLEGRO_CONVERT_RGBA_4444_TO_ABGR_8888_LE(x) \
   ((_al_rgb_scale_4[((x) & 0x000f) >>  0] << 24) /* A */ | \
    (_al_rgb_scale_4[((x) & 0x00f0) >>  4] << 16) /* B */ | \
    (_al_rgb_scale_4[((x) & 0x0f00) >>  8] <<  8) /* G */ | \
    (_al_rgb_scale_4[((x) & 0xf000) >> 12]       ) /* R */)   
#endif
#define ALLEGRO_CONVERT_RGBA_4444_TO_SINGLE_CHANNEL_8(x) \
   (_al_rgb_scale_4[(((x) >> 12) & 0xf)])
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ARGB_8888(x) \
   (0xff000000 | \
   (((x) << 16) & 0xff0000))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGBA_8888(x) \
   (0xff | \
   (((x) << 24) & 0xff000000))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ARGB_4444(x) \
   (0xf000 | \
   (((x) << 4) & 0xf00))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGB_888(x) \
   ((((x) << 16) & 0xff0000))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGB_565(x) \
   ((((x) << 8) & 0xf800))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGB_555(x) \
   ((((x) << 7) & 0x7c00))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGBA_5551(x) \
   (0x1 | \
   (((x) << 8) & 0xf800))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ARGB_1555(x) \
   (0x8000 | \
   (((x) << 7) & 0x7c00))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ABGR_8888(x) \
   (0xff000000 | \
   ((x) & 0xff))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_XBGR_8888(x) \
   (((x) & 0xff))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_BGR_888(x) \
   (((x) & 0xff))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_BGR_565(x) \
   ((((x) >> 3) & 0x1f))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_BGR_555(x) \
   ((((x) >> 3) & 0x1f))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGBX_8888(x) \
   ((((x) << 24) & 0xff000000))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_XRGB_8888(x) \
   ((((x) << 16) & 0xff0000))
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ABGR_F32(x) \
   al_map_rgb(x, 0, 0)
#ifdef ALLEGRO_BIG_ENDIAN
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ABGR_8888_LE(x) \
   (0xff | \
   (((x) << 24) & 0xff000000))
#else
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_ABGR_8888_LE(x) \
   (0xff000000 | \
   ((x) & 0xff))
#endif
#define ALLEGRO_CONVERT_SINGLE_CHANNEL_8_TO_RGBA_4444(x) \
   (0xf | \
   (((x) << 8) & 0xf000))
#endif
// Warning: This file was created by make_converters.py - do not edit.
