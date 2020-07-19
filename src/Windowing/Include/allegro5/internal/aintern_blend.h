#ifndef __al_included_allegro5_aintern_blend_h
#define __al_included_allegro5_aintern_blend_h

#include <allegro5/internal/aintern.h>

#ifdef __cplusplus
   extern "C" {
#endif


#ifdef __GNUC__
   #define _AL_ALWAYS_INLINE  inline __attribute__((always_inline))
#else
   #define _AL_ALWAYS_INLINE  INLINE
#endif


#define _AL_DEST_IS_ZERO \
   (dst_mode == ALLEGRO_ZERO &&  dst_alpha == ALLEGRO_ZERO && \
   op != ALLEGRO_DEST_MINUS_SRC && op_alpha != ALLEGRO_DEST_MINUS_SRC)

#define _AL_SRC_NOT_MODIFIED \
   (src_mode == ALLEGRO_ONE && src_alpha == ALLEGRO_ONE)

#define _AL_SRC_NOT_MODIFIED_TINT_WHITE \
   (_AL_SRC_NOT_MODIFIED && \
   tint.r == 1.0f && tint.g == 1.0f && tint.b == 1.0f && tint.a == 1.0f)


#ifndef _AL_NO_BLEND_INLINE_FUNC

/* Only cares about alpha blending modes. */
static _AL_ALWAYS_INLINE float
get_alpha_factor(enum ALLEGRO_BLEND_MODE operation, float src_alpha, float dst_alpha, ALLEGRO_COLOR* const_alpha)
{
   switch (operation) {
      case ALLEGRO_ZERO: return 0;
      case ALLEGRO_ONE: return 1;
      case ALLEGRO_ALPHA: return src_alpha;
      case ALLEGRO_INVERSE_ALPHA: return 1 - src_alpha;
      case ALLEGRO_SRC_COLOR: return src_alpha;
      case ALLEGRO_DEST_COLOR: return dst_alpha;
      case ALLEGRO_INVERSE_SRC_COLOR: return 1 - src_alpha;
      case ALLEGRO_INVERSE_DEST_COLOR: return 1 - dst_alpha;
      case ALLEGRO_CONST_COLOR: return const_alpha->a;
      case ALLEGRO_INVERSE_CONST_COLOR: return 1 - const_alpha->a;
      default:
         ASSERT(false);
         return 0; /* silence warning in release build */
   }
}

/* Puts the blending factor in an ALLEGRO_COLOR object. */
static _AL_ALWAYS_INLINE void get_factor(enum ALLEGRO_BLEND_MODE operation,
   const ALLEGRO_COLOR *source, const ALLEGRO_COLOR *dest, ALLEGRO_COLOR *constcol,
   ALLEGRO_COLOR *factor)
{
   switch (operation) {
      case ALLEGRO_ZERO:
         factor->r = factor->g = factor->b = factor->a = 0;
         break;
      case ALLEGRO_ONE:
         factor->r = factor->g = factor->b = factor->a = 1;
         break;
      case ALLEGRO_ALPHA:
         factor->r = factor->g = factor->b = factor->a = source->a;
         break;
      case ALLEGRO_INVERSE_ALPHA:
         factor->r = factor->g = factor->b = factor->a = 1 - source->a;
         break;
      case ALLEGRO_SRC_COLOR:
         *factor = *source;
         break;
      case ALLEGRO_DEST_COLOR:
         *factor = *dest;
         break;
      case ALLEGRO_INVERSE_SRC_COLOR:
         factor->r = 1 - source->r;
         factor->g = 1 - source->g;
         factor->b = 1 - source->b;
         factor->a = 1 - source->a;
         break;
      case ALLEGRO_INVERSE_DEST_COLOR:
         factor->r = 1 - dest->r;
         factor->g = 1 - dest->g;
         factor->b = 1 - dest->b;
         factor->a = 1 - dest->a;
         break;
      case ALLEGRO_CONST_COLOR:
         *factor = *constcol;
         break;
      case ALLEGRO_INVERSE_CONST_COLOR:
         factor->r = 1 - constcol->r;
         factor->g = 1 - constcol->g;
         factor->b = 1 - constcol->b;
         factor->a = 1 - constcol->a;
         break;
      default:
         ASSERT(false);
         factor->r = factor->g = factor->b = factor->a = 0;
         break;
   }
}

/* Only call this if the blend modes are one of:
 * ALLEGRO_ONE, ALLEGRO_ZERO, ALLEGRO_ALPHA, ALLEGRO_INVERSE_ALPHA
 */
static _AL_ALWAYS_INLINE
void _al_blend_alpha_inline(
   const ALLEGRO_COLOR *scol, const ALLEGRO_COLOR *dcol,
   int op, int src_, int dst_, int aop, int asrc_, int adst_,
   ALLEGRO_COLOR *constcol, ALLEGRO_COLOR *result)
{
   float asrc, adst;
   float src, dst;

   result->r = scol->r;
   result->g = scol->g;
   result->b = scol->b;
   result->a = scol->a;

   asrc = get_alpha_factor(asrc_, scol->a, dcol->a, constcol);
   adst = get_alpha_factor(adst_, scol->a, dcol->a, constcol);
   src = get_alpha_factor(src_, scol->a, dcol->a, constcol);
   dst = get_alpha_factor(dst_, scol->a, dcol->a, constcol);

   #define BLEND(c, src, dst) \
      result->c = OP(result->c * src, dcol->c * dst);
   switch (op) {
      case ALLEGRO_ADD:
         #define OP(x, y) _ALLEGRO_MIN(1, x + y)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
      case ALLEGRO_SRC_MINUS_DEST:
         #define OP(x, y) _ALLEGRO_MAX(0, x - y)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
      case ALLEGRO_DEST_MINUS_SRC:
         #define OP(x, y) _ALLEGRO_MAX(0, y - x)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
   }

   switch (aop) {
      case ALLEGRO_ADD:
         #define OP(x, y) _ALLEGRO_MIN(1, x + y)
         BLEND(a, asrc, adst)
         #undef OP
         break;
      case ALLEGRO_SRC_MINUS_DEST:
         #define OP(x, y) _ALLEGRO_MAX(0, x - y)
         BLEND(a, asrc, adst)
         #undef OP
         break;
      case ALLEGRO_DEST_MINUS_SRC:
         #define OP(x, y) _ALLEGRO_MAX(0, y - x)
         BLEND(a, asrc, adst)
         #undef OP
         break;
   }
   #undef BLEND
}

/* call this for general blending. its a little slower than just using alpha */
static _AL_ALWAYS_INLINE
void _al_blend_inline(
   const ALLEGRO_COLOR *scol, const ALLEGRO_COLOR *dcol,
   int op, int src_, int dst_, int aop, int asrc_, int adst_,
   ALLEGRO_COLOR *constcol, ALLEGRO_COLOR *result)
{
   float asrc, adst;
   ALLEGRO_COLOR src, dst;

   result->r = scol->r;
   result->g = scol->g;
   result->b = scol->b;
   result->a = scol->a;
   
   asrc = get_alpha_factor(asrc_, scol->a, dcol->a, constcol);
   adst = get_alpha_factor(adst_, scol->a, dcol->a, constcol);
   get_factor(src_, scol, dcol, constcol, &src);
   get_factor(dst_, scol, dcol, constcol, &dst);

   #define BLEND(c, src, dst) \
      result->c = OP(result->c * src.c, dcol->c * dst.c);
   switch (op) {
      case ALLEGRO_ADD:
         #define OP(x, y) _ALLEGRO_MIN(1, x + y)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
      case ALLEGRO_SRC_MINUS_DEST:
         #define OP(x, y) _ALLEGRO_MAX(0, x - y)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
      case ALLEGRO_DEST_MINUS_SRC:
         #define OP(x, y) _ALLEGRO_MAX(0, y - x)
         BLEND(r, src, dst)
         BLEND(g, src, dst)
         BLEND(b, src, dst)
         #undef OP
         break;
   }
   #undef BLEND

   #define BLEND(c, src, dst) \
      result->c = OP(result->c * src, dcol->c * dst);
   switch (aop) {
      case ALLEGRO_ADD:
         #define OP(x, y) _ALLEGRO_MIN(1, x + y)
         BLEND(a, asrc, adst)
         #undef OP
         break;
      case ALLEGRO_SRC_MINUS_DEST:
         #define OP(x, y) _ALLEGRO_MAX(0, x - y)
         BLEND(a, asrc, adst)
         #undef OP
         break;
      case ALLEGRO_DEST_MINUS_SRC:
         #define OP(x, y) _ALLEGRO_MAX(0, y - x)
         BLEND(a, asrc, adst)
         #undef OP
         break;
   }
   #undef BLEND
}

#endif


void _al_blend_memory(ALLEGRO_COLOR *src_color, ALLEGRO_BITMAP *dest,
   int dx, int dy, ALLEGRO_COLOR *result);


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
