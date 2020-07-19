#ifndef __al_included_allegro5_bitmap_io_h
#define __al_included_allegro5_bitmap_io_h

#include <allegro5/bitmap.h>
#include <allegro5/file.h>

#ifdef __cplusplus
   extern "C" {
#endif

/*
 * Bitmap loader flag
 */
enum {
   ALLEGRO_KEEP_BITMAP_FORMAT       = 0x0002,   /* was a bitmap flag in 5.0 */
   ALLEGRO_NO_PREMULTIPLIED_ALPHA   = 0x0200,   /* was a bitmap flag in 5.0 */
   ALLEGRO_KEEP_INDEX               = 0x0800
};

typedef ALLEGRO_BITMAP *(*ALLEGRO_IIO_LOADER_FUNCTION)(const char *filename, int flags);
typedef ALLEGRO_BITMAP *(*ALLEGRO_IIO_FS_LOADER_FUNCTION)(ALLEGRO_FILE *fp, int flags);
typedef bool (*ALLEGRO_IIO_SAVER_FUNCTION)(const char *filename, ALLEGRO_BITMAP *bitmap);
typedef bool (*ALLEGRO_IIO_FS_SAVER_FUNCTION)(ALLEGRO_FILE *fp, ALLEGRO_BITMAP *bitmap);
typedef bool (*ALLEGRO_IIO_IDENTIFIER_FUNCTION)(ALLEGRO_FILE *f);

AL_FUNC(bool, al_register_bitmap_loader, (const char *ext, ALLEGRO_IIO_LOADER_FUNCTION loader));
AL_FUNC(bool, al_register_bitmap_saver, (const char *ext, ALLEGRO_IIO_SAVER_FUNCTION saver));
AL_FUNC(bool, al_register_bitmap_loader_f, (const char *ext, ALLEGRO_IIO_FS_LOADER_FUNCTION fs_loader));
AL_FUNC(bool, al_register_bitmap_saver_f, (const char *ext, ALLEGRO_IIO_FS_SAVER_FUNCTION fs_saver));
AL_FUNC(bool, al_register_bitmap_identifier, (const char *ext,
   ALLEGRO_IIO_IDENTIFIER_FUNCTION identifier));
AL_FUNC(ALLEGRO_BITMAP *, al_load_bitmap, (const char *filename));
AL_FUNC(ALLEGRO_BITMAP *, al_load_bitmap_flags, (const char *filename, int flags));
AL_FUNC(ALLEGRO_BITMAP *, al_load_bitmap_f, (ALLEGRO_FILE *fp, const char *ident));
AL_FUNC(ALLEGRO_BITMAP *, al_load_bitmap_flags_f, (ALLEGRO_FILE *fp, const char *ident, int flags));
AL_FUNC(bool, al_save_bitmap, (const char *filename, ALLEGRO_BITMAP *bitmap));
AL_FUNC(bool, al_save_bitmap_f, (ALLEGRO_FILE *fp, const char *ident, ALLEGRO_BITMAP *bitmap));
AL_FUNC(char const *, al_identify_bitmap_f, (ALLEGRO_FILE *fp));
AL_FUNC(char const *, al_identify_bitmap, (char const *filename));

#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
