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
 *      Some definitions for internal use by the Unix library code.
 *
 *      By Shawn Hargreaves.
 * 
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_aintunix_h
#define __al_included_allegro5_aintunix_h

#include <allegro5/altime.h>
#include <allegro5/path.h>
#include <allegro5/internal/aintern_driver.h>

/* Need right now for XKeyEvent --pw */
#ifdef ALLEGRO_WITH_XWINDOWS
#include <X11/Xlib.h>
#endif

#ifdef __cplusplus
extern "C" {
#endif

ALLEGRO_PATH *_al_unix_get_path(int id);
double _al_unix_get_time(void);
void _al_unix_rest(double seconds);
void _al_unix_init_timeout(ALLEGRO_TIMEOUT *timeout, double seconds);


#ifdef __cplusplus
}
#endif


#ifdef ALLEGRO_LINUX
   #include <allegro5/platform/aintlnx.h>
#endif



/*----------------------------------------------------------------------*
 *									*
 *	New stuff							*
 *									*
 *----------------------------------------------------------------------*/

/* TODO: integrate this above */

#include <allegro5/platform/aintuthr.h>


#ifdef __cplusplus
   extern "C" {
#endif

/* time */
void _al_unix_init_time(void);

/* fdwatch */
void _al_unix_start_watching_fd(int fd, void (*callback)(void *), void *cb_data);
void _al_unix_stop_watching_fd(int fd);

/* ljoynu.c */
/* This isn't in aintlnx.h because it's needed for the X11 port as well. */
#define _ALLEGRO_JOYDRV_LINUX    AL_ID('L','N','X','A')

#ifdef ALLEGRO_HAVE_LINUX_INPUT_H
AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_joydrv_linux);
#endif

/* lhaptic.c */
/* This isn't in aintlnx.h because it's needed for the X11 port as well. */
#define _ALLEGRO_HAPDRV_LINUX    AL_ID('L','N','X','H')

#ifdef ALLEGRO_HAVE_LINUX_INPUT_H
AL_VAR(struct ALLEGRO_HAPTIC_DRIVER, _al_hapdrv_linux);
#endif


#ifdef __cplusplus
   }
#endif


#endif
