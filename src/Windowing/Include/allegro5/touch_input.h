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
 *      Touch input routines.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_touch_input_h
#define __al_included_allegro5_touch_input_h

#include <allegro5/base.h>
#include <allegro5/events.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Enum: ALLEGRO_TOUCH_INPUT_MAX_TOUCH_COUNT
 */
#define ALLEGRO_TOUCH_INPUT_MAX_TOUCH_COUNT        16


/* Type: ALLEGRO_TOUCH_INPUT
 */
typedef struct ALLEGRO_TOUCH_INPUT ALLEGRO_TOUCH_INPUT;


/* Type: ALLEGRO_TOUCH_INPUT_STATE
 */
typedef struct ALLEGRO_TOUCH_INPUT_STATE ALLEGRO_TOUCH_INPUT_STATE;


/* Type: ALLEGRO_TOUCH_STATE
 */
typedef struct ALLEGRO_TOUCH_STATE ALLEGRO_TOUCH_STATE;


struct ALLEGRO_TOUCH_STATE
{
   /* (id) An identifier of touch. If touch is valid this number is positive.
    * (x, y) Touch position on the screen in 1:1 resolution.
    * (dx, dy) Relative touch position.
    * (primary) True, if touch is a primary one (usually first one).
    * (display) Display at which the touch belong.
    */
   int id;
   float x, y;
   float dx, dy;
   bool primary;
   struct ALLEGRO_DISPLAY *display;
};

struct ALLEGRO_TOUCH_INPUT_STATE
{
   ALLEGRO_TOUCH_STATE touches[ALLEGRO_TOUCH_INPUT_MAX_TOUCH_COUNT];
};


#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
/* Enum: ALLEGRO_MOUSE_EMULATION_MODE
 */
typedef enum ALLEGRO_MOUSE_EMULATION_MODE
{
   ALLEGRO_MOUSE_EMULATION_NONE,
   ALLEGRO_MOUSE_EMULATION_TRANSPARENT,
   ALLEGRO_MOUSE_EMULATION_INCLUSIVE,
   ALLEGRO_MOUSE_EMULATION_EXCLUSIVE,
   ALLEGRO_MOUSE_EMULATION_5_0_x
} ALLEGRO_MOUSE_EMULATION_MODE;
#endif


AL_FUNC(bool,           al_is_touch_input_installed,     (void));
AL_FUNC(bool,           al_install_touch_input,          (void));
AL_FUNC(void,           al_uninstall_touch_input,        (void));
AL_FUNC(void,           al_get_touch_input_state,        (ALLEGRO_TOUCH_INPUT_STATE *ret_state));
AL_FUNC(ALLEGRO_EVENT_SOURCE *, al_get_touch_input_event_source, (void));

#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)
AL_FUNC(void,           al_set_mouse_emulation_mode,     (int mode));
AL_FUNC(int,            al_get_mouse_emulation_mode,     (void));
AL_FUNC(ALLEGRO_EVENT_SOURCE *, al_get_touch_input_mouse_emulation_event_source, (void));
#endif

#ifdef __cplusplus
   }
#endif

#endif
