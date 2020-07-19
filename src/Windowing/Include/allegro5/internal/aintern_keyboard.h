#ifndef __al_included_allegro5_aintern_keyboard_h
#define __al_included_allegro5_aintern_keyboard_h

#include <allegro5/internal/aintern_driver.h>

#ifdef __cplusplus
   extern "C" {
#endif


typedef struct ALLEGRO_KEYBOARD_DRIVER
{
   int  keydrv_id;
   const char *keydrv_name;
   const char *keydrv_desc;
   const char *keydrv_ascii_name;
   AL_METHOD(bool, init_keyboard, (void));
   AL_METHOD(void, exit_keyboard, (void));
   AL_METHOD(ALLEGRO_KEYBOARD*, get_keyboard, (void));
   AL_METHOD(bool, set_keyboard_leds, (int leds));
   AL_METHOD(const char *, keycode_to_name, (int keycode));
   AL_METHOD(void, get_keyboard_state, (ALLEGRO_KEYBOARD_STATE *ret_state));
   AL_METHOD(void, clear_keyboard_state, (void));
} ALLEGRO_KEYBOARD_DRIVER;


extern _AL_DRIVER_INFO _al_keyboard_driver_list[];

extern const char *_al_keyboard_common_names[];

int _al_parse_key_binding(const char *s, unsigned int *modifiers);


struct ALLEGRO_KEYBOARD
{
   ALLEGRO_EVENT_SOURCE es;
};


/* Helpers for AL_KEYBOARD_STATE structures.  */

#define _AL_KEYBOARD_STATE_KEY_DOWN(STATE, KEYCODE)                     \
   (((STATE).__key_down__internal__[(KEYCODE) / 32] & (1 << ((KEYCODE) % 32)))\
    ? true : false)

#define _AL_KEYBOARD_STATE_SET_KEY_DOWN(STATE, KEYCODE)                 \
   do {                                                                 \
      int kc = (KEYCODE);                                               \
      (STATE).__key_down__internal__[kc / 32] |= (1 << (kc % 32));      \
   } while (0)

#define _AL_KEYBOARD_STATE_CLEAR_KEY_DOWN(STATE, KEYCODE)               \
   do {                                                                 \
      int kc = (KEYCODE);                                               \
      (STATE).__key_down__internal__[kc / 32] &= ~(1 << (kc % 32));     \
   } while (0)


#ifdef __cplusplus
   }
#endif

#endif

/* vi ts=8 sts=3 sw=3 et */
