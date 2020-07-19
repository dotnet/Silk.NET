// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_FILE_INTERFACE")]
    public unsafe partial struct AllegroFileInterface
    {
        public AllegroFileInterface
        (
            void* fiFopen = default,
            void* fiFclose = default,
            void* fiFread = default,
            void* fiFwrite = default,
            void* fiFflush = default,
            void* fiFtell = default,
            void* fiFseek = default,
            void* fiFeof = default,
            void* fiFerror = default,
            void* fiFerrmsg = default,
            void* fiFclearerr = default,
            void* fiFungetc = default,
            void* fiFsize = default
        )
        {
            FiFopen = fiFopen;
            FiFclose = fiFclose;
            FiFread = fiFread;
            FiFwrite = fiFwrite;
            FiFflush = fiFflush;
            FiFtell = fiFtell;
            FiFseek = fiFseek;
            FiFeof = fiFeof;
            FiFerror = fiFerror;
            FiFerrmsg = fiFerrmsg;
            FiFclearerr = fiFclearerr;
            FiFungetc = fiFungetc;
            FiFsize = fiFsize;
        }


        [NativeName("Type", "void *(*)(const char *, const char *)")]
        [NativeName("Type.Name", "void *(*)(const char *, const char *)")]
        [NativeName("Name", "fi_fopen")]
        public void* FiFopen;

        [NativeName("Type", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_fclose")]
        public void* FiFclose;

        [NativeName("Type", "size_t (*)(ALLEGRO_FILE *, void *, size_t)")]
        [NativeName("Type.Name", "size_t (*)(ALLEGRO_FILE *, void *, size_t)")]
        [NativeName("Name", "fi_fread")]
        public void* FiFread;

        [NativeName("Type", "size_t (*)(ALLEGRO_FILE *, const void *, size_t)")]
        [NativeName("Type.Name", "size_t (*)(ALLEGRO_FILE *, const void *, size_t)")]
        [NativeName("Name", "fi_fwrite")]
        public void* FiFwrite;

        [NativeName("Type", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_fflush")]
        public void* FiFflush;

        [NativeName("Type", "int64_t (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "int64_t (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_ftell")]
        public void* FiFtell;

        [NativeName("Type", "bool (*)(ALLEGRO_FILE *, int64_t, int)")]
        [NativeName("Type.Name", "bool (*)(ALLEGRO_FILE *, int64_t, int)")]
        [NativeName("Name", "fi_fseek")]
        public void* FiFseek;

        [NativeName("Type", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "bool (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_feof")]
        public void* FiFeof;

        [NativeName("Type", "int (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "int (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_ferror")]
        public void* FiFerror;

        [NativeName("Type", "const char *(*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "const char *(*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_ferrmsg")]
        public void* FiFerrmsg;

        [NativeName("Type", "void (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "void (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_fclearerr")]
        public void* FiFclearerr;

        [NativeName("Type", "int (*)(ALLEGRO_FILE *, int)")]
        [NativeName("Type.Name", "int (*)(ALLEGRO_FILE *, int)")]
        [NativeName("Name", "fi_fungetc")]
        public void* FiFungetc;

        [NativeName("Type", "off_t (*)(ALLEGRO_FILE *)")]
        [NativeName("Type.Name", "off_t (*)(ALLEGRO_FILE *)")]
        [NativeName("Name", "fi_fsize")]
        public void* FiFsize;
    }
}
