#ifndef __al_included_allegro_aintern_wjoydxnu_h
#define __al_included_allegro_aintern_wjoydxnu_h


/** Part of the Windows joystick wrapper driver 
 * types are shared here for use by the haptic susbystem. */
 
typedef struct ALLEGRO_JOYSTICK_WINDOWS_ALL {
   ALLEGRO_JOYSTICK            parent;          /* must be first */
   bool                        active;
   int                         index;
   ALLEGRO_JOYSTICK          * handle;
   ALLEGRO_JOYSTICK_DRIVER   * driver;
} ALLEGRO_JOYSTICK_WINDOWS_ALL;

#endif

/* vim: set sts=3 sw=3 et: */
