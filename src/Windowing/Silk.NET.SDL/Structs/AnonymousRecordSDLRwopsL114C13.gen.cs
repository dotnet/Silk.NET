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
    [NativeName("Name", "__AnonymousRecord_SDL_rwops_L114_C13")]
    public unsafe partial struct AnonymousRecordSDLRwopsL114C13
    {
        public AnonymousRecordSDLRwopsL114C13
        (
            void* data = default,
            uint size = default,
            uint left = default
        )
        {
            Data = data;
            Size = size;
            Left = left;
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "size")]
        public uint Size;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "left")]
        public uint Left;
    }
}
