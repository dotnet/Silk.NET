// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct Color4f
    {
        public Color4f
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

/// <summary></summary>
        public float R;
/// <summary></summary>
        public float G;
/// <summary></summary>
        public float B;
/// <summary></summary>
        public float A;
    }
}
