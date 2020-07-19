/*         ______   ___    ___
 *        /\  _  \ /\_ \  /\_ \
 *        \ \ \L\ \\//\ \ \//\ \      __     __   _ __   ___
 *         \ \  __ \ \ \ \  \ \ \   /'__`\ /'_ `\/\`'__\/ __`\
 *          \ \ \/\ \ \_\ \_ \_\ \_/\  __//\ \L\ \ \ \//\ \L\ \
 *           \ \_\ \_\/\____\/\____\ \____\ \____ \ \_\\ \____/
 *            \/_/\/_/\/____/\/____/\/____/\/___L\ \/_/ \/___/
 *                                           /\____/
 *                                           \_/__/
 *
 *      Fixed point math inline functions (generic C).
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */


#ifndef __al_included_allegro5_inline_fmaths_inl
#define __al_included_allegro5_inline_fmaths_inl

#include <allegro5/error.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* al_ftofix and al_fixtof are used in generic C versions of al_fixmul and al_fixdiv */
AL_INLINE(al_fixed, al_ftofix, (double x),
{
   if (x > 32767.0) {
      al_set_errno(ERANGE);
      return 0x7FFFFFFF;
   }

   if (x < -32767.0) {
      al_set_errno(ERANGE);
      return -0x7FFFFFFF;
   }

   return (al_fixed)(x * 65536.0 + (x < 0 ? -0.5 : 0.5));
})


AL_INLINE(double, al_fixtof, (al_fixed x),
{
   return (double)x / 65536.0;
})


AL_INLINE(al_fixed, al_fixadd, (al_fixed x, al_fixed y),
{
   al_fixed result = x + y;

   if (result >= 0) {
      if ((x < 0) && (y < 0)) {
         al_set_errno(ERANGE);
         return -0x7FFFFFFF;
      }
      else
         return result;
   }
   else {
      if ((x > 0) && (y > 0)) {
         al_set_errno(ERANGE);
         return 0x7FFFFFFF;
      }
      else
         return result;
   }
})


AL_INLINE(al_fixed, al_fixsub, (al_fixed x, al_fixed y),
{
   al_fixed result = x - y;

   if (result >= 0) {
      if ((x < 0) && (y > 0)) {
         al_set_errno(ERANGE);
         return -0x7FFFFFFF;
      }
      else
         return result;
   }
   else {
      if ((x > 0) && (y < 0)) {
         al_set_errno(ERANGE);
         return 0x7FFFFFFF;
      }
      else
         return result;
   }
})


/* In benchmarks conducted circa May 2005 we found that, in the main:
 * - IA32 machines performed faster with one implementation;
 * - AMD64 and G4 machines performed faster with another implementation.
 *
 * Benchmarks were mainly done with differing versions of gcc.
 * Results varied with other compilers, optimisation levels, etc.
 * so this is not optimal, though a tenable compromise.
 *
 * Note that the following implementation are NOT what were benchmarked.
 * We had forgotten to put in overflow detection in those versions.
 * If you don't need overflow detection then previous versions in the
 * CVS tree might be worth looking at.
 *
 * PS. Don't move the #ifs inside the AL_INLINE; BCC doesn't like it.
 */
#if defined ALLEGRO_I386
   AL_INLINE(al_fixed, al_fixmul, (al_fixed x, al_fixed y),
   {
      return al_ftofix(al_fixtof(x) * al_fixtof(y));
   })
#else
   AL_INLINE(al_fixed, al_fixmul, (al_fixed x, al_fixed y),
   {
      int64_t lx = x;
      int64_t ly = y;
      int64_t lres = (lx*ly);

      if (lres > 0x7FFFFFFF0000LL) {
         al_set_errno(ERANGE);
         return 0x7FFFFFFF;
      }
      else if (lres < -0x7FFFFFFF0000LL) {
         al_set_errno(ERANGE);
         return 0x80000000;
      }
      else {
         return (al_fixed) (lres >> 16);
      }
   })
#endif	    /* al_fixmul() C implementations */


#if defined ALLEGRO_CFG_NO_FPU
AL_INLINE(al_fixed, al_fixdiv, (al_fixed x, al_fixed y),
{
   int64_t lres = x;
   if (y == 0) {
      al_set_errno(ERANGE);
      return (x < 0) ? -0x7FFFFFFF : 0x7FFFFFFF;
   }
   lres <<= 16;
   lres /= y;
   if (lres > 0x7FFFFFFF) {
      al_set_errno(ERANGE);
      return 0x7FFFFFFF;
   }
   else if (lres < -0x7FFFFFFF) {
      al_set_errno(ERANGE);
      return 0x80000000;
   }
   else {
      return (al_fixed)(lres);
   }
})
#else
AL_INLINE(al_fixed, al_fixdiv, (al_fixed x, al_fixed y),
{
   if (y == 0) {
      al_set_errno(ERANGE);
      return (x < 0) ? -0x7FFFFFFF : 0x7FFFFFFF;
   }
   else
      return al_ftofix(al_fixtof(x) / al_fixtof(y));
})
#endif


AL_INLINE(int, al_fixfloor, (al_fixed x),
{
   /* (x >> 16) is not portable */
   if (x >= 0)
      return (x >> 16);
   else
      return ~((~x) >> 16);
})


AL_INLINE(int, al_fixceil, (al_fixed x),
{
   if (x > 0x7FFF0000) {
      al_set_errno(ERANGE);
      return 0x7FFF;
   }

   return al_fixfloor(x + 0xFFFF);
})


AL_INLINE(al_fixed, al_itofix, (int x),
{
   return x << 16;
})


AL_INLINE(int, al_fixtoi, (al_fixed x),
{
   return al_fixfloor(x) + ((x & 0x8000) >> 15);
})


AL_INLINE(al_fixed, al_fixcos, (al_fixed x),
{
   return _al_fix_cos_tbl[((x + 0x4000) >> 15) & 0x1FF];
})


AL_INLINE(al_fixed, al_fixsin, (al_fixed x),
{
   return _al_fix_cos_tbl[((x - 0x400000 + 0x4000) >> 15) & 0x1FF];
})


AL_INLINE(al_fixed, al_fixtan, (al_fixed x),
{
   return _al_fix_tan_tbl[((x + 0x4000) >> 15) & 0xFF];
})


AL_INLINE(al_fixed, al_fixacos, (al_fixed x),
{
   if ((x < -65536) || (x > 65536)) {
      al_set_errno(EDOM);
      return 0;
   }

   return _al_fix_acos_tbl[(x+65536+127)>>8];
})


AL_INLINE(al_fixed, al_fixasin, (al_fixed x),
{
   if ((x < -65536) || (x > 65536)) {
      al_set_errno(EDOM);
      return 0;
   }

   return 0x00400000 - _al_fix_acos_tbl[(x+65536+127)>>8];
})

#ifdef __cplusplus
   }
#endif

#endif


