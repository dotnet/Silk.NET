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
 *      Haptic (that is, force feedback) routines for Allegro.
 *
 *      By Beoran.
 *
 *      See LICENSE.txt for copyright information.
 */

#ifndef __al_included_allegro5_haptic_h
#define __al_included_allegro5_haptic_h

#include <allegro5/base.h>
#include <allegro5/display.h>
#include <allegro5/events.h>
#include <allegro5/joystick.h>
#include <allegro5/keyboard.h>
#include <allegro5/mouse.h>
#include <allegro5/touch_input.h>

#ifdef __cplusplus
   extern "C" {
#endif

#if defined(ALLEGRO_UNSTABLE) || defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)

/* Enum: ALLEGRO_HAPTIC_CONSTANTS
 */
enum ALLEGRO_HAPTIC_CONSTANTS
{
   ALLEGRO_HAPTIC_RUMBLE   = 1 << 0,
   ALLEGRO_HAPTIC_PERIODIC = 1 << 1,
   ALLEGRO_HAPTIC_CONSTANT = 1 << 2,
   ALLEGRO_HAPTIC_SPRING   = 1 << 3,
   ALLEGRO_HAPTIC_FRICTION = 1 << 4,
   ALLEGRO_HAPTIC_DAMPER   = 1 << 5,
   ALLEGRO_HAPTIC_INERTIA  = 1 << 6,
   ALLEGRO_HAPTIC_RAMP     = 1 << 7,
   ALLEGRO_HAPTIC_SQUARE   = 1 << 8,
   ALLEGRO_HAPTIC_TRIANGLE = 1 << 9,
   ALLEGRO_HAPTIC_SINE     = 1 << 10,
   ALLEGRO_HAPTIC_SAW_UP   = 1 << 11,
   ALLEGRO_HAPTIC_SAW_DOWN = 1 << 12,
   ALLEGRO_HAPTIC_CUSTOM   = 1 << 13,
   ALLEGRO_HAPTIC_GAIN     = 1 << 14,
   ALLEGRO_HAPTIC_ANGLE    = 1 << 15,
   ALLEGRO_HAPTIC_RADIUS   = 1 << 16,
   ALLEGRO_HAPTIC_AZIMUTH  = 1 << 17,
   ALLEGRO_HAPTIC_AUTOCENTER= 1 << 18,
};



/* Type: ALLEGRO_HAPTIC
 */
typedef struct ALLEGRO_HAPTIC ALLEGRO_HAPTIC;

/* Direction of a haptic effect. Angle is a value between 0 and 2*M_PI.
 * An angle 0 means oriented towards the user, M_PI is away from the user
 * (towards the screen). Angle is only supported if the device capabilities
 * include ALLEGRO_HAPTIC_ANGLE.
 *
 * Radius (if supported) is the distance of the effect from the user as a
 * value between 0 and 1. Normally it is zero. Radius is only supported if the
 * device capabilities include ALLEGRO_HAPTIC_RADIUS.
 *
 * Azimuth is the angle of elevation, between -M_PI/2 and M_PI/2.
 * Zero points to the horizontal plane, -M_PI/2 points down, and M_PI/2 points
 * up. Azimuth is only supported if the device capabilities include
 * ALLEGRO_HAPTIC_AZIMUTH.
 */
struct ALLEGRO_HAPTIC_DIRECTION
{
   double angle;
   double radius;
   double azimuth;
};

/* In all of the following structs, the doubles that express duration
 * represent time in seconds. The double that represent levels of intensity
 * are between 0.0 and 1.0.
 */

/* Delay to start the replay and duration of the replay, expressed in seconds. */
struct ALLEGRO_HAPTIC_REPLAY
{
   double length;
   double delay;
};

/* Envelope of the effect. */
struct ALLEGRO_HAPTIC_ENVELOPE
{
   double attack_length;
   double attack_level;
   double fade_length;
   double fade_level;
};

/* Constant effect.  Level is between 0.0 and 1.0. */
struct ALLEGRO_HAPTIC_CONSTANT_EFFECT
{
   double level;
   struct ALLEGRO_HAPTIC_ENVELOPE envelope;
};

/* Ramp effect. Both start_level and end level are between 0.0 and 1.0. */
struct ALLEGRO_HAPTIC_RAMP_EFFECT
{
   double start_level;
   double end_level;
   struct ALLEGRO_HAPTIC_ENVELOPE envelope;
};

/* Condition effect. */
struct ALLEGRO_HAPTIC_CONDITION_EFFECT
{
   double right_saturation;
   double left_saturation;
   double right_coeff;
   double left_coeff;
   double deadband;
   double center;
};

/* Periodic (wave) effect. */
struct ALLEGRO_HAPTIC_PERIODIC_EFFECT
{
   int waveform;
   double period;
   double magnitude;
   double offset;
   double phase;

   struct ALLEGRO_HAPTIC_ENVELOPE envelope;
   int custom_len;
   double *custom_data;
};

/* Simple rumble effect with a magnitude between 0.0 and 1.0 for both
 * the strong and the weak rumble motors in the haptic device.
 */
struct ALLEGRO_HAPTIC_RUMBLE_EFFECT
{
   double strong_magnitude;
   double weak_magnitude;
};

union ALLEGRO_HAPTIC_EFFECT_UNION
{
   struct ALLEGRO_HAPTIC_CONSTANT_EFFECT constant;
   struct ALLEGRO_HAPTIC_RAMP_EFFECT ramp;
   struct ALLEGRO_HAPTIC_PERIODIC_EFFECT periodic;
   struct ALLEGRO_HAPTIC_CONDITION_EFFECT condition;
   struct ALLEGRO_HAPTIC_RUMBLE_EFFECT rumble;
};


/* Type: ALLEGRO_HAPTIC_EFFECT
 */
struct ALLEGRO_HAPTIC_EFFECT
{

   int type;
   struct ALLEGRO_HAPTIC_DIRECTION direction;
   struct ALLEGRO_HAPTIC_REPLAY replay;
   union ALLEGRO_HAPTIC_EFFECT_UNION data;
};

typedef struct ALLEGRO_HAPTIC_EFFECT ALLEGRO_HAPTIC_EFFECT;


/* Type: ALLEGRO_HAPTIC_EFFECT_ID
 */
typedef struct ALLEGRO_HAPTIC_EFFECT_ID ALLEGRO_HAPTIC_EFFECT_ID;

struct ALLEGRO_HAPTIC_EFFECT_ID
{
   ALLEGRO_HAPTIC *_haptic;
   int _id;
   int _handle;
   void * _pointer;
   double _effect_duration;
   bool _playing;
   double _start_time;
   double _end_time;
   void * driver;
};


AL_FUNC(bool, al_install_haptic, (void));
AL_FUNC(void, al_uninstall_haptic, (void));
AL_FUNC(bool, al_is_haptic_installed, (void));

AL_FUNC(bool, al_is_mouse_haptic, (ALLEGRO_MOUSE *));
AL_FUNC(bool, al_is_joystick_haptic, (ALLEGRO_JOYSTICK *));
AL_FUNC(bool, al_is_keyboard_haptic, (ALLEGRO_KEYBOARD *));
AL_FUNC(bool, al_is_display_haptic, (ALLEGRO_DISPLAY *));
AL_FUNC(bool, al_is_touch_input_haptic, (ALLEGRO_TOUCH_INPUT *));

AL_FUNC(ALLEGRO_HAPTIC *, al_get_haptic_from_mouse, (ALLEGRO_MOUSE *));
AL_FUNC(ALLEGRO_HAPTIC *, al_get_haptic_from_joystick, (ALLEGRO_JOYSTICK *));
AL_FUNC(ALLEGRO_HAPTIC *, al_get_haptic_from_keyboard, (ALLEGRO_KEYBOARD *));
AL_FUNC(ALLEGRO_HAPTIC *, al_get_haptic_from_display, (ALLEGRO_DISPLAY *));
AL_FUNC(ALLEGRO_HAPTIC *, al_get_haptic_from_touch_input, (ALLEGRO_TOUCH_INPUT *));

AL_FUNC(bool, al_release_haptic, (ALLEGRO_HAPTIC *));

AL_FUNC(bool, al_is_haptic_active, (ALLEGRO_HAPTIC *));
AL_FUNC(int, al_get_haptic_capabilities, (ALLEGRO_HAPTIC *));
AL_FUNC(bool, al_is_haptic_capable, (ALLEGRO_HAPTIC *, int));

AL_FUNC(bool, al_set_haptic_gain, (ALLEGRO_HAPTIC *, double));
AL_FUNC(double, al_get_haptic_gain, (ALLEGRO_HAPTIC *));

AL_FUNC(bool, al_set_haptic_autocenter, (ALLEGRO_HAPTIC *, double));
AL_FUNC(double, al_get_haptic_autocenter, (ALLEGRO_HAPTIC *));


AL_FUNC(int, al_get_max_haptic_effects, (ALLEGRO_HAPTIC *));
AL_FUNC(bool, al_is_haptic_effect_ok, (ALLEGRO_HAPTIC *, ALLEGRO_HAPTIC_EFFECT *));
AL_FUNC(bool, al_upload_haptic_effect, (ALLEGRO_HAPTIC *, ALLEGRO_HAPTIC_EFFECT *, ALLEGRO_HAPTIC_EFFECT_ID *));
AL_FUNC(bool, al_play_haptic_effect, (ALLEGRO_HAPTIC_EFFECT_ID *, int));
AL_FUNC(bool, al_upload_and_play_haptic_effect, (ALLEGRO_HAPTIC *, ALLEGRO_HAPTIC_EFFECT *, ALLEGRO_HAPTIC_EFFECT_ID *, int));
AL_FUNC(bool, al_stop_haptic_effect, (ALLEGRO_HAPTIC_EFFECT_ID *));
AL_FUNC(bool, al_is_haptic_effect_playing, (ALLEGRO_HAPTIC_EFFECT_ID *));
AL_FUNC(bool, al_release_haptic_effect, (ALLEGRO_HAPTIC_EFFECT_ID *));
AL_FUNC(double, al_get_haptic_effect_duration, (ALLEGRO_HAPTIC_EFFECT *));
AL_FUNC(bool, al_rumble_haptic, (ALLEGRO_HAPTIC *, double, double, ALLEGRO_HAPTIC_EFFECT_ID *));

#endif

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
