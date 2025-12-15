// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_SDL_gamecontroller_L94_C5")]
    public unsafe partial struct GameControllerButtonBindValue
    {
        public GameControllerButtonBindValue
        (
            int? button = null,
            int? axis = null,
            GameControllerButtonBindValueHat? hat = null
        ) : this()
        {
            if (button is not null)
            {
                Button = button.Value;
            }

            if (axis is not null)
            {
                Axis = axis.Value;
            }

            if (hat is not null)
            {
                Hat = hat.Value;
            }
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
        [NativeName("Type", "struct (unnamed struct at build/submodules/SDL/include\\SDL_gamecontroller.h:98:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at build/submodules/SDL/include\\SDL_gamecontroller.h:98:9)")]
        [NativeName("Name", "hat")]
        public GameControllerButtonBindValueHat Hat;
    }
}
