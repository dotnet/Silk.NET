// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_COLOR_RGBA")]
    public unsafe partial struct VideoColorRgba
    {
        public VideoColorRgba
        (
            float r = default,
            float g = default,
            float b = default,
            float a = default
        )
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "R")]
        public float R;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "G")]
        public float G;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "B")]
        public float B;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "A")]
        public float A;
    }
}
