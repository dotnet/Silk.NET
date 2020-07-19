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
 *      CPU and system information handling.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_cpu_h
#define __al_included_allegro5_cpu_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

AL_FUNC(int, al_get_cpu_count, (void));
AL_FUNC(int, al_get_ram_size, (void));

#ifdef __cplusplus
   }
#endif

#endif

/*
 * Local Variables:
 * c-basic-offset: 3
 * indent-tabs-mode: nil
 * End:
 */
