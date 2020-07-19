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

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_DISPLAY_MODE")]
    public unsafe partial struct AllegroDisplayMode
    {
        public AllegroDisplayMode
        (
            int width = default,
            int height = default,
            int format = default,
            int refreshRate = default
        )
        {
            Width = width;
            Height = height;
            Format = format;
            RefreshRate = refreshRate;
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "width")]
        public int Width;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "height")]
        public int Height;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "format")]
        public int Format;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refresh_rate")]
        public int RefreshRate;
    }
}
