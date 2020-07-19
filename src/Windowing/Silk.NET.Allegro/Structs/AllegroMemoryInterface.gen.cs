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
    [NativeName("Name", "ALLEGRO_MEMORY_INTERFACE")]
    public unsafe partial struct AllegroMemoryInterface
    {
        public AllegroMemoryInterface
        (
            void* miMalloc = default,
            void* miFree = default,
            void* miRealloc = default,
            void* miCalloc = default
        )
        {
            MiMalloc = miMalloc;
            MiFree = miFree;
            MiRealloc = miRealloc;
            MiCalloc = miCalloc;
        }


        [NativeName("Type", "void *(*)(size_t, int, const char *, const char *)")]
        [NativeName("Type.Name", "void *(*)(size_t, int, const char *, const char *)")]
        [NativeName("Name", "mi_malloc")]
        public void* MiMalloc;

        [NativeName("Type", "void (*)(void *, int, const char *, const char *)")]
        [NativeName("Type.Name", "void (*)(void *, int, const char *, const char *)")]
        [NativeName("Name", "mi_free")]
        public void* MiFree;

        [NativeName("Type", "void *(*)(void *, size_t, int, const char *, const char *)")]
        [NativeName("Type.Name", "void *(*)(void *, size_t, int, const char *, const char *)")]
        [NativeName("Name", "mi_realloc")]
        public void* MiRealloc;

        [NativeName("Type", "void *(*)(size_t, size_t, int, const char *, const char *)")]
        [NativeName("Type.Name", "void *(*)(size_t, size_t, int, const char *, const char *)")]
        [NativeName("Name", "mi_calloc")]
        public void* MiCalloc;
    }
}
