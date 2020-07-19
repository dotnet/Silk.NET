#ifndef __al_included_allegro5_config_h
#define __al_included_allegro5_config_h

#include <allegro5/file.h>

#ifdef __cplusplus
extern "C" {
#endif

/* Type: ALLEGRO_CONFIG
 */
typedef struct ALLEGRO_CONFIG ALLEGRO_CONFIG;

/* Type: ALLEGRO_CONFIG_SECTION
 */
typedef struct ALLEGRO_CONFIG_SECTION ALLEGRO_CONFIG_SECTION;

/* Type: ALLEGRO_CONFIG_ENTRY
 */
typedef struct ALLEGRO_CONFIG_ENTRY ALLEGRO_CONFIG_ENTRY;

AL_FUNC(ALLEGRO_CONFIG *, al_create_config, (void));
AL_FUNC(void, al_add_config_section, (ALLEGRO_CONFIG *config, const char *name));
AL_FUNC(void, al_set_config_value, (ALLEGRO_CONFIG *config, const char *section, const char *key, const char *value));
AL_FUNC(void, al_add_config_comment, (ALLEGRO_CONFIG *config, const char *section, const char *comment));
AL_FUNC(const char*, al_get_config_value, (const ALLEGRO_CONFIG *config, const char *section, const char *key));
AL_FUNC(ALLEGRO_CONFIG*, al_load_config_file, (const char *filename));
AL_FUNC(ALLEGRO_CONFIG*, al_load_config_file_f, (ALLEGRO_FILE *filename));
AL_FUNC(bool, al_save_config_file, (const char *filename, const ALLEGRO_CONFIG *config));
AL_FUNC(bool, al_save_config_file_f, (ALLEGRO_FILE *file, const ALLEGRO_CONFIG *config));
AL_FUNC(void, al_merge_config_into, (ALLEGRO_CONFIG *master, const ALLEGRO_CONFIG *add));
AL_FUNC(ALLEGRO_CONFIG *, al_merge_config, (const ALLEGRO_CONFIG *cfg1, const ALLEGRO_CONFIG *cfg2));
AL_FUNC(void, al_destroy_config, (ALLEGRO_CONFIG *config));
AL_FUNC(bool, al_remove_config_section, (ALLEGRO_CONFIG *config,
		char const *section));
AL_FUNC(bool, al_remove_config_key, (ALLEGRO_CONFIG *config,
		char const *section, char const *key));

AL_FUNC(char const *, al_get_first_config_section, (ALLEGRO_CONFIG const *config, ALLEGRO_CONFIG_SECTION **iterator));
AL_FUNC(char const *, al_get_next_config_section, (ALLEGRO_CONFIG_SECTION **iterator));
AL_FUNC(char const *, al_get_first_config_entry, (ALLEGRO_CONFIG const *config, char const *section,
	ALLEGRO_CONFIG_ENTRY **iterator));
AL_FUNC(char const *, al_get_next_config_entry, (ALLEGRO_CONFIG_ENTRY **iterator));

#ifdef __cplusplus
}
#endif

#endif
