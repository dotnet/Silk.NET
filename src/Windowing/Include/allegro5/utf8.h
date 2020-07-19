#ifndef __al_included_allegro5_utf8_h
#define __al_included_allegro5_utf8_h

#include <allegro5/base.h>

#ifdef __cplusplus
   extern "C" {
#endif

/* Type: ALLEGRO_USTR
 */
typedef struct _al_tagbstring ALLEGRO_USTR;

/* Type: ALLEGRO_USTR_INFO
 */
typedef struct _al_tagbstring ALLEGRO_USTR_INFO;

#ifndef __al_tagbstring_defined
#define __al_tagbstring_defined
struct _al_tagbstring {
	int mlen;
	int slen;
	unsigned char * data;
};
#endif

/* Creating strings */
AL_FUNC(ALLEGRO_USTR *, al_ustr_new, (const char *s));
AL_FUNC(ALLEGRO_USTR *, al_ustr_new_from_buffer, (const char *s, size_t size));
AL_PRINTFUNC(ALLEGRO_USTR *, al_ustr_newf, (const char *fmt, ...), 1, 2);
AL_FUNC(void, al_ustr_free, (ALLEGRO_USTR *us));
AL_FUNC(const char *, al_cstr, (const ALLEGRO_USTR *us));
AL_FUNC(void, al_ustr_to_buffer, (const ALLEGRO_USTR *us, char *buffer, int size));
AL_FUNC(char *, al_cstr_dup, (const ALLEGRO_USTR *us));
AL_FUNC(ALLEGRO_USTR *, al_ustr_dup, (const ALLEGRO_USTR *us));
AL_FUNC(ALLEGRO_USTR *, al_ustr_dup_substr, (const ALLEGRO_USTR *us,
      int start_pos, int end_pos));

/* Predefined string */
AL_FUNC(const ALLEGRO_USTR *, al_ustr_empty_string, (void));

/* Reference strings */
AL_FUNC(const ALLEGRO_USTR *, al_ref_cstr, (ALLEGRO_USTR_INFO *info, const char *s));
AL_FUNC(const ALLEGRO_USTR *, al_ref_buffer, (ALLEGRO_USTR_INFO *info, const char *s,
      size_t size));
AL_FUNC(const ALLEGRO_USTR *, al_ref_ustr, (ALLEGRO_USTR_INFO *info,
      const ALLEGRO_USTR *us, int start_pos, int end_pos));

/* Sizes and offsets */
AL_FUNC(size_t, al_ustr_size, (const ALLEGRO_USTR *us));
AL_FUNC(size_t, al_ustr_length, (const ALLEGRO_USTR *us));
AL_FUNC(int, al_ustr_offset, (const ALLEGRO_USTR *us, int index));
AL_FUNC(bool, al_ustr_next, (const ALLEGRO_USTR *us, int *pos));
AL_FUNC(bool, al_ustr_prev, (const ALLEGRO_USTR *us, int *pos));

/* Get codepoints */
AL_FUNC(int32_t, al_ustr_get, (const ALLEGRO_USTR *us, int pos));
AL_FUNC(int32_t, al_ustr_get_next, (const ALLEGRO_USTR *us, int *pos));
AL_FUNC(int32_t, al_ustr_prev_get, (const ALLEGRO_USTR *us, int *pos));

/* Insert */
AL_FUNC(bool, al_ustr_insert, (ALLEGRO_USTR *us1, int pos,
      const ALLEGRO_USTR *us2));
AL_FUNC(bool, al_ustr_insert_cstr, (ALLEGRO_USTR *us, int pos,
      const char *us2));
AL_FUNC(size_t, al_ustr_insert_chr, (ALLEGRO_USTR *us, int pos, int32_t c));

/* Append */
AL_FUNC(bool, al_ustr_append, (ALLEGRO_USTR *us1, const ALLEGRO_USTR *us2));
AL_FUNC(bool, al_ustr_append_cstr, (ALLEGRO_USTR *us, const char *s));
AL_FUNC(size_t, al_ustr_append_chr, (ALLEGRO_USTR *us, int32_t c));
AL_PRINTFUNC(bool, al_ustr_appendf, (ALLEGRO_USTR *us, const char *fmt, ...),
      2, 3);
AL_FUNC(bool, al_ustr_vappendf, (ALLEGRO_USTR *us, const char *fmt,
      va_list ap));

/* Remove */
AL_FUNC(bool, al_ustr_remove_chr, (ALLEGRO_USTR *us, int pos));
AL_FUNC(bool, al_ustr_remove_range, (ALLEGRO_USTR *us, int start_pos,
      int end_pos));
AL_FUNC(bool, al_ustr_truncate, (ALLEGRO_USTR *us, int start_pos));
AL_FUNC(bool, al_ustr_ltrim_ws, (ALLEGRO_USTR *us));
AL_FUNC(bool, al_ustr_rtrim_ws, (ALLEGRO_USTR *us));
AL_FUNC(bool, al_ustr_trim_ws, (ALLEGRO_USTR *us));

/* Assign */
AL_FUNC(bool, al_ustr_assign, (ALLEGRO_USTR *us1, const ALLEGRO_USTR *us2));
AL_FUNC(bool, al_ustr_assign_substr, (ALLEGRO_USTR *us1, const ALLEGRO_USTR *us2,
      int start_pos, int end_pos));
AL_FUNC(bool, al_ustr_assign_cstr, (ALLEGRO_USTR *us1, const char *s));

/* Replace */
AL_FUNC(size_t, al_ustr_set_chr, (ALLEGRO_USTR *us, int pos, int32_t c));
AL_FUNC(bool, al_ustr_replace_range, (ALLEGRO_USTR *us1, int start_pos1,
      int end_pos1, const ALLEGRO_USTR *us2));

/* Searching */
AL_FUNC(int, al_ustr_find_chr, (const ALLEGRO_USTR *us, int start_pos,
      int32_t c));
AL_FUNC(int, al_ustr_rfind_chr, (const ALLEGRO_USTR *us, int start_pos,
      int32_t c));
AL_FUNC(int, al_ustr_find_set, (const ALLEGRO_USTR *us, int start_pos,
      const ALLEGRO_USTR *accept));
AL_FUNC(int, al_ustr_find_set_cstr, (const ALLEGRO_USTR *us, int start_pos,
      const char *accept));
AL_FUNC(int, al_ustr_find_cset, (const ALLEGRO_USTR *us, int start_pos,
      const ALLEGRO_USTR *reject));
AL_FUNC(int, al_ustr_find_cset_cstr, (const ALLEGRO_USTR *us, int start_pos,
      const char *reject));
AL_FUNC(int, al_ustr_find_str, (const ALLEGRO_USTR *haystack, int start_pos,
      const ALLEGRO_USTR *needle));
AL_FUNC(int, al_ustr_find_cstr, (const ALLEGRO_USTR *haystack, int start_pos,
      const char *needle));
AL_FUNC(int, al_ustr_rfind_str, (const ALLEGRO_USTR *haystack, int start_pos,
      const ALLEGRO_USTR *needle));
AL_FUNC(int, al_ustr_rfind_cstr, (const ALLEGRO_USTR *haystack, int start_pos,
      const char *needle));
AL_FUNC(bool, al_ustr_find_replace, (ALLEGRO_USTR *us, int start_pos,
      const ALLEGRO_USTR *find, const ALLEGRO_USTR *replace));
AL_FUNC(bool, al_ustr_find_replace_cstr, (ALLEGRO_USTR *us, int start_pos,
      const char *find, const char *replace));

/* Compare */
AL_FUNC(bool, al_ustr_equal, (const ALLEGRO_USTR *us1, const ALLEGRO_USTR *us2));
AL_FUNC(int, al_ustr_compare, (const ALLEGRO_USTR *u, const ALLEGRO_USTR *v));
AL_FUNC(int, al_ustr_ncompare, (const ALLEGRO_USTR *us1, const ALLEGRO_USTR *us2,
      int n));
AL_FUNC(bool, al_ustr_has_prefix,(const ALLEGRO_USTR *u, const ALLEGRO_USTR *v));
AL_FUNC(bool, al_ustr_has_prefix_cstr, (const ALLEGRO_USTR *u, const char *s));
AL_FUNC(bool, al_ustr_has_suffix,(const ALLEGRO_USTR *u, const ALLEGRO_USTR *v));
AL_FUNC(bool, al_ustr_has_suffix_cstr,(const ALLEGRO_USTR *us1, const char *s));

/* Low level UTF-8 functions */
AL_FUNC(size_t, al_utf8_width, (int32_t c));
AL_FUNC(size_t, al_utf8_encode, (char s[], int32_t c));

/* UTF-16 */
AL_FUNC(ALLEGRO_USTR *, al_ustr_new_from_utf16, (uint16_t const *s));
AL_FUNC(size_t, al_ustr_size_utf16, (const ALLEGRO_USTR *us));
AL_FUNC(size_t, al_ustr_encode_utf16, (const ALLEGRO_USTR *us, uint16_t *s, size_t n));
AL_FUNC(size_t, al_utf16_width, (int c));
AL_FUNC(size_t, al_utf16_encode, (uint16_t s[], int32_t c));

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
