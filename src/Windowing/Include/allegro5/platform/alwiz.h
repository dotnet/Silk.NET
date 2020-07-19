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
 *      Wiz-specific header defines.
 *
 *      By Trent Gamblin
 *
 *      See readme.txt for copyright information.
 */


#ifndef ALLEGRO_GP2XWIZ
   #error bad include
#endif

#define AL_JOY_TYPE_GP2XWIZ      AL_ID('W','I','Z',' ')

AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_joydrv_gp2xwiz);

#define _AL_JOYSTICK_DRIVER_GP2XWIZ                                     \
   { AL_JOY_TYPE_GP2XWIZ,  &_al_joydrv_gp2xwiz,    true  },


#include <allegro5/platform/alunix.h>

