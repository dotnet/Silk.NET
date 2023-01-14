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
    [NativeName("Name", "SDL_HapticDirection")]
    public unsafe partial struct HapticDirection
    {
        public HapticDirection
        (
            byte? type = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "type")]
        public byte Type;
        [NativeName("Type", "Sint32[3]")]
        [NativeName("Type.Name", "Sint32[3]")]
        [NativeName("Name", "dir")]
        public fixed int Dir[3];
    }
}
