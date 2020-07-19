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
 *      Some definitions for internal use by the Raspberry Pi library code.
 *
 *      By Trent Gamblin.
 * 
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_aintraspberrypi_h
#define __al_included_allegro5_aintraspberrypi_h

#ifdef __cplusplus
extern "C" {
#endif

#include <allegro5/platform/aintunix.h>

#include <allegro5/internal/aintern_keyboard.h>

ALLEGRO_KEYBOARD_DRIVER *_al_xwin_keyboard_driver(void);

#ifdef __cplusplus
}
#endif


#endif
