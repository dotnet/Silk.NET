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
 *      Base header, defines basic stuff needed by pretty much
 *      everything else.
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_base_h
#define __al_included_allegro5_base_h

#ifndef ALLEGRO_NO_STD_HEADERS
   #include <errno.h>
   #ifdef _MSC_VER
      /* enable posix for limits.h and only limits.h
         enabling it for all msvc headers will potentially
         disable a lot of commonly used msvcrt functions */
      #define _POSIX_
      #include <limits.h>
      #undef _POSIX_
   #else
      #include <limits.h>
   #endif
   #include <stdarg.h>
   #include <stddef.h>
   #include <stdlib.h>
   #include <time.h>
   #include <string.h>
   #include <sys/types.h>
#endif

#if (defined DEBUGMODE) && (defined FORTIFY)
   #include <fortify/fortify.h>
#endif

#if (defined DEBUGMODE) && (defined DMALLOC)
   #include <dmalloc.h>
#endif

#include <allegro5/internal/alconfig.h>

#ifdef __cplusplus
   extern "C" {
#endif

#define ALLEGRO_VERSION          5
#define ALLEGRO_SUB_VERSION      2
#define ALLEGRO_WIP_VERSION      6

#ifdef ALLEGRO_UNSTABLE
   #define ALLEGRO_UNSTABLE_BIT  1 << 31
#else
   #define ALLEGRO_UNSTABLE_BIT  0
#endif

/* Not sure we need it, but since ALLEGRO_VERSION_STR contains it:
 * 0 = GIT
 * 1 = first release
 * 2... = hotfixes?
 *
 * Note x.y.z (= x.y.z.0) has release number 1, and x.y.z.1 has release
 * number 2, just to confuse you.
 */
#define ALLEGRO_RELEASE_NUMBER   1

#define ALLEGRO_VERSION_STR      "5.2.6"
#define ALLEGRO_DATE_STR         "2020"
#define ALLEGRO_DATE             20200207    /* yyyymmdd */
#define ALLEGRO_VERSION_INT \
    ((ALLEGRO_VERSION << 24) | (ALLEGRO_SUB_VERSION << 16) | \
    (ALLEGRO_WIP_VERSION << 8) | ALLEGRO_RELEASE_NUMBER | \
    ALLEGRO_UNSTABLE_BIT)

AL_FUNC(uint32_t, al_get_allegro_version, (void));
AL_FUNC(int, al_run_main, (int argc, char **argv, int (*)(int, char **)));

/*******************************************/
/************ Some global stuff ************/
/*******************************************/

/* Type: ALLEGRO_PI
 */
#define ALLEGRO_PI        3.14159265358979323846

#define AL_ID(a,b,c,d)     (((a)<<24) | ((b)<<16) | ((c)<<8) | (d))

       

#ifdef __cplusplus
   }
#endif

#endif
