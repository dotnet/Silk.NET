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
    [NativeName("Name", "SDL_DisplayMode")]
    public unsafe partial struct DisplayMode
    {
        public DisplayMode
        (
            uint? format = null,
            int? w = null,
            int? h = null,
            int? refreshRate = null,
            void* driverdata = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (w is not null)
            {
                W = w.Value;
            }

            if (h is not null)
            {
                H = h.Value;
            }

            if (refreshRate is not null)
            {
                RefreshRate = refreshRate.Value;
            }

            if (driverdata is not null)
            {
                Driverdata = driverdata;
            }
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
