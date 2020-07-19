#ifndef __al_included_allegro5_aintern_joystick_h
#define __al_included_allegro5_aintern_joystick_h

#include <allegro5/internal/aintern_driver.h>
#include <allegro5/internal/aintern_events.h>

#ifdef __cplusplus
   extern "C" {
#endif


typedef struct ALLEGRO_JOYSTICK_DRIVER
{
   int  joydrv_id;
   const char *joydrv_name;
   const char *joydrv_desc;
   const char *joydrv_ascii_name;
   AL_METHOD(bool, init_joystick, (void));
   AL_METHOD(void, exit_joystick, (void));
   AL_METHOD(bool, reconfigure_joysticks, (void));
   AL_METHOD(int, num_joysticks, (void));
   AL_METHOD(ALLEGRO_JOYSTICK *, get_joystick, (int joyn));
   AL_METHOD(void, release_joystick, (ALLEGRO_JOYSTICK *joy));
   AL_METHOD(void, get_joystick_state, (ALLEGRO_JOYSTICK *joy, ALLEGRO_JOYSTICK_STATE *ret_state));
   AL_METHOD(const char *, get_name, (ALLEGRO_JOYSTICK *joy));
   AL_METHOD(bool, get_active, (ALLEGRO_JOYSTICK *joy));
} ALLEGRO_JOYSTICK_DRIVER;


extern _AL_DRIVER_INFO _al_joystick_driver_list[];


/* macros for constructing the driver list */
#define _AL_BEGIN_JOYSTICK_DRIVER_LIST                         \
   _AL_DRIVER_INFO _al_joystick_driver_list[] =                \
   {

#define _AL_END_JOYSTICK_DRIVER_LIST                           \
      {  0,                NULL,                false }        \
   };


/* information about a single joystick axis */
typedef struct _AL_JOYSTICK_AXIS_INFO
{
   char *name;
} _AL_JOYSTICK_AXIS_INFO;


/* information about one or more axis (a slider or directional control) */
typedef struct _AL_JOYSTICK_STICK_INFO
{
   int flags; /* bit-field */
   int num_axes;
   _AL_JOYSTICK_AXIS_INFO axis[_AL_MAX_JOYSTICK_AXES];
   char *name;
} _AL_JOYSTICK_STICK_INFO;


/* information about a joystick button */
typedef struct _AL_JOYSTICK_BUTTON_INFO
{
   const char *name;
} _AL_JOYSTICK_BUTTON_INFO;


/* information about an entire joystick */
typedef struct _AL_JOYSTICK_INFO
{
   int num_sticks;
   int num_buttons;
   _AL_JOYSTICK_STICK_INFO stick[_AL_MAX_JOYSTICK_STICKS];
   _AL_JOYSTICK_BUTTON_INFO button[_AL_MAX_JOYSTICK_BUTTONS];
} _AL_JOYSTICK_INFO;


/* Joystick has a driver field for per-device drivers,
 * needed on some platforms. */
struct ALLEGRO_JOYSTICK
{
   _AL_JOYSTICK_INFO info;
   ALLEGRO_JOYSTICK_DRIVER * driver;
};

void _al_generate_joystick_event(ALLEGRO_EVENT *event);

#ifdef __cplusplus
   }
#endif

#endif

/* vi ts=8 sts=3 sw=3 et */
