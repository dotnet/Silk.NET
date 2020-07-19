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
 *      Timer routines.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_timer_h
#define __al_included_allegro5_timer_h

#include <allegro5/base.h>
#include <allegro5/events.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Function: ALLEGRO_USECS_TO_SECS
 */
#define ALLEGRO_USECS_TO_SECS(x)      ((x) / 1000000.0)

/* Function: ALLEGRO_MSECS_TO_SECS
 */
#define ALLEGRO_MSECS_TO_SECS(x)      ((x) / 1000.0)

/* Function: ALLEGRO_BPS_TO_SECS
 */
#define ALLEGRO_BPS_TO_SECS(x)        (1.0 / (x))

/* Function: ALLEGRO_BPM_TO_SECS
 */
#define ALLEGRO_BPM_TO_SECS(x)        (60.0 / (x))


/* Type: ALLEGRO_TIMER
 */
typedef struct ALLEGRO_TIMER ALLEGRO_TIMER;


AL_FUNC(ALLEGRO_TIMER*, al_create_timer, (double speed_secs));
AL_FUNC(void, al_destroy_timer, (ALLEGRO_TIMER *timer));
AL_FUNC(void, al_start_timer, (ALLEGRO_TIMER *timer));
AL_FUNC(void, al_stop_timer, (ALLEGRO_TIMER *timer));
AL_FUNC(void, al_resume_timer, (ALLEGRO_TIMER *timer));
AL_FUNC(bool, al_get_timer_started, (const ALLEGRO_TIMER *timer));
AL_FUNC(double, al_get_timer_speed, (const ALLEGRO_TIMER *timer));
AL_FUNC(void, al_set_timer_speed, (ALLEGRO_TIMER *timer, double speed_secs));
AL_FUNC(int64_t, al_get_timer_count, (const ALLEGRO_TIMER *timer));
AL_FUNC(void, al_set_timer_count, (ALLEGRO_TIMER *timer, int64_t count));
AL_FUNC(void, al_add_timer_count, (ALLEGRO_TIMER *timer, int64_t diff));
AL_FUNC(ALLEGRO_EVENT_SOURCE *, al_get_timer_event_source, (ALLEGRO_TIMER *timer));


#ifdef __cplusplus
   }
#endif

#endif
