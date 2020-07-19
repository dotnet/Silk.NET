/*         ______   ___    ___
 *        /\  _  \ /\_ \  /\_ \
 *        \ \ \L\ \\//\ \ \//\ \      __     __   _ __   ___
 *         \ \  __ \ \ \ \  \ \ \   /'__`\ /'_ `\/\`'__\/ __`\
 *          \ \ \/\ \ \_\ \_ \_\ \_/\  __//\ \L\ \ \ \//\ \L\ \
 *           \ \_\ \_\/\____\/\____\ \____\ \____ \ \_\\ \____/
 *            \/_/\/_/\/____/\/____/\/____/\/___L\ \/_/ \/___/
 *                                           /\____/
 *                                           \_/__/
 *
 *      File System Hooks.
 *
 *      See readme.txt for copyright information.
 */

#ifndef __al_included_allegro5_fshook_h
#define __al_included_allegro5_fshook_h

#include <allegro5/base.h>
#include <allegro5/file.h>
#include <allegro5/path.h>

#ifdef ALLEGRO_HAVE_SYS_TYPES_H
   #include <sys/types.h>
#else
/* 4 Gig max offsets if sys/types doesn't exist. */
typedef unsigned int off_t;
#endif

#ifdef __cplusplus
   extern "C" {
#endif


/* Type: ALLEGRO_FS_ENTRY
 */
typedef struct ALLEGRO_FS_ENTRY ALLEGRO_FS_ENTRY;

struct ALLEGRO_FS_ENTRY {
   struct ALLEGRO_FS_INTERFACE const *vtable;
};


/* Enum: ALLEGRO_FILE_MODE
 */
typedef enum ALLEGRO_FILE_MODE
{
   ALLEGRO_FILEMODE_READ    = 1,
   ALLEGRO_FILEMODE_WRITE   = 1 << 1,
   ALLEGRO_FILEMODE_EXECUTE = 1 << 2,
   ALLEGRO_FILEMODE_HIDDEN  = 1 << 3,
   ALLEGRO_FILEMODE_ISFILE  = 1 << 4,
   ALLEGRO_FILEMODE_ISDIR   = 1 << 5
} ALLEGRO_FILE_MODE;


#ifndef EOF
   #define EOF    (-1)
#endif


/* Type: ALLEGRO_FS_INTERFACE
 */
typedef struct ALLEGRO_FS_INTERFACE ALLEGRO_FS_INTERFACE;

struct ALLEGRO_FS_INTERFACE {
   AL_METHOD(ALLEGRO_FS_ENTRY *, fs_create_entry,  (const char *path));
   AL_METHOD(void,            fs_destroy_entry,    (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(const char *,    fs_entry_name,       (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(bool,            fs_update_entry,     (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(uint32_t,        fs_entry_mode,       (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(time_t,          fs_entry_atime,      (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(time_t,          fs_entry_mtime,      (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(time_t,          fs_entry_ctime,      (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(off_t,           fs_entry_size,       (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(bool,            fs_entry_exists,     (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(bool,            fs_remove_entry,     (ALLEGRO_FS_ENTRY *e));

   AL_METHOD(bool,            fs_open_directory,   (ALLEGRO_FS_ENTRY *e));
   AL_METHOD(ALLEGRO_FS_ENTRY *, fs_read_directory,(ALLEGRO_FS_ENTRY *e));
   AL_METHOD(bool,            fs_close_directory,  (ALLEGRO_FS_ENTRY *e));

   AL_METHOD(bool,            fs_filename_exists,  (const char *path));
   AL_METHOD(bool,            fs_remove_filename,  (const char *path));
   AL_METHOD(char *,          fs_get_current_directory, (void));
   AL_METHOD(bool,            fs_change_directory, (const char *path));
   AL_METHOD(bool,            fs_make_directory,   (const char *path));

   AL_METHOD(ALLEGRO_FILE *,  fs_open_file,        (ALLEGRO_FS_ENTRY *e,
                                                    const char *mode));
};

AL_FUNC(ALLEGRO_FS_ENTRY *,   al_create_fs_entry,  (const char *path));
AL_FUNC(void,                 al_destroy_fs_entry, (ALLEGRO_FS_ENTRY *e));
AL_FUNC(const char *,         al_get_fs_entry_name,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(bool,                 al_update_fs_entry,  (ALLEGRO_FS_ENTRY *e));
AL_FUNC(uint32_t,             al_get_fs_entry_mode,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(time_t,               al_get_fs_entry_atime,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(time_t,               al_get_fs_entry_mtime,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(time_t,               al_get_fs_entry_ctime,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(off_t,                al_get_fs_entry_size,(ALLEGRO_FS_ENTRY *e));
AL_FUNC(bool,                 al_fs_entry_exists,  (ALLEGRO_FS_ENTRY *e));
AL_FUNC(bool,                 al_remove_fs_entry,  (ALLEGRO_FS_ENTRY *e));

AL_FUNC(bool,                 al_open_directory,   (ALLEGRO_FS_ENTRY *e));
AL_FUNC(ALLEGRO_FS_ENTRY *,   al_read_directory,   (ALLEGRO_FS_ENTRY *e));
AL_FUNC(bool,                 al_close_directory,  (ALLEGRO_FS_ENTRY *e));

AL_FUNC(bool,                 al_filename_exists,  (const char *path));
AL_FUNC(bool,                 al_remove_filename,  (const char *path));
AL_FUNC(char *,               al_get_current_directory, (void));
AL_FUNC(bool,                 al_change_directory, (const char *path));
AL_FUNC(bool,                 al_make_directory,   (const char *path));

AL_FUNC(ALLEGRO_FILE *,       al_open_fs_entry,    (ALLEGRO_FS_ENTRY *e,
                                                    const char *mode));



/* Helper function for iterating over a directory using a callback. */

/* Type: ALLEGRO_FOR_EACH_FS_ENTRY_RESULT
 */
typedef enum ALLEGRO_FOR_EACH_FS_ENTRY_RESULT {
   ALLEGRO_FOR_EACH_FS_ENTRY_ERROR = -1,
   ALLEGRO_FOR_EACH_FS_ENTRY_OK    =  0,
   ALLEGRO_FOR_EACH_FS_ENTRY_SKIP  =  1,
   ALLEGRO_FOR_EACH_FS_ENTRY_STOP  =  2
} ALLEGRO_FOR_EACH_FS_ENTRY_RESULT;

AL_FUNC(int,  al_for_each_fs_entry, (ALLEGRO_FS_ENTRY *dir,
                                     int (*callback)(ALLEGRO_FS_ENTRY *entry, void *extra),
                                     void *extra));


/* Thread-local state. */
AL_FUNC(const ALLEGRO_FS_INTERFACE *, al_get_fs_interface, (void));
AL_FUNC(void, al_set_fs_interface, (const ALLEGRO_FS_INTERFACE *vtable));
AL_FUNC(void, al_set_standard_fs_interface, (void));


#ifdef __cplusplus
   }
#endif

#endif

/* vim: set sts=3 sw=3 et: */
