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


#ifndef A5_IPHONE_ALLEGRO_OBJC_H
#define A5_IPHONE_ALLEGRO_OBJC_H

/*
 *  Public Objective-C iPhone-related API
 */

#ifdef __cplusplus
extern "C" {
#endif

AL_FUNC(UIWindow *, al_iphone_get_window,            (ALLEGRO_DISPLAY *d));
AL_FUNC(UIView *,   al_iphone_get_view,              (ALLEGRO_DISPLAY *d));

#ifdef __cplusplus
}
#endif

#endif /* A5_IPHONE_ALLEGRO_OBJC_H */
