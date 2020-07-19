#ifndef __al_included_allegro5_allegro_sdl_thread_h
#define __al_included_allegro5_allegro_sdl_thread_h

#include "SDL.h"

#ifdef __cplusplus
   extern "C" {
#endif


struct _AL_MUTEX
{
   SDL_mutex *mutex;
};

struct _AL_THREAD
{
   /* private: */
   SDL_Thread *thread;
   bool should_stop;
   void (*proc)(struct _AL_THREAD *self, void *arg);
   void *arg;
};

#define _AL_MUTEX_UNINITED	       { NULL }
#define _AL_MARK_MUTEX_UNINITED(M)     do { M.mutex = NULL; } while (0)

struct _AL_COND
{
   SDL_cond *cond;
};

typedef struct ALLEGRO_TIMEOUT_SDL ALLEGRO_TIMEOUT_SDL;
struct ALLEGRO_TIMEOUT_SDL
{
   int ms;
};

AL_INLINE(bool, _al_get_thread_should_stop, (struct _AL_THREAD *t),
{
    return t->should_stop;
})


AL_FUNC(void, _al_mutex_init, (struct _AL_MUTEX*));
AL_FUNC(void, _al_mutex_destroy, (struct _AL_MUTEX*));
AL_INLINE(void, _al_mutex_lock, (struct _AL_MUTEX *m),
{
   if (m->mutex)
      SDL_LockMutex(m->mutex);
})
AL_INLINE(void, _al_mutex_unlock, (struct _AL_MUTEX *m),
{
   if (m->mutex)
      SDL_UnlockMutex(m->mutex);
})

AL_INLINE(void, _al_cond_init, (struct _AL_COND *cond),
{
   cond->cond = SDL_CreateCond();
})

AL_INLINE(void, _al_cond_destroy, (struct _AL_COND *cond),
{
   SDL_DestroyCond(cond->cond);
})

AL_INLINE(void, _al_cond_wait, (struct _AL_COND *cond, struct _AL_MUTEX *mutex),
{
   SDL_CondWait(cond->cond, mutex->mutex);
})

AL_INLINE(void, _al_cond_broadcast, (struct _AL_COND *cond),
{
   SDL_CondBroadcast(cond->cond);
})

AL_INLINE(void, _al_cond_signal, (struct _AL_COND *cond),
{
   SDL_CondSignal(cond->cond);
})


#ifdef __cplusplus
   }
#endif

#endif
