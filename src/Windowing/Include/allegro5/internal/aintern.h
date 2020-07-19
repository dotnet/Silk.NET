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
 *      Some definitions for internal use by the library code.
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */


#ifndef __al_included_allegro5_aintern_h
#define __al_included_allegro5_aintern_h

#ifndef __al_included_allegro5_allegro_h
   #error must include allegro5/allegro.h first
#endif

#ifdef __cplusplus
   extern "C" {
#endif
    
#define _ALLEGRO_MIN(x,y)     (((x) < (y)) ? (x) : (y))
#define _ALLEGRO_MAX(x,y)     (((x) > (y)) ? (x) : (y))
#define _ALLEGRO_CLAMP(x,y,z) _ALLEGRO_MAX((x), _ALLEGRO_MIN((y), (z)))

int _al_get_least_multiple(int val, int mul);

/* message stuff */
#define ALLEGRO_MESSAGE_SIZE  4096

/* various libc stuff */
AL_FUNC(void *, _al_sane_realloc, (void *ptr, size_t size));
AL_FUNC(char *, _al_sane_strncpy, (char *dest, const char *src, size_t n));


#define _AL_RAND_MAX  0xFFFF
AL_FUNC(void, _al_srand, (int seed));
AL_FUNC(int, _al_rand, (void));

AL_FUNC(int, _al_stricmp, (const char *s1, const char *s2));

#define _AL_INCHES_PER_MM 0.039370

#ifdef __cplusplus
   }
#endif

#endif
