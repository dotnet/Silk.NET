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
    [NativeName("Name", "__AnonymousRecord_SDL_gamecontroller_L88_C9")]
    public unsafe partial struct GameControllerHatValue
    {
        public GameControllerHatValue
        (
            int hat = default,
            int hatMask = default
        )
        {
            Hat = hat;
            HatMask = hatMask;
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "hat")]
        public int Hat;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "hat_mask")]
        public int HatMask;
    }
}
