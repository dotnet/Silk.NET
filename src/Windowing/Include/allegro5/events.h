#ifndef __al_included_allegro5_events_h
#define __al_included_allegro5_events_h

#include <allegro5/altime.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Type: ALLEGRO_EVENT_TYPE
 */
typedef unsigned int ALLEGRO_EVENT_TYPE;

enum
{
   ALLEGRO_EVENT_JOYSTICK_AXIS               =  1,
   ALLEGRO_EVENT_JOYSTICK_BUTTON_DOWN        =  2,
   ALLEGRO_EVENT_JOYSTICK_BUTTON_UP          =  3,
   ALLEGRO_EVENT_JOYSTICK_CONFIGURATION      =  4,

   ALLEGRO_EVENT_KEY_DOWN                    = 10,
   ALLEGRO_EVENT_KEY_CHAR                    = 11,
   ALLEGRO_EVENT_KEY_UP                      = 12,

   ALLEGRO_EVENT_MOUSE_AXES                  = 20,
   ALLEGRO_EVENT_MOUSE_BUTTON_DOWN           = 21,
   ALLEGRO_EVENT_MOUSE_BUTTON_UP             = 22,
   ALLEGRO_EVENT_MOUSE_ENTER_DISPLAY         = 23,
   ALLEGRO_EVENT_MOUSE_LEAVE_DISPLAY         = 24,
   ALLEGRO_EVENT_MOUSE_WARPED                = 25,

   ALLEGRO_EVENT_TIMER                       = 30,

   ALLEGRO_EVENT_DISPLAY_EXPOSE              = 40,
   ALLEGRO_EVENT_DISPLAY_RESIZE              = 41,
   ALLEGRO_EVENT_DISPLAY_CLOSE               = 42,
   ALLEGRO_EVENT_DISPLAY_LOST                = 43,
   ALLEGRO_EVENT_DISPLAY_FOUND               = 44,
   ALLEGRO_EVENT_DISPLAY_SWITCH_IN           = 45,
   ALLEGRO_EVENT_DISPLAY_SWITCH_OUT          = 46,
   ALLEGRO_EVENT_DISPLAY_ORIENTATION         = 47,
   ALLEGRO_EVENT_DISPLAY_HALT_DRAWING        = 48,
   ALLEGRO_EVENT_DISPLAY_RESUME_DRAWING      = 49,

   ALLEGRO_EVENT_TOUCH_BEGIN                 = 50,
   ALLEGRO_EVENT_TOUCH_END                   = 51,
   ALLEGRO_EVENT_TOUCH_MOVE                  = 52,
   ALLEGRO_EVENT_TOUCH_CANCEL                = 53,
   
   ALLEGRO_EVENT_DISPLAY_CONNECTED           = 60,
   ALLEGRO_EVENT_DISPLAY_DISCONNECTED        = 61
};


/* Function: ALLEGRO_EVENT_TYPE_IS_USER
 *
 *    1 <= n < 512  - builtin events
 *  512 <= n < 1024 - reserved user events (for addons)
 * 1024 <= n        - unreserved user events
 */
#define ALLEGRO_EVENT_TYPE_IS_USER(t)        ((t) >= 512)


/* Function: ALLEGRO_GET_EVENT_TYPE
 */
#define ALLEGRO_GET_EVENT_TYPE(a, b, c, d)   AL_ID(a, b, c, d)


/* Type: ALLEGRO_EVENT_SOURCE
 */
typedef struct ALLEGRO_EVENT_SOURCE ALLEGRO_EVENT_SOURCE;

struct ALLEGRO_EVENT_SOURCE
{
   int __pad[32];
};



/*
 * Event structures
 *
 * All event types have the following fields in common.
 *
 *  type      -- the type of event this is
 *  timestamp -- when this event was generated
 *  source    -- which event source generated this event
 *
 * For people writing event sources: The common fields must be at the
 * very start of each event structure, i.e. put _AL_EVENT_HEADER at the
 * front.
 */

#define _AL_EVENT_HEADER(srctype)                    \
   ALLEGRO_EVENT_TYPE type;                          \
   srctype *source;                                  \
   double timestamp;


typedef struct ALLEGRO_ANY_EVENT
{
   _AL_EVENT_HEADER(ALLEGRO_EVENT_SOURCE)
} ALLEGRO_ANY_EVENT;


typedef struct ALLEGRO_DISPLAY_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_DISPLAY)
   int x, y;
   int width, height;
   int orientation;
} ALLEGRO_DISPLAY_EVENT;


typedef struct ALLEGRO_JOYSTICK_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_JOYSTICK)
   struct ALLEGRO_JOYSTICK *id;
   int stick;
   int axis;
   float pos;
   int button;
} ALLEGRO_JOYSTICK_EVENT;



typedef struct ALLEGRO_KEYBOARD_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_KEYBOARD)
   struct ALLEGRO_DISPLAY *display; /* the window the key was pressed in */
   int keycode;                 /* the physical key pressed */
   int unichar;                 /* unicode character or negative */
   unsigned int modifiers;      /* bitfield */
   bool repeat;                 /* auto-repeated or not */
} ALLEGRO_KEYBOARD_EVENT;



typedef struct ALLEGRO_MOUSE_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_MOUSE)
   struct ALLEGRO_DISPLAY *display;
   /* (display) Window the event originate from
    * (x, y) Primary mouse position
    * (z) Mouse wheel position (1D 'wheel'), or,
    * (w, z) Mouse wheel position (2D 'ball')
    * (pressure) The pressure applied, for stylus (0 or 1 for normal mouse)
    */
   int x,  y,  z, w;
   int dx, dy, dz, dw;
   unsigned int button;
   float pressure;
} ALLEGRO_MOUSE_EVENT;



typedef struct ALLEGRO_TIMER_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_TIMER)
   int64_t count;
   double error;
} ALLEGRO_TIMER_EVENT;



typedef struct ALLEGRO_TOUCH_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_TOUCH_INPUT)
   struct ALLEGRO_DISPLAY *display;
   /* (id) Identifier of the event, always positive number.
    * (x, y) Touch position on the screen in 1:1 resolution.
    * (dx, dy) Relative touch position.
    * (primary) True, if touch is a primary one (usually first one).
    */
   int id;
   float x, y;
   float dx, dy;
   bool primary;
} ALLEGRO_TOUCH_EVENT;



/* Type: ALLEGRO_USER_EVENT
 */
typedef struct ALLEGRO_USER_EVENT ALLEGRO_USER_EVENT;

struct ALLEGRO_USER_EVENT
{
   _AL_EVENT_HEADER(struct ALLEGRO_EVENT_SOURCE)
   struct ALLEGRO_USER_EVENT_DESCRIPTOR *__internal__descr;
   intptr_t data1;
   intptr_t data2;
   intptr_t data3;
   intptr_t data4;
};



/* Type: ALLEGRO_EVENT
 */
typedef union ALLEGRO_EVENT ALLEGRO_EVENT;

union ALLEGRO_EVENT
{
   /* This must be the same as the first field of _AL_EVENT_HEADER.  */
   ALLEGRO_EVENT_TYPE type;
   /* `any' is to allow the user to access the other fields which are
    * common to all event types, without using some specific type
    * structure.
    */
   ALLEGRO_ANY_EVENT      any;
   ALLEGRO_DISPLAY_EVENT  display;
   ALLEGRO_JOYSTICK_EVENT joystick;
   ALLEGRO_KEYBOARD_EVENT keyboard;
   ALLEGRO_MOUSE_EVENT    mouse;
   ALLEGRO_TIMER_EVENT    timer;
   ALLEGRO_TOUCH_EVENT    touch;
   ALLEGRO_USER_EVENT     user;
};



/* Event sources */

AL_FUNC(void, al_init_user_event_source, (ALLEGRO_EVENT_SOURCE *));
AL_FUNC(void, al_destroy_user_event_source, (ALLEGRO_EVENT_SOURCE *));
/* The second argument is ALLEGRO_EVENT instead of ALLEGRO_USER_EVENT
 * to prevent users passing a pointer to a too-short structure.
 */
AL_FUNC(bool, al_emit_user_event, (ALLEGRO_EVENT_SOURCE *, ALLEGRO_EVENT *,
                                   void (*dtor)(ALLEGRO_USER_EVENT *)));
AL_FUNC(void, al_unref_user_event, (ALLEGRO_USER_EVENT *));
AL_FUNC(void, al_set_event_source_data, (ALLEGRO_EVENT_SOURCE*, intptr_t data));
AL_FUNC(intptr_t, al_get_event_source_data, (const ALLEGRO_EVENT_SOURCE*));



/* Event queues */

/* Type: ALLEGRO_EVENT_QUEUE
 */
typedef struct ALLEGRO_EVENT_QUEUE ALLEGRO_EVENT_QUEUE;

AL_FUNC(ALLEGRO_EVENT_QUEUE*, al_create_event_queue, (void));
AL_FUNC(void, al_destroy_event_queue, (ALLEGRO_EVENT_QUEUE*));
AL_FUNC(bool, al_is_event_source_registered, (ALLEGRO_EVENT_QUEUE *, 
         ALLEGRO_EVENT_SOURCE *));
AL_FUNC(void, al_register_event_source, (ALLEGRO_EVENT_QUEUE*, ALLEGRO_EVENT_SOURCE*));
AL_FUNC(void, al_unregister_event_source, (ALLEGRO_EVENT_QUEUE*, ALLEGRO_EVENT_SOURCE*));
AL_FUNC(void, al_pause_event_queue, (ALLEGRO_EVENT_QUEUE*, bool));
AL_FUNC(bool, al_is_event_queue_paused, (const ALLEGRO_EVENT_QUEUE*));
AL_FUNC(bool, al_is_event_queue_empty, (ALLEGRO_EVENT_QUEUE*));
AL_FUNC(bool, al_get_next_event, (ALLEGRO_EVENT_QUEUE*, ALLEGRO_EVENT *ret_event));
AL_FUNC(bool, al_peek_next_event, (ALLEGRO_EVENT_QUEUE*, ALLEGRO_EVENT *ret_event));
AL_FUNC(bool, al_drop_next_event, (ALLEGRO_EVENT_QUEUE*));
AL_FUNC(void, al_flush_event_queue, (ALLEGRO_EVENT_QUEUE*));
AL_FUNC(void, al_wait_for_event, (ALLEGRO_EVENT_QUEUE*,
                                  ALLEGRO_EVENT *ret_event));
AL_FUNC(bool, al_wait_for_event_timed, (ALLEGRO_EVENT_QUEUE*,
                                        ALLEGRO_EVENT *ret_event,
                                        float secs));
AL_FUNC(bool, al_wait_for_event_until, (ALLEGRO_EVENT_QUEUE *queue,
                                        ALLEGRO_EVENT *ret_event,
                                        ALLEGRO_TIMEOUT *timeout));

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
