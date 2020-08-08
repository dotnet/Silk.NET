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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_SDL_rwops_L94_C5")]
    public unsafe partial struct AnonymousRecordSDLRwopsL94C5
    {
        public AnonymousRecordSDLRwopsL94C5
        (
            AnonymousRecordSDLRwopsL110C9 windowsio = default,
            AnonymousRecordSDLRwopsL130C9 mem = default,
            AnonymousRecordSDLRwopsL136C9 unknown = default
        )
        {
            Windowsio = windowsio;
            Mem = mem;
            Unknown = unknown;
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:110:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:110:9)")]
        [NativeName("Name", "windowsio")]
        public AnonymousRecordSDLRwopsL110C9 Windowsio;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:130:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:130:9)")]
        [NativeName("Name", "mem")]
        public AnonymousRecordSDLRwopsL130C9 Mem;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:136:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_rwops.h:136:9)")]
        [NativeName("Name", "unknown")]
        public AnonymousRecordSDLRwopsL136C9 Unknown;
    }
}
