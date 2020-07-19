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
    [NativeName("Name", "ALLEGRO_LOCKED_REGION")]
    public unsafe partial struct AllegroLockedRegion
    {
        public AllegroLockedRegion
        (
            void* data = default,
            int format = default,
            int pitch = default,
            int pixelSize = default
        )
        {
            Data = data;
            Format = format;
            Pitch = pitch;
            PixelSize = pixelSize;
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "format")]
        public int Format;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "pitch")]
        public int Pitch;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "pixel_size")]
        public int PixelSize;
    }
}
