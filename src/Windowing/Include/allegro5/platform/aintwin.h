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
 *      Some definitions for internal use by the Windows library code.
 *
 *      By Stefan Schimanski.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_aintwin_h
#define __al_included_allegro5_aintwin_h

#ifndef __al_included_allegro5_allegro_h
   #error must include allegro.h first
#endif

#ifndef ALLEGRO_WINDOWS
   #error bad include
#endif


#include <allegro5/platform/aintwthr.h>
#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/internal/aintern_vector.h>
#include <allegro5/system.h>


#define WINDOWS_RGB(r,g,b)  ((COLORREF)(((BYTE)(r)|((WORD)((BYTE)(g))<<8))|(((DWORD)(BYTE)(b))<<16)))


#ifdef __cplusplus
   extern "C" {
#endif

/* user defined hooks into the main win32 event loop */

typedef bool (*ALLEGRO_DISPLAY_WIN_CALLBACK_PROC)
   (ALLEGRO_DISPLAY *, UINT, WPARAM, LPARAM, LRESULT*, void *);

typedef struct ALLEGRO_DISPLAY_WIN_CALLBACK ALLEGRO_DISPLAY_WIN_CALLBACK;

struct ALLEGRO_DISPLAY_WIN_CALLBACK
{
   ALLEGRO_DISPLAY_WIN_CALLBACK_PROC proc;
   void *userdata;
};

/* the extended display struct for Windows */

typedef struct ALLEGRO_DISPLAY_WIN ALLEGRO_DISPLAY_WIN;

struct ALLEGRO_DISPLAY_WIN
{
   ALLEGRO_DISPLAY display;

   HWND window;
   HCURSOR mouse_selected_hcursor;
   bool mouse_cursor_shown;

   UINT adapter;

   /*
    * The display thread must communicate with the main thread
    * through these variables.
    */
   volatile bool end_thread;    /* The display thread should end */
   volatile bool thread_ended;  /* The display thread has ended */

   /* For internal use by drivers, when this has been set to true
    * after al_resize_display called you can call acknowledge_resize
    */
   bool can_acknowledge;

   /* For internal use by the windows driver. When this is set and a Windows
    * window resize event is received by the window procedure, the event is
    * ignored and this value is set to false.
    */
   bool ignore_resize;

   /* Size to reset to when al_set_display_flag(FULLSCREEN_WINDOW, false)
    * is called.
    */
   int toggle_w;
   int toggle_h;

   /* A list of user callbacks associated with the window messages */
   _AL_VECTOR msg_callbacks;
};


/* standard path */
ALLEGRO_PATH *_al_win_get_path(int id);

/* thread routines */
void _al_win_thread_init(void);
void _al_win_thread_exit(void);

/* input routines */
void _al_win_grab_input(ALLEGRO_DISPLAY_WIN *win_disp);

/* keyboard routines */
void _al_win_kbd_handle_key_press(int scode, int vcode, bool extended,
                           bool repeated, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_kbd_handle_key_release(int scode, int vcode, bool extended,
                           ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_fix_modifiers(void);

/* mouse routines */
void _al_win_mouse_handle_move(int x, int y, bool abs, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_mouse_handle_wheel(int raw_dz, bool abs, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_mouse_handle_hwheel(int raw_dw, bool abs, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_mouse_handle_button(int button, bool down, int x, int y, bool abs, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_mouse_handle_leave(ALLEGRO_DISPLAY_WIN *win_display);
void _al_win_mouse_handle_enter(ALLEGRO_DISPLAY_WIN *win_display);

/* joystick routines */
void _al_win_joystick_dinput_unacquire(void *unused);
void _al_win_joystick_dinput_grab(void *ALLEGRO_DISPLAY_WIN);

/* custom Allegro messages */
extern UINT _al_win_msg_call_proc;
extern UINT _al_win_msg_suicide;

/* main window routines */
AL_FUNC(void, _al_win_wnd_schedule_proc, (HWND wnd, void (*proc)(void*), void *param));
AL_FUNC(void, _al_win_wnd_call_proc, (HWND wnd, void (*proc)(void*), void *param));

int _al_win_determine_adapter(void);

extern bool _al_win_disable_screensaver;

/* dynamic library loading */
HMODULE _al_win_safe_load_library(const char *filename);

/* time */
void _al_win_init_time(void);
void _al_win_shutdown_time(void);

/* This is used to stop MinGW from complaining about type-punning */
#define MAKE_UNION(ptr, t) \
   union {                 \
      LPVOID *v;           \
      t p;                 \
   } u;                    \
   u.p = (ptr);

typedef struct ALLEGRO_SYSTEM_WIN ALLEGRO_SYSTEM_WIN;
/* This is our version of ALLEGRO_SYSTEM with driver specific extra data. */
struct ALLEGRO_SYSTEM_WIN
{
   ALLEGRO_SYSTEM system; /* This must be the first member, we "derive" from it. */
   ALLEGRO_DISPLAY *mouse_grab_display; /* May be inaccurate. */
   int toggle_mouse_grab_keycode; /* Disabled if zero. */
   unsigned int toggle_mouse_grab_modifiers;
};

/* helpers to create windows */
HWND _al_win_create_window(ALLEGRO_DISPLAY *display, int width, int height, int flags);
HWND _al_win_create_faux_fullscreen_window(LPCTSTR devname, ALLEGRO_DISPLAY *display,
                                           int x1, int y1, int width, int height,
                                           int refresh_rate, int flags);
int  _al_win_init_window(void);
HWND _al_win_create_hidden_window(void);
void _al_win_post_create_window(ALLEGRO_DISPLAY *display);

/* icon helpers */
void  _al_win_set_display_icons(ALLEGRO_DISPLAY *display, int num_icons, ALLEGRO_BITMAP *bitmap[]);
HICON _al_win_create_icon(HWND wnd, ALLEGRO_BITMAP *sprite, int xfocus, int yfocus, bool is_cursor, bool resize);
void _al_win_destroy_display_icons(ALLEGRO_DISPLAY *display);

/* window decorations */
void _al_win_set_window_position(HWND window, int x, int y);
void _al_win_get_window_position(HWND window, int *x, int *y);
bool _al_win_set_window_constraints(ALLEGRO_DISPLAY *display, int min_w, int min_h, int max_w, int max_h);
bool _al_win_get_window_constraints(ALLEGRO_DISPLAY *display, int *min_w, int *min_h, int *max_w, int *max_h);
void _al_win_apply_window_constraints(ALLEGRO_DISPLAY *display, bool onoff);
void _al_win_set_window_frameless(ALLEGRO_DISPLAY *display, HWND window, bool frameless);
bool _al_win_set_display_flag(ALLEGRO_DISPLAY *display, int flag, bool onoff);
void _al_win_set_window_title(ALLEGRO_DISPLAY *display, const char *title);

/* cursor routines */
typedef struct ALLEGRO_MOUSE_CURSOR_WIN ALLEGRO_MOUSE_CURSOR_WIN;
struct ALLEGRO_MOUSE_CURSOR_WIN
{
   HCURSOR hcursor;
};

ALLEGRO_MOUSE_CURSOR* _al_win_create_mouse_cursor(ALLEGRO_BITMAP *sprite, int xfocus, int yfocus);
void _al_win_destroy_mouse_cursor(ALLEGRO_MOUSE_CURSOR *cursor);
bool _al_win_set_mouse_cursor(ALLEGRO_DISPLAY *display, ALLEGRO_MOUSE_CURSOR *cursor);
bool _al_win_set_system_mouse_cursor(ALLEGRO_DISPLAY *display, ALLEGRO_SYSTEM_MOUSE_CURSOR cursor_id);
bool _al_win_show_mouse_cursor(ALLEGRO_DISPLAY *display);
bool _al_win_hide_mouse_cursor(ALLEGRO_DISPLAY *display);


/* driver specific functions */

#if defined ALLEGRO_CFG_D3D
   ALLEGRO_DISPLAY_INTERFACE* _al_display_d3d_driver(void);
   int _al_d3d_get_num_display_modes(int format, int refresh_rate, int flags);
   ALLEGRO_DISPLAY_MODE* _al_d3d_get_display_mode(int index, int format,
                                                  int refresh_rate, int flags,
                                                  ALLEGRO_DISPLAY_MODE *mode);
   void _al_d3d_shutdown_display(void);
#endif /*  defined ALLEGRO_CFG_D3D */

#if defined ALLEGRO_CFG_OPENGL
   ALLEGRO_DISPLAY_INTERFACE *_al_display_wgl_driver(void);
   int _al_wgl_get_num_display_modes(int format, int refresh_rate, int flags);
   ALLEGRO_DISPLAY_MODE* _al_wgl_get_display_mode(int index, int format,
                                                  int refresh_rate, int flags,
                                                  ALLEGRO_DISPLAY_MODE *mode);
#endif /*  defined ALLEGRO_CFG_OPENGL */


/* touch input specific API */

#if (_WIN32_WINNT < 0x0601)
typedef struct tagTOUCHINPUT {
   LONG x;
   LONG y;
   HANDLE hSource;
   DWORD dwID;
   DWORD dwFlags;
   DWORD dwMask;
   DWORD dwTime;
   ULONG_PTR dwExtraInfo;
   DWORD cxContact;
   DWORD cyContact;
} TOUCHINPUT, *PTOUCHINPUT;
#endif

/* Define those fellows. They are available on Windows SDK 7.0,
 * which is shipped with Visual Studio 2010. So it is not likely they
 * will be defined in <windows.h>. Also do not trust MinGW WinAPI
 * headers as they are outdated. Version 3.15, which is newest at the
 * time of writting this, still have invalid defines related to
 * multi-touch support.
 */
#define _AL_WM_TOUCH                         0x0240

#define _AL_MOUSEEVENTF_FROMTOUCH            0xFF515700

#define _AL_TOUCHEVENTF_MOVE                 0x0001
#define _AL_TOUCHEVENTF_DOWN                 0x0002
#define _AL_TOUCHEVENTF_UP                   0x0004
#define _AL_TOUCHEVENTF_PRIMARY              0x0010

#define _AL_SM_DIGITIZER                     94

#define _AL_NID_READY                        0x80


/* set of function required to handle touch input on Windows */
typedef BOOL (WINAPI *CLOSETOUCHINPUTHANDLEPROC)(HANDLE hTouchInput);
typedef BOOL (WINAPI *GETTOUCHINPUTINFOPROC)(HANDLE hTouchInput, UINT cInputs, PTOUCHINPUT pInputs, int cbSize);
typedef BOOL (WINAPI *ISTOUCHWINDOWPROC)(HWND hWnd, PULONG pulFlags);
typedef BOOL (WINAPI *REGISTERTOUCHWINDOWPROC)(HWND hWnd, ULONG ulFlags);
typedef BOOL (WINAPI *UNREGISTERTOUCHWINDOWPROC)(HWND hWnd);

bool _al_win_init_touch_input_api(void);
void _al_win_exit_touch_input_api(void);

extern CLOSETOUCHINPUTHANDLEPROC     _al_win_close_touch_input_handle;
extern GETTOUCHINPUTINFOPROC         _al_win_get_touch_input_info;
extern ISTOUCHWINDOWPROC             _al_win_is_touch_window;
extern REGISTERTOUCHWINDOWPROC       _al_win_register_touch_window;
extern UNREGISTERTOUCHWINDOWPROC     _al_win_unregister_touch_window;

/* touch input routines */
void _al_win_touch_input_set_time_stamp(size_t timestamp);
void _al_win_touch_input_handle_begin(int id, size_t timestamp, float x, float y, bool primary, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_touch_input_handle_end(int id, size_t timestamp, float x, float y, bool primary, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_touch_input_handle_move(int id, size_t timestamp, float x, float y, bool primary, ALLEGRO_DISPLAY_WIN *win_disp);
void _al_win_touch_input_handle_cancel(int id, size_t timestamp, float x, float y, bool primary, ALLEGRO_DISPLAY_WIN *win_disp);

/* Helpers for getting Windows system errors 
 * May be called from addons 
 */
AL_FUNC(const char*, _al_win_error, (DWORD));
AL_FUNC(const char*, _al_win_last_error, (void));

/* Time handling */
double _al_win_get_time(void);
void _al_win_rest(double seconds);
void _al_win_init_timeout(ALLEGRO_TIMEOUT *timeout, double seconds);

#ifdef __cplusplus
   }
#endif


#endif

