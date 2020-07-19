#ifndef __al_included_allegro5_aintern_float_h
#define __al_included_allegro5_aintern_float_h

   /* This file used to contain a tricky function that sped up float->int
    * conversions on x86 machines when the SSE instruction CVTTSS2SI wasn't
    * available (or when SSE wasn't enabled in the compiler).
    *
    * However, it performed rounding instead of truncating like (int)f, which
    * did cause problems.  If an alternative is found we could define this
    * macro once again.
    */
   #define _al_fast_float_to_int(f)  ((int)(f))

#endif

/* vim: set sts=3 sw=3 et: */
