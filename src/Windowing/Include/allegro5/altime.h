#ifndef __al_included_allegro5_altime_h
#define __al_included_allegro5_altime_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Type: ALLEGRO_TIMEOUT
 */
typedef struct ALLEGRO_TIMEOUT ALLEGRO_TIMEOUT;
struct ALLEGRO_TIMEOUT {
   uint64_t __pad1__;
   uint64_t __pad2__;
};



AL_FUNC(double, al_get_time, (void));
AL_FUNC(void, al_rest, (double seconds));
AL_FUNC(void, al_init_timeout, (ALLEGRO_TIMEOUT *timeout, double seconds));



#ifdef __cplusplus
   }
#endif

#endif
