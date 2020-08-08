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
    [NativeName("Name", "__AnonymousRecord_SDL_gamecontroller_L84_C5")]
    public unsafe partial struct GameControllerBindValue
    {
        public GameControllerBindValue
        (
            int button = default,
            int axis = default,
            GameControllerHatValue hat = default
        )
        {
            Button = button;
            Axis = axis;
            Hat = hat;
        }


        [FieldOffset(0)]
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "button")]
        public int Button;

        [FieldOffset(0)]
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "axis")]
        public int Axis;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_gamecontroller.h:88:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at build/submodules/SDL-mirror/include\\SDL_gamecontroller.h:88:9)")]
        [NativeName("Name", "hat")]
        public GameControllerHatValue Hat;
    }
}
