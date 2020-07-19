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
 *      Configuration defines for use with Digital Mars C compiler.
 *
 *      By Matthew Leverton.
 *
 *      See readme.txt for copyright information.
 */


#include <io.h>
#include <fcntl.h>

#include <stdint.h>


/* a static auto config */
#define ALLEGRO_HAVE_INTTYPES_H
#define ALLEGRO_HAVE_STDINT_H

#define LONG_LONG long long

/* describe this platform */
#ifdef ALLEGRO_STATICLINK
   #define ALLEGRO_PLATFORM_STR  "DMC.s"
#else
   #define ALLEGRO_PLATFORM_STR  "DMC"
#endif

#define ALLEGRO_WINDOWS
#define ALLEGRO_I386
#define ALLEGRO_LITTLE_ENDIAN

#ifdef ALLEGRO_USE_CONSOLE
   #define ALLEGRO_NO_MAGIC_MAIN
#endif


/* describe how function prototypes look to DMC */
#if (defined ALLEGRO_STATICLINK) || (defined ALLEGRO_SRC)
   #define _AL_DLL
#else
   #define _AL_DLL   __declspec(dllimport)
#endif

#define AL_VAR(type, name)                   extern _AL_DLL type name
#define AL_ARRAY(type, name)                 extern _AL_DLL type name[]
#define AL_FUNC(type, name, args)            extern type name args
#define AL_METHOD(type, name, args)          type (*name) args
#define AL_FUNCPTR(type, name, args)         extern _AL_DLL type (*name) args


/* Windows specific defines */

#if (defined ALLEGRO_SRC)

#if (!defined S_IRUSR)
   #define S_IRUSR   S_IREAD
   #define S_IWUSR   S_IWRITE
#endif

typedef unsigned long   _fsize_t;

struct _wfinddata_t {
   unsigned attrib;
   time_t   time_create;         /* -1 for FAT file systems */
   time_t   time_access;         /* -1 for FAT file systems */
   time_t   time_write;
   _fsize_t size;
   wchar_t  name[260];           /* may include spaces. */
};

#endif /* ALLEGRO_SRC */

/* arrange for other headers to be included later on */
#define ALLEGRO_EXTRA_HEADER     "allegro5/platform/alwin.h"
#define ALLEGRO_INTERNAL_HEADER  "allegro5/platform/aintwin.h"
