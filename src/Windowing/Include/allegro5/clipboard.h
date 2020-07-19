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
 *      Clipboard handling.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_clipboard_h
#define __al_included_allegro5_clipboard_h

#include <allegro5/base.h>
#include <allegro5/display.h>
#include <allegro5/utf8.h>

#ifdef __cplusplus
   extern "C" {
#endif

AL_FUNC(char *, al_get_clipboard_text, (ALLEGRO_DISPLAY *display));
AL_FUNC(bool, al_set_clipboard_text, (ALLEGRO_DISPLAY *display, const char *text));
AL_FUNC(bool, al_clipboard_has_text, (ALLEGRO_DISPLAY *display));

#ifdef __cplusplus
   }
#endif

#endif

/*
 * Local Variables:
 * c-basic-offset: 3
 * indent-tabs-mode: nil
 * End:
 */
