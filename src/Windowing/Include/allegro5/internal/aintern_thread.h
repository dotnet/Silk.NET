#ifndef __al_included_allegro5_aintern_thread_h
#define __al_included_allegro5_aintern_thread_h

#include ALLEGRO_INTERNAL_THREAD_HEADER

#ifdef __cplusplus
   extern "C" {
#endif


typedef struct _AL_THREAD _AL_THREAD;
typedef struct _AL_MUTEX _AL_MUTEX;
typedef struct _AL_COND _AL_COND;


void _al_thread_create(_AL_THREAD*, void (*proc)(_AL_THREAD*, void*), void *arg);
void _al_thread_create_with_stacksize(_AL_THREAD*, void (*proc)(_AL_THREAD*, void*), void *arg, size_t stacksize);
void _al_thread_set_should_stop(_AL_THREAD *);
/* static inline bool _al_get_thread_should_stop(_AL_THREAD *); */
void _al_thread_join(_AL_THREAD*);
void _al_thread_detach(_AL_THREAD*);


void _al_mutex_init(_AL_MUTEX*);
void _al_mutex_init_recursive(_AL_MUTEX*);
void _al_mutex_destroy(_AL_MUTEX*);
/* static inline void _al_mutex_lock(_AL_MUTEX*); */
/* static inline void _al_mutex_unlock(_AL_MUTEX*); */

/* All 5 functions below are declared inline in aintuthr.h.
 * FIXME: Why are they all inline? And if they have to be, why not treat them
 * the same as the two functions above?
 */
#ifdef ALLEGRO_WINDOWS
void _al_cond_init(_AL_COND*);
void _al_cond_destroy(_AL_COND*);
void _al_cond_wait(_AL_COND*, _AL_MUTEX*);
void _al_cond_broadcast(_AL_COND*);
void _al_cond_signal(_AL_COND*);
#endif

int _al_cond_timedwait(_AL_COND*, _AL_MUTEX*, const ALLEGRO_TIMEOUT *timeout);


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set ts=8 sts=3 sw=3 et: */
