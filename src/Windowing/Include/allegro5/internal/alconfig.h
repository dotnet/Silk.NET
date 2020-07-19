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
 *      Configuration defines.
 *
 *      By Shawn Hargreaves.
 *
 *      See readme.txt for copyright information.
 */


/* for backward compatibility */
#ifdef USE_CONSOLE
   #define ALLEGRO_NO_MAGIC_MAIN
   #define ALLEGRO_USE_CONSOLE
#endif


/* include platform-specific stuff */

#include <allegro5/platform/alplatf.h>



#if defined ALLEGRO_WATCOM
   #include <allegro5/platform/alwatcom.h>
#elif defined ALLEGRO_MINGW32
   #include <allegro5/platform/almngw32.h>
#elif defined ALLEGRO_BCC32
   #include <allegro5/platform/albcc32.h>
#elif defined ALLEGRO_MSVC
   #include <allegro5/platform/almsvc.h>
#elif defined ALLEGRO_IPHONE
   #include <allegro5/platform/aliphonecfg.h>
#elif defined ALLEGRO_MACOSX
   #include <allegro5/platform/alosxcfg.h>
#elif defined ALLEGRO_ANDROID
   #include <allegro5/platform/alandroidcfg.h>
#elif defined ALLEGRO_RASPBERRYPI
   #include <allegro5/platform/alraspberrypicfg.h>
#elif defined ALLEGRO_UNIX
   #include <allegro5/platform/alucfg.h>
#elif defined ALLEGRO_SDL
   #include <allegro5/platform/allegro_sdl_config.h>
#else
   #error platform not supported
#endif

  
#include <allegro5/platform/astdint.h>
#include <allegro5/platform/astdbool.h>



/* special definitions for the GCC compiler */
#ifdef __GNUC__
   #define ALLEGRO_GCC

   #ifndef AL_INLINE
      #ifdef __cplusplus
         #define AL_INLINE(type, name, args, code)    \
            static inline type name args;             \
            static inline type name args code
      /* Needed if this header is included by C99 code, as
       * "extern __inline__" in C99 exports a new global function.
       */
      #elif __GNUC_STDC_INLINE__
         #define AL_INLINE(type, name, args, code)    \
            extern __inline__ __attribute__((__gnu_inline__)) type name args;         \
            extern __inline__ __attribute__((__gnu_inline__)) type name args code
      #else
         #define AL_INLINE(type, name, args, code)    \
            extern __inline__ type name args;         \
            extern __inline__ type name args code
      #endif
   #endif

   #ifndef AL_INLINE_STATIC
      #ifdef __cplusplus
         #define AL_INLINE_STATIC(type, name, args, code)    \
                 AL_INLINE(type, name, args, code)
      #else
         #define AL_INLINE_STATIC(type, name, args, code)    \
            static __inline__ type name args;         \
            static __inline__ type name args code
      #endif
   #endif

   #define AL_PRINTFUNC(type, name, args, a, b)    AL_FUNC(type, name, args) __attribute__ ((format (printf, a, b)))

   #ifndef INLINE
      #define INLINE          __inline__
   #endif

   #ifndef ZERO_SIZE_ARRAY
      #if __GNUC__ < 3
         #define ZERO_SIZE_ARRAY(type, name)  __extension__ type name[0]
      #else
         #define ZERO_SIZE_ARRAY(type, name)  type name[] /* ISO C99 flexible array members */
      #endif
   #endif
   
   #ifdef ALLEGRO_GUESS_INTTYPES_OK
      #define int64_t      signed long long
      #define uint64_t     unsigned long long
   #endif

   #ifdef __i386__
      #define ALLEGRO_I386
   #endif

   #ifdef __amd64__
      #define ALLEGRO_AMD64
   #endif
   
   #ifdef __arm__
      #define ALLEGRO_ARM
   #endif

   #ifndef AL_FUNC_DEPRECATED
      #if (__GNUC__ > 3) || ((__GNUC__ == 3) && (__GNUC_MINOR__ >= 1))
         #define AL_FUNC_DEPRECATED(type, name, args)              AL_FUNC(__attribute__ ((deprecated)) type, name, args)
         #define AL_PRINTFUNC_DEPRECATED(type, name, args, a, b)   AL_PRINTFUNC(__attribute__ ((deprecated)) type, name, args, a, b)
         #define AL_INLINE_DEPRECATED(type, name, args, code)      AL_INLINE(__attribute__ ((deprecated)) type, name, args, code)
      #endif
   #endif

   #ifndef AL_ALIAS
      #define AL_ALIAS(DECL, CALL)                      \
      static __attribute__((unused)) __inline__ DECL    \
      {                                                 \
         return CALL;                                   \
      }
   #endif

   #ifndef AL_ALIAS_VOID_RET
      #define AL_ALIAS_VOID_RET(DECL, CALL)                  \
      static __attribute__((unused)) __inline__ void DECL    \
      {                                                      \
         CALL;                                               \
      }
   #endif
#endif


/* the rest of this file fills in some default definitions of language
 * features and helper functions, which are conditionalised so they will
 * only be included if none of the above headers defined custom versions.
 */

#ifndef INLINE
   #define INLINE
#endif

#ifndef ZERO_SIZE_ARRAY
   #define ZERO_SIZE_ARRAY(type, name)             type name[]
#endif

#ifndef AL_VAR
   #define AL_VAR(type, name)                      extern type name
#endif

#ifndef AL_ARRAY
   #define AL_ARRAY(type, name)                    extern type name[]
#endif

#ifndef AL_FUNC
   #define AL_FUNC(type, name, args)               type name args
#endif

#ifndef AL_PRINTFUNC
   #define AL_PRINTFUNC(type, name, args, a, b)    AL_FUNC(type, name, args)
#endif

#ifndef AL_METHOD
   #define AL_METHOD(type, name, args)             type (*name) args
#endif

#ifndef AL_FUNCPTR
   #define AL_FUNCPTR(type, name, args)            extern type (*name) args
#endif

#ifndef AL_FUNCPTRARRAY
   #define AL_FUNCPTRARRAY(type, name, args)       extern type (*name[]) args
#endif

#ifndef AL_INLINE
   #define AL_INLINE(type, name, args, code)       type name args;
#endif

#ifndef AL_FUNC_DEPRECATED
   #define AL_FUNC_DEPRECATED(type, name, args)              AL_FUNC(type, name, args)
   #define AL_PRINTFUNC_DEPRECATED(type, name, args, a, b)   AL_PRINTFUNC(type, name, args, a, b)
   #define AL_INLINE_DEPRECATED(type, name, args, code)      AL_INLINE(type, name, args, code)
#endif

#ifndef AL_ALIAS
   #define AL_ALIAS(DECL, CALL)              \
   static INLINE DECL                        \
   {                                         \
      return CALL;                           \
   }
#endif

#ifndef AL_ALIAS_VOID_RET
   #define AL_ALIAS_VOID_RET(DECL, CALL)     \
   static INLINE void DECL                   \
   {                                         \
      CALL;                                  \
   }
#endif


#ifdef __cplusplus
   extern "C" {
#endif

/* endian-independent 3-byte accessor macros */
#ifdef ALLEGRO_LITTLE_ENDIAN

   #define _AL_READ3BYTES(p)   ((*(unsigned char *)(p))            \
                             | (*((unsigned char *)(p) + 1) << 8)  \
                             | (*((unsigned char *)(p) + 2) << 16))

   #define _AL_WRITE3BYTES(p,c) ((*(unsigned char *)(p) = (c)),             \
                                 (*((unsigned char *)(p) + 1) = (c) >> 8),  \
                                 (*((unsigned char *)(p) + 2) = (c) >> 16))

#elif defined ALLEGRO_BIG_ENDIAN

   #define _AL_READ3BYTES(p)  ((*(unsigned char *)(p) << 16)       \
                             | (*((unsigned char *)(p) + 1) << 8)  \
                             | (*((unsigned char *)(p) + 2)))

   #define _AL_WRITE3BYTES(p,c) ((*(unsigned char *)(p) = (c) >> 16),       \
                                 (*((unsigned char *)(p) + 1) = (c) >> 8),  \
                                 (*((unsigned char *)(p) + 2) = (c)))

#else
   #error endianess not defined
#endif

#ifdef __cplusplus
   }
#endif

