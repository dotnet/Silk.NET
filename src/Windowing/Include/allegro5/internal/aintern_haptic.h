#ifndef __al_included_allegro5_aintern_haptic_h
#define __al_included_allegro5_aintern_haptic_h

#include <allegro5/haptic.h>

#include <allegro5/internal/aintern_driver.h>
#include <allegro5/internal/aintern_events.h>

#ifdef __cplusplus
extern "C"
{
#endif

#if defined(ALLEGRO_INTERNAL_UNSTABLE) || defined(ALLEGRO_SRC)

typedef struct ALLEGRO_HAPTIC_DRIVER
{
   int hapdrv_id;
   const char *hapdrv_name;
   const char *hapdrv_desc;
   const char *hapdrv_ascii_name;
   AL_METHOD(bool, init_haptic, (void));
   AL_METHOD(void, exit_haptic, (void));

   AL_METHOD(bool, is_mouse_haptic, (ALLEGRO_MOUSE *));
   AL_METHOD(bool, is_joystick_haptic, (ALLEGRO_JOYSTICK *));
   AL_METHOD(bool, is_keyboard_haptic, (ALLEGRO_KEYBOARD *));
   AL_METHOD(bool, is_display_haptic, (ALLEGRO_DISPLAY *));
   AL_METHOD(bool, is_touch_input_haptic, (ALLEGRO_TOUCH_INPUT *));

   AL_METHOD(ALLEGRO_HAPTIC *, get_from_mouse, (ALLEGRO_MOUSE *));
   AL_METHOD(ALLEGRO_HAPTIC *, get_from_joystick, (ALLEGRO_JOYSTICK *));
   AL_METHOD(ALLEGRO_HAPTIC *, get_from_keyboard, (ALLEGRO_KEYBOARD *));
   AL_METHOD(ALLEGRO_HAPTIC *, get_from_display, (ALLEGRO_DISPLAY *));
   AL_METHOD(ALLEGRO_HAPTIC *, get_from_touch_input, (ALLEGRO_TOUCH_INPUT *));

   AL_METHOD(bool, get_active, (ALLEGRO_HAPTIC *));
   AL_METHOD(int, get_capabilities, (ALLEGRO_HAPTIC *));
   AL_METHOD(double, get_gain, (ALLEGRO_HAPTIC *));
   AL_METHOD(bool, set_gain, (ALLEGRO_HAPTIC *, double));
   AL_METHOD(int, get_max_effects, (ALLEGRO_HAPTIC *));

   AL_METHOD(bool, is_effect_ok, (ALLEGRO_HAPTIC *, ALLEGRO_HAPTIC_EFFECT *));
   AL_METHOD(bool, upload_effect, (ALLEGRO_HAPTIC *, ALLEGRO_HAPTIC_EFFECT *,
                                   ALLEGRO_HAPTIC_EFFECT_ID *));
   AL_METHOD(bool, play_effect, (ALLEGRO_HAPTIC_EFFECT_ID *, int));
   AL_METHOD(bool, stop_effect, (ALLEGRO_HAPTIC_EFFECT_ID *));
   AL_METHOD(bool, is_effect_playing, (ALLEGRO_HAPTIC_EFFECT_ID *));
   AL_METHOD(bool, release_effect, (ALLEGRO_HAPTIC_EFFECT_ID *));
   AL_METHOD(bool, release, (ALLEGRO_HAPTIC *));
   AL_METHOD(double, get_autocenter, (ALLEGRO_HAPTIC *));
   AL_METHOD(bool, set_autocenter, (ALLEGRO_HAPTIC *, double));
} ALLEGRO_HAPTIC_DRIVER;


enum ALLEGRO_HAPTIC_PARENT
{
   _AL_HAPTIC_FROM_JOYSTICK = 1,
   _AL_HAPTIC_FROM_MOUSE,
   _AL_HAPTIC_FROM_KEYBOARD,
   _AL_HAPTIC_FROM_DISPLAY,
   _AL_HAPTIC_FROM_TOUCH_INPUT
};

/* haptic has a driver field for per-device drivers on some platforms. */
struct ALLEGRO_HAPTIC
{
   enum ALLEGRO_HAPTIC_PARENT from;
   void *device;
   double gain;
   double autocenter;
   ALLEGRO_HAPTIC_DRIVER *driver;
};

/* Haptic driver list. */
extern const _AL_DRIVER_INFO _al_haptic_driver_list[];

/* Macros for constructing the driver list */
#define _AL_BEGIN_HAPTIC_DRIVER_LIST                                 \
   const _AL_DRIVER_INFO _al_haptic_driver_list[] =                  \
   {
#define _AL_END_HAPTIC_DRIVER_LIST                                   \
   { 0, NULL, false }                                                \
   };

#else

/* Forward declare it for ALLEGRO_SYSTEM_INTERFACE. */
typedef struct ALLEGRO_HAPTIC_DRIVER ALLEGRO_HAPTIC_DRIVER;

#endif

#ifdef __cplusplus
}
#endif

#endif

/* vim: set sts=3 sw=3 et: */
