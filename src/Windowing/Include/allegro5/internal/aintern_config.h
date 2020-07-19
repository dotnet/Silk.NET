#ifndef __al_included_allegro5_aintern_config_h
#define __al_included_allegro5_aintern_config_h

#include <allegro5/internal/aintern_aatree.h>

struct ALLEGRO_CONFIG_ENTRY {
   bool is_comment;
   ALLEGRO_USTR *key;    /* comment if is_comment is true */
   ALLEGRO_USTR *value;
   ALLEGRO_CONFIG_ENTRY *prev, *next;
};

struct ALLEGRO_CONFIG_SECTION {
   ALLEGRO_USTR *name;
   ALLEGRO_CONFIG_ENTRY *head;
   ALLEGRO_CONFIG_ENTRY *last;
   _AL_AATREE *tree;
   ALLEGRO_CONFIG_SECTION *prev, *next;
};

struct ALLEGRO_CONFIG {
   ALLEGRO_CONFIG_SECTION *head;
   ALLEGRO_CONFIG_SECTION *last;
   _AL_AATREE *tree;
};


#endif

