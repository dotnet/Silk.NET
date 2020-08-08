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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_RWops")]
    public unsafe partial struct RWops
    {
        public RWops
        (
            void* size = default,
            void* seek = default,
            void* read = default,
            void* write = default,
            void* close = default,
            uint type = default,
            AnonymousRecordSDLRwopsL94C5 hidden = default
        )
        {
            Size = size;
            Seek = seek;
            Read = read;
            Write = write;
            Close = close;
            Type = type;
            Hidden = hidden;
        }


        [NativeName("Type", "Sint64 (*)(struct SDL_RWops *) __attribute__((cdecl))")]
        [NativeName("Type.Name", "Sint64 (*)(struct SDL_RWops *) __attribute__((cdecl))")]
        [NativeName("Name", "size")]
        public void* Size;

        [NativeName("Type", "Sint64 (*)(struct SDL_RWops *, Sint64, int) __attribute__((cdecl))")]
        [NativeName("Type.Name", "Sint64 (*)(struct SDL_RWops *, Sint64, int) __attribute__((cdecl))")]
        [NativeName("Name", "seek")]
        public void* Seek;

        [NativeName("Type", "size_t (*)(struct SDL_RWops *, void *, size_t, size_t) __attribute__((cdecl))")]
        [NativeName("Type.Name", "size_t (*)(struct SDL_RWops *, void *, size_t, size_t) __attribute__((cdecl))")]
        [NativeName("Name", "read")]
        public void* Read;

        [NativeName("Type", "size_t (*)(struct SDL_RWops *, const void *, size_t, size_t) __attribute__((cdecl))")]
        [NativeName("Type.Name", "size_t (*)(struct SDL_RWops *, const void *, size_t, size_t) __attribute__((cdecl))")]
        [NativeName("Name", "write")]
        public void* Write;

        [NativeName("Type", "int (*)(struct SDL_RWops *) __attribute__((cdecl))")]
        [NativeName("Type.Name", "int (*)(struct SDL_RWops *) __attribute__((cdecl))")]
        [NativeName("Name", "close")]
        public void* Close;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "union (anonymous union at build/submodules/SDL-mirror/include\\SDL_rwops.h:94:5)")]
        [NativeName("Type.Name", "union (anonymous union at build/submodules/SDL-mirror/include\\SDL_rwops.h:94:5)")]
        [NativeName("Name", "hidden")]
        public AnonymousRecordSDLRwopsL94C5 Hidden;
    }
}
