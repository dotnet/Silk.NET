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
 *      Joystick routines.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_joystick_h
#define __al_included_allegro5_joystick_h

#include <allegro5/base.h>
#include <allegro5/events.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* internal values */
#define _AL_MAX_JOYSTICK_AXES	   3
#define _AL_MAX_JOYSTICK_STICKS    16
#define _AL_MAX_JOYSTICK_BUTTONS   32



/* Type: ALLEGRO_JOYSTICK
 */
typedef struct ALLEGRO_JOYSTICK ALLEGRO_JOYSTICK;



/* Type: ALLEGRO_JOYSTICK_STATE
 */
typedef struct ALLEGRO_JOYSTICK_STATE ALLEGRO_JOYSTICK_STATE;

struct ALLEGRO_JOYSTICK_STATE
{
   struct {
      float axis[_AL_MAX_JOYSTICK_AXES];        /* -1.0 to 1.0 */
   } stick[_AL_MAX_JOYSTICK_STICKS];
   int button[_AL_MAX_JOYSTICK_BUTTONS];        /* 0 to 32767 */
};


/* Enum: ALLEGRO_JOYFLAGS
 */
enum ALLEGRO_JOYFLAGS
{
   ALLEGRO_JOYFLAG_DIGITAL  = 0x01,
   ALLEGRO_JOYFLAG_ANALOGUE = 0x02
};



AL_FUNC(bool,           al_install_joystick,    (void));
AL_FUNC(void,           al_uninstall_joystick,  (void));
AL_FUNC(bool,           al_is_joystick_installed, (void));
AL_FUNC(bool,           al_reconfigure_joysticks, (void));

AL_FUNC(int,            al_get_num_joysticks,   (void));
AL_FUNC(ALLEGRO_JOYSTICK *, al_get_joystick,    (int joyn));
AL_FUNC(void,           al_release_joystick,    (ALLEGRO_JOYSTICK *));
AL_FUNC(bool,           al_get_joystick_active, (ALLEGRO_JOYSTICK *));
AL_FUNC(const char*,    al_get_joystick_name,   (ALLEGRO_JOYSTICK *));

AL_FUNC(int,            al_get_joystick_num_sticks, (ALLEGRO_JOYSTICK *));
AL_FUNC(int, al_get_joystick_stick_flags, (ALLEGRO_JOYSTICK *, int stick)); /* junk? */
AL_FUNC(const char*,    al_get_joystick_stick_name, (ALLEGRO_JOYSTICK *, int stick));

AL_FUNC(int,            al_get_joystick_num_axes,   (ALLEGRO_JOYSTICK *, int stick));
AL_FUNC(const char*,    al_get_joystick_axis_name,  (ALLEGRO_JOYSTICK *, int stick, int axis));

AL_FUNC(int,            al_get_joystick_num_buttons,  (ALLEGRO_JOYSTICK *));
AL_FUNC(const char*,    al_get_joystick_button_name,  (ALLEGRO_JOYSTICK *, int buttonn));

AL_FUNC(void,           al_get_joystick_state,  (ALLEGRO_JOYSTICK *, ALLEGRO_JOYSTICK_STATE *ret_state));

AL_FUNC(ALLEGRO_EVENT_SOURCE *, al_get_joystick_event_source, (void));

#ifdef __cplusplus
   }
#endif

#endif
