#ifndef __al_included_allegro5_internal_aintern_driver_h
#define __al_included_allegro5_internal_aintern_driver_h


typedef struct _AL_DRIVER_INFO      /* info about a hardware driver */
{
   int id;                          /* integer ID */
   void *driver;                    /* the driver structure */
   int autodetect;                  /* set to allow autodetection */
} _AL_DRIVER_INFO;


#endif
