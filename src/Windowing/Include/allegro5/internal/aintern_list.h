#ifndef __al_included_allegro5_aintern_list_h
#define __al_included_allegro5_aintern_list_h

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _AL_LIST _AL_LIST;
typedef struct _AL_LIST_ITEM _AL_LIST_ITEM;

typedef void (*_AL_LIST_DTOR)(void* userdata);
typedef void (*_AL_LIST_ITEM_DTOR)(void* value, void* userdata);

AL_FUNC(_AL_LIST*, _al_list_create, (void));
AL_FUNC(_AL_LIST*, _al_list_create_static, (size_t capacity));
AL_FUNC(void, _al_list_destroy, (_AL_LIST* list));

AL_FUNC(void, _al_list_set_dtor, (_AL_LIST* list, _AL_LIST_DTOR dtor));
AL_FUNC(_AL_LIST_DTOR, _al_list_get_dtor, (_AL_LIST* list));

AL_FUNC(_AL_LIST_ITEM*, _al_list_push_front, (_AL_LIST* list, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_push_front_ex, (_AL_LIST* list, void* data, _AL_LIST_ITEM_DTOR dtor));
AL_FUNC(_AL_LIST_ITEM*, _al_list_push_back, (_AL_LIST* list, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_push_back_ex, (_AL_LIST* list, void* data, _AL_LIST_ITEM_DTOR dtor));

AL_FUNC(void, _al_list_pop_front, (_AL_LIST* list));
AL_FUNC(void, _al_list_pop_back, (_AL_LIST* list));

AL_FUNC(_AL_LIST_ITEM*, _al_list_insert_after, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_insert_after_ex, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data, _AL_LIST_ITEM_DTOR dtor));
AL_FUNC(_AL_LIST_ITEM*, _al_list_insert_before, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_insert_before_ex, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data, _AL_LIST_ITEM_DTOR dtor));

AL_FUNC(void, _al_list_erase, (_AL_LIST* list, _AL_LIST_ITEM* item));

AL_FUNC(void, _al_list_clear, (_AL_LIST* list));

AL_FUNC(void, _al_list_remove, (_AL_LIST* list, void* data));

AL_FUNC(bool, _al_list_is_empty, (_AL_LIST* list));

AL_FUNC(bool, _al_list_contains, (_AL_LIST* list, void* data));

AL_FUNC(_AL_LIST_ITEM*, _al_list_find_first, (_AL_LIST* list, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_find_last, (_AL_LIST* list, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_find_after, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data));
AL_FUNC(_AL_LIST_ITEM*, _al_list_find_before, (_AL_LIST* list, _AL_LIST_ITEM* where, void* data));

AL_FUNC(size_t, _al_list_size, (_AL_LIST* list));

AL_FUNC(_AL_LIST_ITEM*, _al_list_at, (_AL_LIST* list, size_t index));

AL_FUNC(_AL_LIST_ITEM*, _al_list_front, (_AL_LIST* list));
AL_FUNC(_AL_LIST_ITEM*, _al_list_back, (_AL_LIST* list));

AL_FUNC(_AL_LIST_ITEM*, _al_list_next, (_AL_LIST* list, _AL_LIST_ITEM* item));
AL_FUNC(_AL_LIST_ITEM*, _al_list_previous, (_AL_LIST* list, _AL_LIST_ITEM* item));

AL_FUNC(_AL_LIST_ITEM*, _al_list_next_circular, (_AL_LIST* list, _AL_LIST_ITEM* item));
AL_FUNC(_AL_LIST_ITEM*, _al_list_previous_circular, (_AL_LIST* list, _AL_LIST_ITEM* item));

AL_FUNC(void*, _al_list_item_data, (_AL_LIST_ITEM* item));

AL_FUNC(void, _al_list_item_set_dtor, (_AL_LIST_ITEM* item, _AL_LIST_ITEM_DTOR dtor));
AL_FUNC(_AL_LIST_ITEM_DTOR, _al_list_item_get_dtor, (_AL_LIST_ITEM* item));

AL_FUNC(void, _al_list_set_user_data, (_AL_LIST* list, void* user_data));
AL_FUNC(void*, _al_list_get_user_data, (_AL_LIST* list));


#ifdef __cplusplus
}
#endif

#endif
