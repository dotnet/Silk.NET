#include <SDL.h>

#include <allegro5/altime.h>
#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_keyboard.h>
#include <allegro5/internal/aintern_mouse.h>
#include <allegro5/internal/aintern_bitmap.h>
#include <allegro5/internal/aintern_system.h>

typedef struct
{
   ALLEGRO_SYSTEM system;
   ALLEGRO_MUTEX *mutex;
   #ifdef __EMSCRIPTEN__
      double timer_time;
   #endif
} ALLEGRO_SYSTEM_SDL;

typedef struct ALLEGRO_DISPLAY_SDL
{
   ALLEGRO_DISPLAY display; /* This must be the first member. */

   int x, y;
   SDL_Window *window;
   SDL_GLContext context;
} ALLEGRO_DISPLAY_SDL;

ALLEGRO_SYSTEM_INTERFACE *_al_sdl_system_driver(void);
ALLEGRO_DISPLAY_INTERFACE *_al_sdl_display_driver(void);
ALLEGRO_KEYBOARD_DRIVER *_al_sdl_keyboard_driver(void);
ALLEGRO_MOUSE_DRIVER *_al_sdl_mouse_driver(void);
ALLEGRO_TOUCH_INPUT_DRIVER *_al_sdl_touch_input_driver(void);
ALLEGRO_JOYSTICK_DRIVER *_al_sdl_joystick_driver(void);
ALLEGRO_BITMAP_INTERFACE *_al_sdl_bitmap_driver(void);

void _al_sdl_keyboard_event(SDL_Event *e);
void _al_sdl_mouse_event(SDL_Event *e);
void _al_sdl_touch_input_event(SDL_Event *e);
void _al_sdl_display_event(SDL_Event *e);
void _al_sdl_joystick_event(SDL_Event *e);

int _al_sdl_get_allegro_pixel_format(int sdl_format);
int _al_sdl_get_sdl_pixel_format(int allegro_format);

ALLEGRO_DISPLAY *_al_sdl_find_display(uint32_t window_id);
float _al_sdl_get_display_pixel_ratio(ALLEGRO_DISPLAY *display);

void _al_sdl_event_hack(void);

double _al_sdl_get_time(void);
void _al_sdl_rest(double seconds);
void _al_sdl_init_timeout(ALLEGRO_TIMEOUT *timeout, double seconds);
