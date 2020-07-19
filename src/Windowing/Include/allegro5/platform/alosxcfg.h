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
 *      Configuration defines for use with MacOS X.
 *
 *      By Angelo Mottola.
 *
 *      See readme.txt for copyright information.
 */


#ifndef __al_included_allegro5_alosxcfg_h
#define __al_included_allegro5_alosxcfg_h

/* Include configuration information.  */
#include <allegro5/platform/alplatf.h>

#define ALLEGRO_INTERNAL_THREAD_HEADER "allegro5/platform/aintuthr.h"

/* Describe this platform */
#define ALLEGRO_PLATFORM_STR  "MacOS X"


/* Arrange for other headers to be included later on */
#define ALLEGRO_EXTRA_HEADER     "allegro5/platform/alosx.h"
#define ALLEGRO_INTERNAL_HEADER  "allegro5/platform/aintosx.h"


#endif
