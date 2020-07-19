#ifndef __al_included_allegro5_aintern_pixels_h
#define __al_included_allegro5_aintern_pixels_h

#include <allegro5/internal/aintern_float.h>

#ifdef __cplusplus
   extern "C" {
#endif


#define _AL_MAP_RGBA(_color, _r, _g, _b, _a)                                  \
   do {                                                                       \
      (_color).r = _al_u8_to_float[_r];                                       \
      (_color).g = _al_u8_to_float[_g];                                       \
      (_color).b = _al_u8_to_float[_b];                                       \
      (_color).a = _al_u8_to_float[_a];                                       \
   } while (0)


#define _AL_INLINE_GET_PIXEL(format, data, color, advance)                    \
   do {                                                                       \
      switch (format) {                                                       \
         case ALLEGRO_PIXEL_FORMAT_ARGB_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x000000FF) >>  0,                                \
               (_gp_pixel & 0xFF000000) >> 24);                               \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0xFF000000) >> 24,                                \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x000000FF) >>  0);                               \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ARGB_4444: {                               \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_4[(_gp_pixel & 0x0F00) >> 8],                       \
               _al_rgb_scale_4[(_gp_pixel & 0x00F0) >> 4],                       \
               _al_rgb_scale_4[(_gp_pixel & 0x000F)],                            \
               _al_rgb_scale_4[(_gp_pixel & 0xF000) >>  12]);                    \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_888: {                                 \
            uint32_t _gp_pixel = _AL_READ3BYTES(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0xFF0000) >> 16,                                  \
               (_gp_pixel & 0x00FF00) >>  8,                                  \
               (_gp_pixel & 0x0000FF) >>  0,                                  \
               255);                                                          \
            if (advance)                                                      \
               data += 3;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_565: {                                 \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0xF800) >> 11],                      \
               _al_rgb_scale_6[(_gp_pixel & 0x07E0) >> 5],                       \
               _al_rgb_scale_5[(_gp_pixel & 0x001F)],                            \
               255);                                                          \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_555: {                                 \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0x7C00) >> 10],                      \
               _al_rgb_scale_5[(_gp_pixel & 0x03E0) >> 5],                       \
               _al_rgb_scale_5[(_gp_pixel & 0x001F)],                            \
               255);                                                          \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_5551: {                               \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0xF800) >> 11],                      \
               _al_rgb_scale_5[(_gp_pixel & 0x07C0) >> 6],                       \
               _al_rgb_scale_5[(_gp_pixel & 0x003E) >> 1],                       \
               _al_rgb_scale_1[_gp_pixel & 1]);                                                          \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ARGB_1555: {                               \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0x7C00) >> 10],                      \
               _al_rgb_scale_5[(_gp_pixel & 0x03E0) >> 5],                       \
               _al_rgb_scale_5[(_gp_pixel & 0x001F)],                            \
               _al_rgb_scale_1[(_gp_pixel & 0x8000) >> 15]);                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0x000000FF) >>  0,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               (_gp_pixel & 0xFF000000) >> 24);                               \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_XBGR_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0x000000FF) >>  0,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               255);                                                          \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_888: {                                 \
            uint32_t _gp_pixel = _AL_READ3BYTES(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0x000000FF) >>  0,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               255);                                                          \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_565: {                                 \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0x001F)],                            \
               _al_rgb_scale_6[(_gp_pixel & 0x07E0) >> 5],                       \
               _al_rgb_scale_5[(_gp_pixel & 0xF800) >> 11],                      \
               255);                                                          \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_555: {                                 \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_5[(_gp_pixel & 0x001F)],                            \
               _al_rgb_scale_5[(_gp_pixel & 0x03E0) >> 5],                       \
               _al_rgb_scale_5[(_gp_pixel & 0x7C00) >> 10],                      \
               255);                                                          \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBX_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0xFF000000) >> 24,                                \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               255);                                                          \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_XRGB_8888: {                               \
            uint32_t _gp_pixel = *(uint32_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               (_gp_pixel & 0x00FF0000) >> 16,                                \
               (_gp_pixel & 0x0000FF00) >>  8,                                \
               (_gp_pixel & 0x000000FF),                                      \
               255);                                                          \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_F32: {                                \
            float *f = (float *)data;                                         \
            color.r = f[0];                                                   \
            color.g = f[1];                                                   \
            color.b = f[2];                                                   \
            color.a = f[3];                                                   \
            if (advance)                                                      \
               data += 4 * sizeof(float);                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_8888_LE: {                            \
            uint8_t *p = (uint8_t *)data;                                     \
            _AL_MAP_RGBA(color, *p, *(p + 1), *(p + 2), *(p + 3));            \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_4444: {                               \
            uint16_t _gp_pixel = *(uint16_t *)(data);                         \
            _AL_MAP_RGBA(color,                                               \
               _al_rgb_scale_4[(_gp_pixel & 0xF000) >> 12],                   \
               _al_rgb_scale_4[(_gp_pixel & 0x0F00) >> 8],                    \
               _al_rgb_scale_4[(_gp_pixel & 0x00F0) >> 4],                    \
               _al_rgb_scale_4[(_gp_pixel & 0x000F)]);                        \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_SINGLE_CHANNEL_8: {                        \
            uint8_t c = *(uint8_t *)(data);                                   \
            _AL_MAP_RGBA(color, c, c, c, 255);                                \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ANY:                                       \
         case ALLEGRO_PIXEL_FORMAT_ANY_NO_ALPHA:                              \
         case ALLEGRO_PIXEL_FORMAT_ANY_WITH_ALPHA:                            \
         case ALLEGRO_PIXEL_FORMAT_ANY_15_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_16_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_16_WITH_ALPHA:                         \
         case ALLEGRO_PIXEL_FORMAT_ANY_24_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_32_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_32_WITH_ALPHA:                         \
            ALLEGRO_ERROR("INLINE_GET got fake pixel format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT1:                                 \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT3:                                 \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT5:                                 \
            ALLEGRO_ERROR("INLINE_GET got compressed format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
                                                                              \
         case ALLEGRO_NUM_PIXEL_FORMATS:                                      \
         default:                                                             \
            ALLEGRO_ERROR("INLINE_GET got non pixel format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
      }                                                                       \
   } while (0)


#define _AL_INLINE_PUT_PIXEL(format, data, color, advance)                    \
   do {                                                                       \
      uint32_t _pp_pixel;                                                     \
      switch (format) {                                                       \
         case ALLEGRO_PIXEL_FORMAT_ARGB_8888:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.a * 255) << 24;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 255) << 16;          \
            _pp_pixel |= _al_fast_float_to_int(color.g * 255) <<  8;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 255);                \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_8888:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.r * 255) << 24;          \
            _pp_pixel |= _al_fast_float_to_int(color.g * 255) << 16;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 255) <<  8;          \
            _pp_pixel |= _al_fast_float_to_int(color.a * 255);                \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ARGB_4444:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.a * 15) << 12;           \
            _pp_pixel |= _al_fast_float_to_int(color.r * 15) <<  8;           \
            _pp_pixel |= _al_fast_float_to_int(color.g * 15) <<  4;           \
            _pp_pixel |= _al_fast_float_to_int(color.b * 15);                 \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_888:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.r * 255) << 16;          \
            _pp_pixel |= _al_fast_float_to_int(color.g * 255) << 8;           \
            _pp_pixel |= _al_fast_float_to_int(color.b * 255);                \
            _AL_WRITE3BYTES(data, _pp_pixel);                                  \
            if (advance)                                                      \
               data += 3;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_565:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.r * 0x1f) << 11;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x3f) << 5;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0x1f);               \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGB_555:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.r * 0x1f) << 10;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x1f) << 5;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0x1f);               \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_5551:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.r * 0x1f) << 11;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x1f) << 6;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0x1f) << 1;          \
            _pp_pixel |= _al_fast_float_to_int(color.a);                      \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ARGB_1555:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.a) << 15;                \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0x1f) << 10;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x1f) <<  5;         \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0x1f);               \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_8888:                                 \
            _pp_pixel  = _al_fast_float_to_int(color.a * 0xff) << 24;         \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0xff) << 16;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0xff) << 8;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0xff);               \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_XBGR_8888:                                 \
            _pp_pixel  = 0xff000000;                                          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0xff) << 16;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0xff) << 8;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0xff);               \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_888:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.b * 0xff) << 16;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0xff) << 8;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0xff);               \
            _AL_WRITE3BYTES(data, _pp_pixel);                                  \
            if (advance)                                                      \
               data += 3;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_565:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.b * 0x1f) << 11;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x3f) << 5;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0x1f);               \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_BGR_555:                                   \
            _pp_pixel  = _al_fast_float_to_int(color.b * 0x1f) << 10;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0x1f) << 5;          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0x1f);               \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBX_8888:                                 \
            _pp_pixel  = 0xff;                                                \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0xff) << 24;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0xff) << 16;         \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0xff) << 8;          \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_XRGB_8888:                                 \
            _pp_pixel  = 0xff000000;                                          \
            _pp_pixel |= _al_fast_float_to_int(color.r * 0xff) << 16;         \
            _pp_pixel |= _al_fast_float_to_int(color.g * 0xff) << 8;          \
            _pp_pixel |= _al_fast_float_to_int(color.b * 0xff);               \
            *(uint32_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_F32: {                                \
            float *f = (float *)data;                                         \
            f[0] = color.r;                                                   \
            f[1] = color.g;                                                   \
            f[2] = color.b;                                                   \
            f[3] = color.a;                                                   \
            if (advance)                                                      \
               data += 4 * sizeof(float);                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ABGR_8888_LE:                              \
            *((uint8_t *)data + 0) = _al_fast_float_to_int(color.r * 0xff);   \
            *((uint8_t *)data + 1) = _al_fast_float_to_int(color.g * 0xff);   \
            *((uint8_t *)data + 2) = _al_fast_float_to_int(color.b * 0xff);   \
            *((uint8_t *)data + 3) = _al_fast_float_to_int(color.a * 0xff);   \
            if (advance)                                                      \
               data += 4;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_RGBA_4444:                                 \
            _pp_pixel = _al_fast_float_to_int(color.a * 15);                  \
            _pp_pixel |= _al_fast_float_to_int(color.r * 15) << 12;           \
            _pp_pixel |= _al_fast_float_to_int(color.g * 15) <<  8;           \
            _pp_pixel |= _al_fast_float_to_int(color.b * 15) <<  4;           \
            *(uint16_t *)(data) = _pp_pixel;                                  \
            if (advance)                                                      \
               data += 2;                                                     \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_SINGLE_CHANNEL_8: {                        \
            uint8_t c = color.r;                                              \
            *(uint8_t *)data = c;                                             \
            if (advance)                                                      \
               data += 3;                                                     \
            break;                                                            \
         }                                                                    \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_ANY:                                       \
         case ALLEGRO_PIXEL_FORMAT_ANY_NO_ALPHA:                              \
         case ALLEGRO_PIXEL_FORMAT_ANY_WITH_ALPHA:                            \
         case ALLEGRO_PIXEL_FORMAT_ANY_15_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_16_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_16_WITH_ALPHA:                         \
         case ALLEGRO_PIXEL_FORMAT_ANY_24_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_32_NO_ALPHA:                           \
         case ALLEGRO_PIXEL_FORMAT_ANY_32_WITH_ALPHA:                         \
            ALLEGRO_ERROR("INLINE_PUT got fake _pp_pixel format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
                                                                              \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT1:                      \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT3:                      \
         case ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT5:                      \
            ALLEGRO_ERROR("INLINE_PUT got compressed format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
                                                                              \
         case ALLEGRO_NUM_PIXEL_FORMATS:                                      \
            ALLEGRO_ERROR("INLINE_PUT got non _pp_pixel format: %d\n", format); \
            abort();                                                          \
            break;                                                            \
      }                                                                       \
   } while (0)

AL_ARRAY(int, _al_rgb_scale_1);
AL_ARRAY(int, _al_rgb_scale_4);
AL_ARRAY(int, _al_rgb_scale_5);
AL_ARRAY(int, _al_rgb_scale_6);
AL_ARRAY(float, _al_u8_to_float);

AL_FUNC(void, _al_init_pixels, (void));
AL_FUNC(bool, _al_pixel_format_has_alpha, (int format));
AL_FUNC(bool, _al_pixel_format_is_real, (int format));
AL_FUNC(bool, _al_pixel_format_is_video_only, (int format));
AL_FUNC(bool, _al_pixel_format_is_compressed, (int format));
AL_FUNC(int, _al_get_real_pixel_format, (ALLEGRO_DISPLAY *display, int format));
AL_FUNC(char const*, _al_pixel_format_name, (ALLEGRO_PIXEL_FORMAT format));


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
