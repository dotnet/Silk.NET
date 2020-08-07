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
    [NativeName("Name", "__AnonymousRecord_SDL_rwops_L130_C9")]
    public unsafe partial struct AnonymousRecordSDLRwopsL130C9
    {
        public AnonymousRecordSDLRwopsL130C9
        (
            byte* @base = default,
            byte* here = default,
            byte* stop = default
        )
        {
            Base = @base;
            Here = here;
            Stop = stop;
        }


        [NativeName("Type", "Uint8 *")]
        [NativeName("Type.Name", "Uint8 *")]
        [NativeName("Name", "base")]
        public byte* Base;

        [NativeName("Type", "Uint8 *")]
        [NativeName("Type.Name", "Uint8 *")]
        [NativeName("Name", "here")]
        public byte* Here;

        [NativeName("Type", "Uint8 *")]
        [NativeName("Type.Name", "Uint8 *")]
        [NativeName("Name", "stop")]
        public byte* Stop;
    }
}
