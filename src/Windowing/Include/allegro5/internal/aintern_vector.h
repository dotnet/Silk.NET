#ifndef __al_included_allegro5_aintern_vector_h
#define __al_included_allegro5_aintern_vector_h

#ifdef __cplusplus
   extern "C" {
#endif


typedef struct _AL_VECTOR
{
   /* private */
   size_t _itemsize;
   char*  _items;  /* total size == (size + unused) * itemsize */
   size_t _size;
   size_t _unused;
} _AL_VECTOR;

#define _AL_VECTOR_INITIALIZER(typ) { sizeof(typ), 0, 0, 0 }


AL_FUNC(void,  _al_vector_init, (_AL_VECTOR*, size_t itemsize));
AL_INLINE(size_t, _al_vector_size, (const _AL_VECTOR *vec),
{
   return vec->_size;
})
AL_INLINE(bool, _al_vector_is_empty, (const _AL_VECTOR *vec),
{
   ASSERT(vec);
   return vec->_size == 0 ? true : false; 
})
AL_INLINE(bool, _al_vector_is_nonempty, (const _AL_VECTOR *vec),
{
   ASSERT(vec);
   return !_al_vector_is_empty(vec); 
})
AL_FUNC(void*, _al_vector_ref, (const _AL_VECTOR*, unsigned int index));
AL_FUNC(void*, _al_vector_ref_front, (const _AL_VECTOR*));
AL_FUNC(void*, _al_vector_ref_back, (const _AL_VECTOR*));
AL_FUNC(bool, _al_vector_append_array, (_AL_VECTOR *vec, unsigned int num, const void *arr));
AL_FUNC(void*, _al_vector_alloc_back, (_AL_VECTOR*));
AL_FUNC(void*, _al_vector_alloc_mid, (_AL_VECTOR*, unsigned int index));
AL_FUNC(int,  _al_vector_find, (const _AL_VECTOR*, const void *ptr_item));
AL_FUNC(bool, _al_vector_contains, (const _AL_VECTOR*, const void *ptr_item));
AL_FUNC(void, _al_vector_delete_at, (_AL_VECTOR*, unsigned int index));
AL_FUNC(bool, _al_vector_find_and_delete, (_AL_VECTOR*, const void *ptr_item));
AL_FUNC(void, _al_vector_free, (_AL_VECTOR*));


#ifdef __cplusplus
   }
#endif

#endif

/* vi ts=8 sts=3 sw=3 et */
