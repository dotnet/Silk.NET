// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_RGB")]
    public unsafe partial struct Rgb
    {
        public Rgb
        (
            float? red = null,
            float? green = null,
            float? blue = null
        ) : this()
        {
            if (red is not null)
            {
                Red = red.Value;
            }

            if (green is not null)
            {
                Green = green.Value;
            }

            if (blue is not null)
            {
                Blue = blue.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Red")]
        public float Red;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Green")]
        public float Green;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Blue")]
        public float Blue;
    }
}
