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
    [NativeName("Name", "SDL_GameControllerButtonBind")]
    public unsafe partial struct GameControllerButtonBind
    {
        public GameControllerButtonBind
        (
            GameControllerBindType? bindType = null,
            GameControllerButtonBindValue? value = null
        ) : this()
        {
            if (bindType is not null)
            {
                BindType = bindType.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "SDL_GameControllerBindType")]
        [NativeName("Type.Name", "SDL_GameControllerBindType")]
        [NativeName("Name", "bindType")]
        public GameControllerBindType BindType;

        [NativeName("Type", "union (unnamed union at build/submodules/SDL/include\\SDL_gamecontroller.h:94:5)")]
        [NativeName("Type.Name", "union (unnamed union at build/submodules/SDL/include\\SDL_gamecontroller.h:94:5)")]
        [NativeName("Name", "value")]
        public GameControllerButtonBindValue Value;
    }
}
