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
    [NativeName("Name", "__AnonymousRecord_SDL_rwops_L110_C9")]
    public unsafe partial struct AnonymousRecordSDLRwopsL110C9
    {
        public AnonymousRecordSDLRwopsL110C9
        (
            SdlBool append = default,
            void* h = default,
            AnonymousRecordSDLRwopsL114C13 buffer = default
        )
        {
            Append = append;
            H = h;
            Buffer = buffer;
        }


        [NativeName("Type", "SDL_bool")]
        [NativeName("Type.Name", "SDL_bool")]
        [NativeName("Name", "append")]
        public SdlBool Append;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "h")]
        public void* H;

        [NativeName("Type", "struct (anonymous struct at src/Windowing/Include\\SDL_rwops.h:114:13)")]
        [NativeName("Type.Name", "struct (anonymous struct at src/Windowing/Include\\SDL_rwops.h:114:13)")]
        [NativeName("Name", "buffer")]
        public AnonymousRecordSDLRwopsL114C13 Buffer;
    }
}
