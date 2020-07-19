#ifndef __al_included_allegro5_aintern_path_h
#define __al_included_allegro5_aintern_path_h

struct ALLEGRO_PATH {
   ALLEGRO_USTR *drive;
   ALLEGRO_USTR *filename;
   _AL_VECTOR segments;    /* vector of ALLEGRO_USTR * */
   ALLEGRO_USTR *basename;
   ALLEGRO_USTR *full_string;
};

#endif

/* vim: set sts=3 sw=3 et: */
