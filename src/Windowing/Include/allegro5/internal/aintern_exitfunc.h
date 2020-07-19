#ifndef __al_included_allegro5_aintern_exitfunc_h
#define __al_included_allegro5_aintern_exitfunc_h

#ifdef __cplusplus
   extern "C" {
#endif


/* list of functions to call at program cleanup */
AL_FUNC(void, _al_add_exit_func, (AL_METHOD(void, func, (void)), const char *desc));
AL_FUNC(void, _al_remove_exit_func, (AL_METHOD(void, func, (void))));
AL_FUNC(void, _al_run_exit_funcs, (void));


#ifdef __cplusplus
   }
#endif

#endif
