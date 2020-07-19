#ifndef __al_included_allegro_aintern_wjoydxnu_h
#define __al_included_allegro_aintern_wjoydxnu_h


/** Part of the Windows XInput joystick
 * types are shared here for use by the haptic susbystem. */

/* XInput supports only up to 4 joysticks.*/
#define MAX_JOYSTICKS        4

/* XInput joystics always have up to 14 buttons,
   2 triggers which are mapped to sliders, and 2 pairs of 2 axes.  */

#define MAX_BUTTONS          14
#define MAX_TRIGGERS          2
#define MAX_AXES              2
#define MAX_STICKS            4

/* make sure all the constants add up */
/* the first two sticks are (x,y,z) and (rx,ry,rz) */
ALLEGRO_STATIC_ASSERT(wjoydxnu, _AL_MAX_JOYSTICK_STICKS >= (2 + MAX_TRIGGERS + MAX_STICKS));
ALLEGRO_STATIC_ASSERT(wjoydxnu, _AL_MAX_JOYSTICK_BUTTONS >= MAX_BUTTONS);

typedef enum
{
   STATE_UNUSED,
   STATE_ACTIVE,
} CONFIG_STATE;

#define ACTIVE_STATE(st) \
   ((st) == STATE_ACTIVE)


typedef struct ALLEGRO_JOYSTICK_XINPUT
{
   ALLEGRO_JOYSTICK parent;                /* must be first */
   bool active;
   ALLEGRO_JOYSTICK_STATE joystate;
   DWORD index;
   XINPUT_STATE state;
   XINPUT_CAPABILITIES capabilities;
   XINPUT_VIBRATION vibration;
   char name[80];
   char all_names[512]; /* button/stick/axis names with NUL terminators */
} ALLEGRO_JOYSTICK_XINPUT;

#endif

/* vim: set sts=3 sw=3 et: */
