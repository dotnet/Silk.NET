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
 *      Fixed point type.
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */


#ifndef __al_included_allegro5_fixed_h
#define __al_included_allegro5_fixed_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Type: al_fixed
 */
typedef int32_t al_fixed;

AL_VAR(const al_fixed, al_fixtorad_r);
AL_VAR(const al_fixed, al_radtofix_r);

#ifdef __cplusplus
   }
#endif

#endif


