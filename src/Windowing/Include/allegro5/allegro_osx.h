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
 */


#ifndef A5_OSX_ALLEGRO_H
#define A5_OSX_ALLEGRO_H

/*
 *  Public Objective-C OSX-related API
 */
#ifdef __cplusplus
   extern "C" {
#endif

AL_FUNC(NSWindow *, al_osx_get_window,            (ALLEGRO_DISPLAY *d));

#ifdef __cplusplus
   }
#endif

#endif /* A5_OSX_ALLEGRO_H */
