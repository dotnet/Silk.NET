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
    [NativeName("Name", "__AnonymousRecord_SDL_gamecontroller_L98_C9")]
    public unsafe partial struct GameControllerButtonBindValueHat
    {
        public GameControllerButtonBindValueHat
        (
            int? hat = null,
            int? hatMask = null
        ) : this()
        {
            if (hat is not null)
            {
                Hat = hat.Value;
            }

            if (hatMask is not null)
            {
                HatMask = hatMask.Value;
            }
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
