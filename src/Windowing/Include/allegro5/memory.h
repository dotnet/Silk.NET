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
 *      Memory management routines.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_memory_h
#define __al_included_allegro5_memory_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif


/* Type: ALLEGRO_MEMORY_INTERFACE
 */
typedef struct ALLEGRO_MEMORY_INTERFACE ALLEGRO_MEMORY_INTERFACE;

struct ALLEGRO_MEMORY_INTERFACE {
   void *(*mi_malloc)(size_t n, int line, const char *file, const char *func);
   void (*mi_free)(void *ptr, int line, const char *file, const char *func);
   void *(*mi_realloc)(void *ptr, size_t n, int line, const char *file, const char *func);
   void *(*mi_calloc)(size_t count, size_t n, int line, const char *file, const char *func);
};

AL_FUNC(void, al_set_memory_interface, (ALLEGRO_MEMORY_INTERFACE *iface));


/* Function: al_malloc
 */
#define al_malloc(n) \
   (al_malloc_with_context((n), __LINE__, __FILE__, __func__))

/* Function: al_free
 */
#define al_free(p) \
   (al_free_with_context((p), __LINE__, __FILE__, __func__))

/* Function: al_realloc
 */
#define al_realloc(p, n) \
   (al_realloc_with_context((p), (n), __LINE__, __FILE__, __func__))

/* Function: al_calloc
 */
#define al_calloc(c, n) \
   (al_calloc_with_context((c), (n), __LINE__, __FILE__, __func__))


AL_FUNC(void *, al_malloc_with_context, (size_t n,
   int line, const char *file, const char *func));
AL_FUNC(void, al_free_with_context, (void *ptr,
   int line, const char *file, const char *func));
AL_FUNC(void *, al_realloc_with_context, (void *ptr, size_t n,
   int line, const char *file, const char *func));
AL_FUNC(void *, al_calloc_with_context, (size_t count, size_t n,
   int line, const char *file, const char *func));


#ifdef __cplusplus
   }
#endif

#endif
