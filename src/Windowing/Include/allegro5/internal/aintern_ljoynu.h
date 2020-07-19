#ifndef __al_included_allegro_aintern_ljoynu_h
#define __al_included_allegro_aintern_ljoynu_h

#include <allegro5/joystick.h>
#include <allegro5/internal/aintern_joystick.h>


/* XXX reconsider what needs to be exposed after the haptics driver is in */


/* State transitions:
 *    unused -> born
 *    born -> alive
 *    born -> dying
 *    active -> dying
 *    dying -> unused
 */
typedef enum {
   LJOY_STATE_UNUSED,
   LJOY_STATE_BORN,
   LJOY_STATE_ALIVE,
   LJOY_STATE_DYING
} CONFIG_STATE;

#define ACTIVE_STATE(st) \
   ((st) == LJOY_STATE_ALIVE || (st) == LJOY_STATE_DYING)


/* Map a Linux joystick axis number to an Allegro (stick,axis) pair
 * Uses the input event interface's numbering where ABS_MISC = 0x28,
 * so that is the maximum of allowed axes on Linux.
 */
#define TOTAL_JOYSTICK_AXES (0x28)

typedef struct {
   int stick;
   int axis;
   /* XXX reconsider what fields are required after the haptics driver is in */
   int value;
   int min;
   int max;
   int fuzz;
   int flat;
} AXIS_MAPPING;


/* Map a Linux input button code to button number on the Allegro joystick. */
typedef struct {
   int ev_code;
} BUTTON_MAPPING;


typedef struct ALLEGRO_JOYSTICK_LINUX
{
   ALLEGRO_JOYSTICK parent;
   int config_state;
   bool marked;
   int fd;
   ALLEGRO_USTR *device_name;

   AXIS_MAPPING axis_mapping[TOTAL_JOYSTICK_AXES];
   BUTTON_MAPPING button_mapping[_AL_MAX_JOYSTICK_BUTTONS];
   ALLEGRO_JOYSTICK_STATE joystate;
   char name[100];
} ALLEGRO_JOYSTICK_LINUX;


#endif

/* vim: set sts=3 sw=3 et: */
