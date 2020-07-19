#ifndef __al_included_allegro5_aintern_dtor_h
#define __al_included_allegro5_aintern_dtor_h

#include <allegro5/internal/aintern_list.h>

#ifdef __cplusplus
   extern "C" {
#endif


typedef struct _AL_DTOR_LIST _AL_DTOR_LIST;


AL_FUNC(_AL_DTOR_LIST *, _al_init_destructors, (void));
AL_FUNC(void, _al_push_destructor_owner, (void));
AL_FUNC(void, _al_pop_destructor_owner, (void));
AL_FUNC(void, _al_run_destructors, (_AL_DTOR_LIST *dtors));
AL_FUNC(void, _al_shutdown_destructors, (_AL_DTOR_LIST *dtors));
AL_FUNC(_AL_LIST_ITEM*, _al_register_destructor, (_AL_DTOR_LIST *dtors, char const *name,
   void *object, void (*func)(void*)));
AL_FUNC(void, _al_unregister_destructor, (_AL_DTOR_LIST *dtors, _AL_LIST_ITEM* dtor_item));
AL_FUNC(void, _al_foreach_destructor, (_AL_DTOR_LIST *dtors,
                                          void (*callback)(void *object, void (*func)(void *), void *udata),
                                          void *userdata));


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set ts=8 sts=3 sw=3 et: */
