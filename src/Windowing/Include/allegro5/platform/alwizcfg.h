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
 *      Configuration defines for use on GP2X Wiz
 *
 *      By Trent Gamblin
 *
 *      See readme.txt for copyright information.
 */


#include <fcntl.h>
#include <unistd.h>

/* Describe this platform.  */
#define ALLEGRO_PLATFORM_STR  "GP2XWIZ"

#define ALLEGRO_EXTRA_HEADER "allegro5/platform/alwiz.h"
#define ALLEGRO_INTERNAL_HEADER "allegro5/platform/aintwiz.h"
#define ALLEGRO_INTERNAL_THREAD_HEADER "allegro5/platform/aintuthr.h"

/* Include configuration information.  */
#include <allegro5/platform/alplatf.h>

/* No GLX on the Wiz */
#define ALLEGRO_EXCLUDE_GLX
