// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "SDL_JoystickGUID")]
    public unsafe partial struct JoystickGUID
    {
        [NativeName("Type", "Uint8 [16]")]
        [NativeName("Type.Name", "Uint8 [16]")]
        [NativeName("Name", "data")]
        public fixed byte Data[16];
    }
}
