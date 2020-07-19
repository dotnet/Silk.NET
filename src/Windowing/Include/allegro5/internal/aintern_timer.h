#ifndef __al_included_allegro5_aintern_timer_h
#define __al_included_allegro5_aintern_timer_h

#ifdef __cplusplus
   extern "C" {
#endif

void _al_init_timers(void);
int _al_get_active_timers_count(void);
double _al_timer_thread_handle_tick(double interval);

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
