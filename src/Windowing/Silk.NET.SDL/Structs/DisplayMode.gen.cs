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
    [NativeName("Name", "SDL_DisplayMode")]
    public unsafe partial struct DisplayMode
    {
        public DisplayMode
        (
            uint format = default,
            int w = default,
            int h = default,
            int refreshRate = default,
            void* driverdata = default
        )
        {
            Format = format;
            W = w;
            H = h;
            RefreshRate = refreshRate;
            Driverdata = driverdata;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "format")]
        public uint Format;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "w")]
        public int W;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "h")]
        public int H;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refresh_rate")]
        public int RefreshRate;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "driverdata")]
        public void* Driverdata;
    }
}
