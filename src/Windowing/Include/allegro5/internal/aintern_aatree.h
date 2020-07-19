#ifndef __al_included_allegro5_aintern_aatree_h
#define __al_included_allegro5_aintern_aatree_h

typedef struct _AL_AATREE _AL_AATREE;

struct _AL_AATREE
{
   int         level;
   _AL_AATREE  *left;
   _AL_AATREE  *right;
   const void  *key;
   void        *value;
};

typedef int (*_al_cmp_t)(const void *a, const void *b);

_AL_AATREE *_al_aa_insert(_AL_AATREE *T, const void *key, void *value, _al_cmp_t compare);
void *_al_aa_search(const _AL_AATREE *T, const void *key, _al_cmp_t compare);
_AL_AATREE *_al_aa_delete(_AL_AATREE *T, const void *key, _al_cmp_t compare, void **ret_value);
void _al_aa_free(_AL_AATREE *T);

#endif

/* vim: set sts=3 sw=3 et: */
