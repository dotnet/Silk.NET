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
 *      Internal header file for the MacOS X Allegro library port.
 *
 *      By Angelo Mottola.
 *
 *      See readme.txt for copyright information.
 */


#ifndef __al_included_allegro5_aintosx_h
#define __al_included_allegro5_aintosx_h

#include <allegro5/internal/aintern.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/internal/aintern_events.h>
#include <allegro5/internal/aintern_display.h>
#include <allegro5/internal/aintern_joystick.h>
#include <allegro5/internal/aintern_keyboard.h>
#include <allegro5/internal/aintern_mouse.h>
#include <allegro5/platform/aintunix.h>

#ifdef __OBJC__

#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <unistd.h>
#include <signal.h>
#include <pthread.h>


#ifndef NSAppKitVersionNumber10_1
#define NSAppKitVersionNumber10_1       620
#endif
#ifndef NSAppKitVersionNumber10_2
#define NSAppKitVersionNumber10_2       663
#endif

#if MAC_OS_X_VERSION_MIN_REQUIRED < 1040
#error Cannot target OS X versions before 10.4
#endif

/* We include code to detect a "dead bootstrap context" and fail
 * gracefully if that situation is detected, but some of the code uses
 * deprecated functions and it isn't generally clear what "dead bootstrap
 * context" means (google's first result points back to Allegro). It is
 * also not clear if the problem this aims to solve still occurs on recent
 * versions of OS X.
 * Define OSX_BOOTSTRAP_DETECTION to compile this check in. It can
 * be brought back/reactivated when someone finds out how.
 */
//#define OSX_BOOTSTRAP_DETECTION


#define HID_MAX_DEVICES                 MAX_JOYSTICKS
#define HID_MOUSE                       0
#define HID_JOYSTICK                    1
#define HID_GAMEPAD                     2

#define HID_MAX_DEVICE_ELEMENTS         ((MAX_JOYSTICK_AXIS * MAX_JOYSTICK_STICKS) + MAX_JOYSTICK_BUTTONS)
#define HID_ELEMENT_BUTTON              0
#define HID_ELEMENT_AXIS                1
#define HID_ELEMENT_AXIS_PRIMARY_X      2
#define HID_ELEMENT_AXIS_PRIMARY_Y      3
#define HID_ELEMENT_STANDALONE_AXIS     4
#define HID_ELEMENT_HAT                 5


/* If we've included IOKit, generate the full definition
 * otherwise just a forward definition
 */
#ifdef _IOKIT_HID_IOHIDLIB_H_

typedef struct HID_ELEMENT
{
   int type;
   IOHIDElementCookie cookie;
   int max, min;
   int app;
   int col;
   int index;
   char *name;
} HID_ELEMENT;


typedef struct HID_DEVICE
{
   int type;
   char *manufacturer;
   char *product;
   int num_elements;
   int capacity;
   HID_ELEMENT *element;
   IOHIDDeviceInterface **interface;
   int cur_app;
} HID_DEVICE;

typedef struct 
{
   int count;
   int capacity;
   HID_DEVICE* devices;
} HID_DEVICE_COLLECTION;
#else
typedef struct HID_ELEMENT HID_ELEMENT;
typedef struct HID_DEVICE HID_DEVICE;
typedef struct HID_DEVICE_COLLECTION HID_DEVICE_COLLECTION;
#endif

int _al_osx_bootstrap_ok(void);

void _al_osx_keyboard_handler(int pressed, NSEvent *event, ALLEGRO_DISPLAY*);
void _al_osx_keyboard_modifiers(unsigned int new_mods, ALLEGRO_DISPLAY*);
void _al_osx_keyboard_focused(int focused, int state);

void _al_osx_mouse_generate_event(NSEvent*, ALLEGRO_DISPLAY*);
void _al_osx_mouse_handler(NSEvent*);
int _al_osx_mouse_set_sprite(ALLEGRO_BITMAP *sprite, int x, int y);
int _al_osx_mouse_show(ALLEGRO_BITMAP *bmp, int x, int y);
void _al_osx_mouse_hide(void);
void _al_osx_mouse_move(int x, int y);

HID_DEVICE_COLLECTION *_al_osx_hid_scan(int type, HID_DEVICE_COLLECTION*);
void _al_osx_hid_free(HID_DEVICE_COLLECTION *);

// Record in the keyboard state that the main window has changed
void _al_osx_switch_keyboard_focus(ALLEGRO_DISPLAY *, bool switch_in);
// Record in the mouse state that the main window has changed
void _al_osx_switch_mouse_focus(ALLEGRO_DISPLAY *, bool switch_in);
// Clear the mouse state when a dialog closes in the dialog addon
void _al_osx_clear_mouse_state(void);
// Notify the display that the mouse driver was installed/uninstalled.
void _al_osx_mouse_was_installed(BOOL);
// Create and destroy mouse cursors
ALLEGRO_MOUSE_CURSOR *_al_osx_create_mouse_cursor(ALLEGRO_BITMAP *bmp, int x_focus, int y_focus);
void _al_osx_destroy_mouse_cursor(ALLEGRO_MOUSE_CURSOR *curs);
// Notify the display that the keyboard driver was installed/uninstalled.
void _al_osx_keyboard_was_installed(BOOL);
// Notify that the quit menu was clicked
void _al_osx_post_quit(void);
// Get the underlying view
NSView* _al_osx_view_from_display(ALLEGRO_DISPLAY*);
// Create an image from an allegro bitmap
NSImage* NSImageFromAllegroBitmap(ALLEGRO_BITMAP* bmp);
// Drivers
AL_FUNC(ALLEGRO_KEYBOARD_DRIVER*, _al_osx_get_keyboard_driver, (void));
AL_FUNC(ALLEGRO_DISPLAY_INTERFACE*, _al_osx_get_display_driver, (void));
AL_FUNC(ALLEGRO_MOUSE_DRIVER*, _al_osx_get_mouse_driver, (void));
AL_FUNC(ALLEGRO_JOYSTICK_DRIVER*, _al_osx_get_joystick_driver, (void));
#endif

AL_FUNC(int, _al_osx_run_main, (int argc, char **argv,
   int (*real_main)(int, char **)));

#endif

/* Local variables:       */
/* mode: objc             */
/* c-basic-offset: 3      */
/* indent-tabs-mode: nil  */
/* End:                   */
