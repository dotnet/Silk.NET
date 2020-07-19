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
 *      Some definitions for internal use by the Linux console code.
 *
 *      By George Foot.
 * 
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_aintlnx_h
#define __al_included_allegro5_aintlnx_h

#ifdef __cplusplus
extern "C" {
#endif


/**************************************/
/************ Driver lists ************/
/**************************************/

extern _AL_DRIVER_INFO _al_linux_keyboard_driver_list[];
extern _AL_DRIVER_INFO _al_linux_mouse_driver_list[];

#ifdef ALLEGRO_RASPBERRYPI
#define AL_MOUSEDRV_LINUX_EVDEV AL_ID('E', 'V', 'D', 'V')
#endif

/****************************************/
/************ Memory mapping ************/ /* (src/linux/lmemory.c) */
/****************************************/

/* struct MAPPED_MEMORY:  Used to describe a block of memory mapped 
 *  into our address space (in particular, the video memory).
 */
struct MAPPED_MEMORY {
	unsigned int base, size;      /* linear address and size of block */
	int perms;                    /* PROT_READ | PROT_WRITE, etc */
	void *data;                   /* pointer to block after mapping */
};

extern int __al_linux_have_ioperms;

int __al_linux_init_memory (void);
int __al_linux_shutdown_memory (void);
int __al_linux_map_memory (struct MAPPED_MEMORY *info);
int __al_linux_unmap_memory (struct MAPPED_MEMORY *info);


/******************************************/
/************ Console routines ************/ /* (src/linux/lconsole.c) */
/******************************************/

extern int __al_linux_vt;
extern int __al_linux_console_fd;
extern int __al_linux_prev_vt;
extern int __al_linux_got_text_message;
extern struct termios __al_linux_startup_termio;
extern struct termios __al_linux_work_termio;

int __al_linux_use_console (void);
int __al_linux_leave_console (void);

int __al_linux_console_graphics (void);
int __al_linux_console_text (void);

int __al_linux_wait_for_display (void);


/**************************************/
/************ VT switching ************/ /* (src/linux/vtswitch.c) */
/**************************************/

/* signals for VT switching */
#define SIGRELVT        SIGUSR1
#define SIGACQVT        SIGUSR2

int __al_linux_init_vtswitch (void);
int __al_linux_done_vtswitch (void);

int __al_linux_set_display_switch_mode (int mode);
void __al_linux_display_switch_lock (int lock, int foreground);

extern volatile int __al_linux_switching_blocked;



#ifdef __cplusplus
}
#endif



#endif

