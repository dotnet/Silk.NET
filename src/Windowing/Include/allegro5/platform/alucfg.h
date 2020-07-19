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
 *      Configuration defines for use on Unix platforms.
 *
 *      By Michael Bukin.
 *
 *      See readme.txt for copyright information.
 */


#include <fcntl.h>
#include <unistd.h>

/* Describe this platform.  */
#define ALLEGRO_PLATFORM_STR  "Unix"

#define ALLEGRO_EXTRA_HEADER "allegro5/platform/alunix.h"

#ifdef _this_is_a_hack_to_fool_scons
#include "alunix.h"
#endif

#define ALLEGRO_INTERNAL_HEADER "allegro5/platform/aintunix.h"
#define ALLEGRO_INTERNAL_THREAD_HEADER "allegro5/platform/aintuthr.h"

/* Include configuration information.  */
#include <allegro5/platform/alplatf.h>

/* Enable OpenGL if GLX is available. */
#ifdef ALLEGRO_GLX
#define ALLEGRO_CFG_OPENGL
#endif
