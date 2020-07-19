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
 *      Windows-specific header defines.
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */


#ifndef ALLEGRO_WINDOWS
   #error bad include
#endif

/*******************************************/
/********** magic main emulation ***********/
/*******************************************/
#ifdef __cplusplus
extern "C" {
#endif

AL_FUNC(int, _WinMain, (void *_main, void *hInst, void *hPrev, char *Cmd, int nShow));

#ifdef __cplusplus
}
#endif


/* The following is due to torhu from A.cc (see
 * http://www.allegro.cc/forums/thread/596872/756993#target)
 */
#ifndef ALLEGRO_NO_MAGIC_MAIN
   #if defined _MSC_VER && !defined ALLEGRO_LIB_BUILD
      #pragma comment(linker,"/ENTRY:mainCRTStartup")
   #endif
#endif


/*******************************************/
/************ joystick drivers *************/
/*******************************************/
#define AL_JOY_TYPE_DIRECTX      AL_ID('D','X',' ',' ')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_joydrv_directx);

#ifdef __cplusplus
}
#endif

#define _AL_JOYSTICK_DRIVER_DIRECTX                                            \
   { AL_JOY_TYPE_DIRECTX,  &_al_joydrv_directx,    true  },

#define AL_JOY_TYPE_XINPUT      AL_ID('X','I',' ',' ')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_joydrv_xinput);

#ifdef __cplusplus
}
#endif

#define _AL_JOYSTICK_DRIVER_XINPUT                                             \
   { AL_JOY_TYPE_XINPUT,  &_al_joydrv_xinput,    true  },

#define AL_JOY_TYPE_WINDOWS_ALL  AL_ID('X','D',' ',' ')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_joydrv_windows_all);

#ifdef __cplusplus
}
#endif

#define _AL_JOYSTICK_DRIVER_WINDOWS_ALL                                        \
   { AL_JOY_TYPE_WINDOWS_ALL,  &_al_joydrv_windows_all,    true  },



/*******************************************/
/************ haptic drivers   *************/
/*******************************************/

#define AL_HAPTIC_TYPE_DIRECTX   AL_ID('D','X','F','F')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_HAPTIC_DRIVER, _al_hapdrv_directx);

#ifdef __cplusplus
}
#endif

#define _AL_HAPTIC_DRIVER_DIRECTX                                              \
   { AL_HAPTIC_TYPE_DIRECTX,  &_al_hapdrv_directx,    true  },


#define AL_HAPTIC_TYPE_XINPUT      AL_ID('X','I','F','F')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_HAPTIC_DRIVER, _al_hapdrv_xinput);

#ifdef __cplusplus
}
#endif

#define _AL_HAPTIC_DRIVER_XINPUT                                               \
   { AL_HAPTIC_TYPE_XINPUT,  &_al_hapdrv_xinput,    true  },
   
   
#define AL_HAPTIC_TYPE_WINDOWS_ALL AL_ID('X','D','F','F')

#ifdef __cplusplus
extern "C" {
#endif

AL_VAR(struct ALLEGRO_HAPTIC_DRIVER, _al_hapdrv_windows_all);

#ifdef __cplusplus
}
#endif

#define _AL_HAPTIC_DRIVER_WINDOWS_ALL                                          \
   { AL_HAPTIC_TYPE_WINDOWS_ALL,  &_al_hapdrv_windows_all,    true  },

   
