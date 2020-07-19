#define ALLEGRO_PLATFORM_STR "SDL"

#define ALLEGRO_INTERNAL_HEADER "allegro5/platform/allegro_internal_sdl.h"
#define ALLEGRO_INTERNAL_THREAD_HEADER "allegro5/platform/allegro_sdl_thread.h"

// FIXME: remove once we don't use Unix specifics anymore
#include <fcntl.h>
#include <unistd.h>
