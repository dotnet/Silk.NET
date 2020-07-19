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
 *      A header file to get C99's stdbool.h.
 *
 *      By Peter Wang.
 * 
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_astdbool_h
#define __al_included_allegro5_astdbool_h

#ifndef __cplusplus
#  ifdef ALLEGRO_HAVE_STDBOOL_H
#     include <stdbool.h>
#  else
#     ifndef ALLEGRO_HAVE__BOOL
         typedef unsigned char _Bool;
#     endif
#     define bool _Bool
#     define false 0
#     define true 1
#     define __bool_true_false_are_defined 1
#  endif
#endif

#endif
