#ifndef __al_included_allegro5_aintern_xfullscreen_h
#define __al_included_allegro5_aintern_xfullscreen_h

/* fullscreen and multi monitor stuff */

typedef struct _ALLEGRO_XGLX_MMON_INTERFACE _ALLEGRO_XGLX_MMON_INTERFACE;

struct _ALLEGRO_XGLX_MMON_INTERFACE {
    int (*get_num_display_modes)(ALLEGRO_SYSTEM_XGLX *s, int adapter);
    ALLEGRO_DISPLAY_MODE *(*get_display_mode)(ALLEGRO_SYSTEM_XGLX *s, int, int, ALLEGRO_DISPLAY_MODE*);
    bool (*set_mode)(ALLEGRO_SYSTEM_XGLX *, ALLEGRO_DISPLAY_XGLX *, int, int, int, int);
    void (*store_mode)(ALLEGRO_SYSTEM_XGLX *);
    void (*restore_mode)(ALLEGRO_SYSTEM_XGLX *, int);
    void (*get_display_offset)(ALLEGRO_SYSTEM_XGLX *, int, int *, int *);
    int (*get_num_adapters)(ALLEGRO_SYSTEM_XGLX *);
    bool (*get_monitor_info)(ALLEGRO_SYSTEM_XGLX *, int, ALLEGRO_MONITOR_INFO *);
    int (*get_default_adapter)(ALLEGRO_SYSTEM_XGLX *);
    int (*get_adapter)(ALLEGRO_SYSTEM_XGLX *, ALLEGRO_DISPLAY_XGLX *);
    int (*get_xscreen)(ALLEGRO_SYSTEM_XGLX *, int);
    void (*post_setup)(ALLEGRO_SYSTEM_XGLX *, ALLEGRO_DISPLAY_XGLX *);
    void (*handle_xevent)(ALLEGRO_SYSTEM_XGLX *, ALLEGRO_DISPLAY_XGLX *, XEvent *e);
};

extern _ALLEGRO_XGLX_MMON_INTERFACE _al_xglx_mmon_interface;

int _al_xsys_mheadx_get_default_adapter(ALLEGRO_SYSTEM_XGLX *s);
int _al_xsys_mheadx_get_xscreen(ALLEGRO_SYSTEM_XGLX *s, int adapter);
void _al_xsys_get_active_window_center(ALLEGRO_SYSTEM_XGLX *s, int *x, int *y);

void _al_xsys_mmon_exit(ALLEGRO_SYSTEM_XGLX *s);

int _al_xglx_get_num_display_modes(ALLEGRO_SYSTEM_XGLX *s, int adapter);
ALLEGRO_DISPLAY_MODE *_al_xglx_get_display_mode(
   ALLEGRO_SYSTEM_XGLX *s, int adapter, int index, ALLEGRO_DISPLAY_MODE *mode);
bool _al_xglx_fullscreen_set_mode(ALLEGRO_SYSTEM_XGLX *s, ALLEGRO_DISPLAY_XGLX *d, int w, int h,
   int format, int refresh_rate);
void _al_xglx_store_video_mode(ALLEGRO_SYSTEM_XGLX *s);
void _al_xglx_restore_video_mode(ALLEGRO_SYSTEM_XGLX *s, int adapter);
void _al_xglx_fullscreen_to_display(ALLEGRO_SYSTEM_XGLX *s,
   ALLEGRO_DISPLAY_XGLX *d);
void _al_xglx_set_fullscreen_window(ALLEGRO_DISPLAY *display, int value);
void _al_xglx_get_display_offset(ALLEGRO_SYSTEM_XGLX *s, int adapter, int *x, int *y);

int _al_xglx_fullscreen_select_mode(ALLEGRO_SYSTEM_XGLX *s, int adapter, int w, int h, int format, int refresh_rate);

bool _al_xglx_get_monitor_info(ALLEGRO_SYSTEM_XGLX *s, int adapter, ALLEGRO_MONITOR_INFO *info);
int _al_xglx_get_num_video_adapters(ALLEGRO_SYSTEM_XGLX *s);

int _al_xglx_get_default_adapter(ALLEGRO_SYSTEM_XGLX *s);
int _al_xglx_get_xscreen(ALLEGRO_SYSTEM_XGLX *s, int adapter);

void _al_xglx_set_above(ALLEGRO_DISPLAY *display, int value);

int _al_xglx_get_adapter(ALLEGRO_SYSTEM_XGLX *s, ALLEGRO_DISPLAY_XGLX *d, bool recalc);

void _al_xglx_handle_mmon_event(ALLEGRO_SYSTEM_XGLX *s, ALLEGRO_DISPLAY_XGLX *d, XEvent *e);

#ifdef ALLEGRO_XWINDOWS_WITH_XRANDR
void _al_xsys_xrandr_init(ALLEGRO_SYSTEM_XGLX *s);
void _al_xsys_xrandr_exit(ALLEGRO_SYSTEM_XGLX *s);
#endif /* ALLEGRO_XWINDOWS_WITH_XRANDR */

#endif

/* vim: set sts=3 sw=3 et: */
