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
    [NativeName("Name", "__AnonymousRecord_SDL_rwops_L136_C9")]
    public unsafe partial struct AnonymousRecordSDLRwopsL136C9
    {
        public AnonymousRecordSDLRwopsL136C9
        (
            void* data1 = default,
            void* data2 = default
        )
        {
            Data1 = data1;
            Data2 = data2;
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data1")]
        public void* Data1;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data2")]
        public void* Data2;
    }
}
