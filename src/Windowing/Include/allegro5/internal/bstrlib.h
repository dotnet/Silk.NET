/*
 * This source file has had its exported symbols prefixed with _al_ or _AL_
 * for the Allegro project.
 */

/*
 * This source file is part of the _al_bstring string library.  This code was
 * written by Paul Hsieh in 2002-2008, and is covered by the BSD open source 
 * license and the GPL. Refer to the accompanying documentation for details 
 * on usage and license.
 */

/*
 * bstrlib.c
 *
 * This file is the core module for implementing the _al_bstring functions.
 */

#ifndef _AL_BSTRLIB_INCLUDE
#define _AL_BSTRLIB_INCLUDE

#ifdef __cplusplus
extern "C" {
#endif

#include <stdarg.h>
#include <string.h>
#include <limits.h>
#include <ctype.h>

#if !defined (BSTRLIB_VSNP_OK) && !defined (BSTRLIB_NOVSNP)
# if defined (__TURBOC__) && !defined (__BORLANDC__)
#  define BSTRLIB_NOVSNP
# endif
#endif

#define _AL_BSTR_ERR (-1)
#define _AL_BSTR_OK (0)
#define _AL_BSTR_BS_BUFF_LENGTH_GET (0)

typedef struct _al_tagbstring * _al_bstring;
typedef const struct _al_tagbstring * _al_const_bstring;

/* Copy functions */
#define _al_cstr2bstr _al_bfromcstr
extern _al_bstring _al_bfromcstr (const char * str);
extern _al_bstring _al_bfromcstralloc (int mlen, const char * str);
extern _al_bstring _al_blk2bstr (const void * blk, int len);
extern char * _al_bstr2cstr (_al_const_bstring s, char z);
extern int _al_bcstrfree (char * s);
extern _al_bstring _al_bstrcpy (_al_const_bstring b1);
extern int _al_bassign (_al_bstring a, _al_const_bstring b);
extern int _al_bassignmidstr (_al_bstring a, _al_const_bstring b, int left, int len);
extern int _al_bassigncstr (_al_bstring a, const char * str);
extern int _al_bassignblk (_al_bstring a, const void * s, int len);

/* Destroy function */
extern int _al_bdestroy (_al_bstring b);

/* Space allocation hinting functions */
extern int _al_balloc (_al_bstring s, int len);
extern int _al_ballocmin (_al_bstring b, int len);

/* Substring extraction */
extern _al_bstring _al_bmidstr (_al_const_bstring b, int left, int len);

/* Various standard manipulations */
extern int _al_bconcat (_al_bstring b0, _al_const_bstring b1);
extern int _al_bconchar (_al_bstring b0, char c);
extern int _al_bcatcstr (_al_bstring b, const char * s);
extern int _al_bcatblk (_al_bstring b, const void * s, int len);
extern int _al_binsert (_al_bstring s1, int pos, _al_const_bstring s2, unsigned char fill);
extern int _al_binsertch (_al_bstring s1, int pos, int len, unsigned char fill);
extern int _al_breplace (_al_bstring b1, int pos, int len, _al_const_bstring b2, unsigned char fill);
extern int _al_bdelete (_al_bstring s1, int pos, int len);
extern int _al_bsetstr (_al_bstring b0, int pos, _al_const_bstring b1, unsigned char fill);
extern int _al_btrunc (_al_bstring b, int n);

/* Scan/search functions */
extern int _al_bstricmp (_al_const_bstring b0, _al_const_bstring b1);
extern int _al_bstrnicmp (_al_const_bstring b0, _al_const_bstring b1, int n);
extern int _al_biseqcaseless (_al_const_bstring b0, _al_const_bstring b1);
extern int _al_bisstemeqcaselessblk (_al_const_bstring b0, const void * blk, int len);
extern int _al_biseq (_al_const_bstring b0, _al_const_bstring b1);
extern int _al_bisstemeqblk (_al_const_bstring b0, const void * blk, int len);
extern int _al_biseqcstr (_al_const_bstring b, const char * s);
extern int _al_biseqcstrcaseless (_al_const_bstring b, const char * s);
extern int _al_bstrcmp (_al_const_bstring b0, _al_const_bstring b1);
extern int _al_bstrncmp (_al_const_bstring b0, _al_const_bstring b1, int n);
extern int _al_binstr (_al_const_bstring s1, int pos, _al_const_bstring s2);
extern int _al_binstrr (_al_const_bstring s1, int pos, _al_const_bstring s2);
extern int _al_binstrcaseless (_al_const_bstring s1, int pos, _al_const_bstring s2);
extern int _al_binstrrcaseless (_al_const_bstring s1, int pos, _al_const_bstring s2);
extern int _al_bstrchrp (_al_const_bstring b, int c, int pos);
extern int _al_bstrrchrp (_al_const_bstring b, int c, int pos);
#define _al_bstrchr(b,c) _al_bstrchrp ((b), (c), 0)
#define _al_bstrrchr(b,c) _al_bstrrchrp ((b), (c), _al_blength(b)-1)
extern int _al_binchr (_al_const_bstring b0, int pos, _al_const_bstring b1);
extern int _al_binchrr (_al_const_bstring b0, int pos, _al_const_bstring b1);
extern int _al_bninchr (_al_const_bstring b0, int pos, _al_const_bstring b1);
extern int _al_bninchrr (_al_const_bstring b0, int pos, _al_const_bstring b1);
extern int _al_bfindreplace (_al_bstring b, _al_const_bstring find, _al_const_bstring repl, int pos);
extern int _al_bfindreplacecaseless (_al_bstring b, _al_const_bstring find, _al_const_bstring repl, int pos);

/* List of string container functions */
struct _al_bstrList {
    int qty, mlen;
    _al_bstring * entry;
};
extern struct _al_bstrList * _al_bstrListCreate (void);
extern int _al_bstrListDestroy (struct _al_bstrList * sl);
extern int _al_bstrListAlloc (struct _al_bstrList * sl, int msz);
extern int _al_bstrListAllocMin (struct _al_bstrList * sl, int msz);

/* String split and join functions */
extern struct _al_bstrList * _al_bsplit (_al_const_bstring str, unsigned char splitChar);
extern struct _al_bstrList * _al_bsplits (_al_const_bstring str, _al_const_bstring splitStr);
extern struct _al_bstrList * _al_bsplitstr (_al_const_bstring str, _al_const_bstring splitStr);
extern _al_bstring _al_bjoin (const struct _al_bstrList * bl, _al_const_bstring sep);
extern int _al_bsplitcb (_al_const_bstring str, unsigned char splitChar, int pos,
	int (* cb) (void * parm, int ofs, int len), void * parm);
extern int _al_bsplitscb (_al_const_bstring str, _al_const_bstring splitStr, int pos,
	int (* cb) (void * parm, int ofs, int len), void * parm);
extern int _al_bsplitstrcb (_al_const_bstring str, _al_const_bstring splitStr, int pos,
	int (* cb) (void * parm, int ofs, int len), void * parm);

/* Miscellaneous functions */
extern int _al_bpattern (_al_bstring b, int len);
extern int _al_btoupper (_al_bstring b);
extern int _al_btolower (_al_bstring b);
extern int _al_bltrimws (_al_bstring b);
extern int _al_brtrimws (_al_bstring b);
extern int _al_btrimws (_al_bstring b);

#if !defined (BSTRLIB_NOVSNP)
extern _al_bstring _al_bformat (const char * fmt, ...);
extern int _al_bformata (_al_bstring b, const char * fmt, ...);
extern int _al_bassignformat (_al_bstring b, const char * fmt, ...);
extern int _al_bvcformata (_al_bstring b, int count, const char * fmt, va_list arglist);

#define _al_bvformata(ret, b, fmt, lastarg) { \
_al_bstring bstrtmp_b = (b); \
const char * bstrtmp_fmt = (fmt); \
int bstrtmp_r = _AL_BSTR_ERR, bstrtmp_sz = 16; \
	for (;;) { \
		va_list bstrtmp_arglist; \
		va_start (bstrtmp_arglist, lastarg); \
		bstrtmp_r = _al_bvcformata (bstrtmp_b, bstrtmp_sz, bstrtmp_fmt, bstrtmp_arglist); \
		va_end (bstrtmp_arglist); \
		if (bstrtmp_r >= 0) { /* Everything went ok */ \
			bstrtmp_r = _AL_BSTR_OK; \
			break; \
		} else if (-bstrtmp_r <= bstrtmp_sz) { /* A real error? */ \
			bstrtmp_r = _AL_BSTR_ERR; \
			break; \
		} \
		bstrtmp_sz = -bstrtmp_r; /* Doubled or target size */ \
	} \
	ret = bstrtmp_r; \
}

#endif

typedef int (*_al_bNgetc) (void *parm);
typedef size_t (* _al_bNread) (void *buff, size_t elsize, size_t nelem, void *parm);

/* Input functions */
extern _al_bstring _al_bgets (_al_bNgetc getcPtr, void * parm, char terminator);
extern _al_bstring _al_bread (_al_bNread readPtr, void * parm);
extern int _al_bgetsa (_al_bstring b, _al_bNgetc getcPtr, void * parm, char terminator);
extern int _al_bassigngets (_al_bstring b, _al_bNgetc getcPtr, void * parm, char terminator);
extern int _al_breada (_al_bstring b, _al_bNread readPtr, void * parm);

/* Stream functions */
extern struct _al_bStream * _al_bsopen (_al_bNread readPtr, void * parm);
extern void * _al_bsclose (struct _al_bStream * s);
extern int _al_bsbufflength (struct _al_bStream * s, int sz);
extern int _al_bsreadln (_al_bstring b, struct _al_bStream * s, char terminator);
extern int _al_bsreadlns (_al_bstring r, struct _al_bStream * s, _al_const_bstring term);
extern int _al_bsread (_al_bstring b, struct _al_bStream * s, int n);
extern int _al_bsreadlna (_al_bstring b, struct _al_bStream * s, char terminator);
extern int _al_bsreadlnsa (_al_bstring r, struct _al_bStream * s, _al_const_bstring term);
extern int _al_bsreada (_al_bstring b, struct _al_bStream * s, int n);
extern int _al_bsunread (struct _al_bStream * s, _al_const_bstring b);
extern int _al_bspeek (_al_bstring r, const struct _al_bStream * s);
extern int _al_bssplitscb (struct _al_bStream * s, _al_const_bstring splitStr, 
	int (* cb) (void * parm, int ofs, _al_const_bstring entry), void * parm);
extern int _al_bssplitstrcb (struct _al_bStream * s, _al_const_bstring splitStr, 
	int (* cb) (void * parm, int ofs, _al_const_bstring entry), void * parm);
extern int _al_bseof (const struct _al_bStream * s);

#ifndef __al_tagbstring_defined
#define __al_tagbstring_defined
struct _al_tagbstring {
	int mlen;
	int slen;
	unsigned char * data;
};
#endif

/* Accessor macros */
#define _al_blengthe(b, e)      (((b) == (void *)0 || (b)->slen < 0) ? (int)(e) : ((b)->slen))
#define _al_blength(b)          (_al_blengthe ((b), 0))
#define _al_bdataofse(b, o, e)  (((b) == (void *)0 || (b)->data == (void*)0) ? (char *)(e) : ((char *)(b)->data) + (o))
#define _al_bdataofs(b, o)      (_al_bdataofse ((b), (o), (void *)0))
#define _al_bdatae(b, e)        (_al_bdataofse (b, 0, e))
#define _al_bdata(b)            (_al_bdataofs (b, 0))
#define _al_bchare(b, p, e)     ((((unsigned)(p)) < (unsigned)_al_blength(b)) ? ((b)->data[(p)]) : (e))
#define _al_bchar(b, p)         _al_bchare ((b), (p), '\0')

/* Static constant string initialization macro */
#define _al_bsStaticMlen(q,m)   {(m), (int) sizeof(q)-1, (unsigned char *) ("" q "")}
#if defined(_MSC_VER)
# define _al_bsStatic(q)        _al_bsStaticMlen(q,-32)
#endif
#ifndef _al_bsStatic
# define _al_bsStatic(q)        _al_bsStaticMlen(q,-__LINE__)
#endif

/* Static constant block parameter pair */
#define _al_bsStaticBlkParms(q) ((void *)("" q "")), ((int) sizeof(q)-1)

/* Reference building macros */
#define _al_cstr2tbstr _al_btfromcstr
#define _al_btfromcstr(t,s) {                                            \
    (t).data = (unsigned char *) (s);                                \
    (t).slen = ((t).data) ? ((int) (strlen) ((char *)(t).data)) : 0; \
    (t).mlen = -1;                                                   \
}
#define _al_blk2tbstr(t,s,l) {            \
    (t).data = (unsigned char *) (s); \
    (t).slen = l;                     \
    (t).mlen = -1;                    \
}
#define _al_btfromblk(t,s,l) _al_blk2tbstr(t,s,l)
#define _al_bmid2tbstr(t,b,p,l) {                                                \
    _al_const_bstring bstrtmp_s = (b);                                           \
    if (bstrtmp_s && bstrtmp_s->data && bstrtmp_s->slen >= 0) {              \
        int bstrtmp_left = (p);                                              \
        int bstrtmp_len  = (l);                                              \
        if (bstrtmp_left < 0) {                                              \
            bstrtmp_len += bstrtmp_left;                                     \
            bstrtmp_left = 0;                                                \
        }                                                                    \
        if (bstrtmp_len > bstrtmp_s->slen - bstrtmp_left)                    \
            bstrtmp_len = bstrtmp_s->slen - bstrtmp_left;                    \
        if (bstrtmp_len <= 0) {                                              \
            (t).data = (unsigned char *)"";                                  \
            (t).slen = 0;                                                    \
        } else {                                                             \
            (t).data = bstrtmp_s->data + bstrtmp_left;                       \
            (t).slen = bstrtmp_len;                                          \
        }                                                                    \
    } else {                                                                 \
        (t).data = (unsigned char *)"";                                      \
        (t).slen = 0;                                                        \
    }                                                                        \
    (t).mlen = -__LINE__;                                                    \
}
#define _al_btfromblkltrimws(t,s,l) {                                            \
    int bstrtmp_idx = 0, bstrtmp_len = (l);                                  \
    unsigned char * bstrtmp_s = (s);                                         \
    if (bstrtmp_s && bstrtmp_len >= 0) {                                     \
        for (; bstrtmp_idx < bstrtmp_len; bstrtmp_idx++) {                   \
            if (!isspace (bstrtmp_s[bstrtmp_idx])) break;                    \
        }                                                                    \
    }                                                                        \
    (t).data = bstrtmp_s + bstrtmp_idx;                                      \
    (t).slen = bstrtmp_len - bstrtmp_idx;                                    \
    (t).mlen = -__LINE__;                                                    \
}
#define _al_btfromblkrtrimws(t,s,l) {                                            \
    int bstrtmp_len = (l) - 1;                                               \
    unsigned char * bstrtmp_s = (s);                                         \
    if (bstrtmp_s && bstrtmp_len >= 0) {                                     \
        for (; bstrtmp_len >= 0; bstrtmp_len--) {                            \
            if (!isspace (bstrtmp_s[bstrtmp_len])) break;                    \
        }                                                                    \
    }                                                                        \
    (t).data = bstrtmp_s;                                                    \
    (t).slen = bstrtmp_len + 1;                                              \
    (t).mlen = -__LINE__;                                                    \
}
#define _al_btfromblktrimws(t,s,l) {                                             \
    int bstrtmp_idx = 0, bstrtmp_len = (l) - 1;                              \
    unsigned char * bstrtmp_s = (s);                                         \
    if (bstrtmp_s && bstrtmp_len >= 0) {                                     \
        for (; bstrtmp_idx <= bstrtmp_len; bstrtmp_idx++) {                  \
            if (!isspace (bstrtmp_s[bstrtmp_idx])) break;                    \
        }                                                                    \
        for (; bstrtmp_len >= bstrtmp_idx; bstrtmp_len--) {                  \
            if (!isspace (bstrtmp_s[bstrtmp_len])) break;                    \
        }                                                                    \
    }                                                                        \
    (t).data = bstrtmp_s + bstrtmp_idx;                                      \
    (t).slen = bstrtmp_len + 1 - bstrtmp_idx;                                \
    (t).mlen = -__LINE__;                                                    \
}

/* Write protection macros */
#define _al_bwriteprotect(t)     { if ((t).mlen >=  0) (t).mlen = -1; }
#define _al_bwriteallow(t)       { if ((t).mlen == -1) (t).mlen = (t).slen + ((t).slen == 0); }
#define _al_biswriteprotected(t) ((t).mlen <= 0)

#ifdef __cplusplus
}
#endif

#endif
