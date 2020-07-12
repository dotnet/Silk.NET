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
    public unsafe struct Vector4f
    {
        public Vector4f
        (
            float x = default,
            float y = default,
            float z = default,
            float w = default
        )
        {
           X = x;
           Y = y;
           Z = z;
           W = w;
        }

/// <summary></summary>
        public float X;
/// <summary></summary>
        public float Y;
/// <summary></summary>
        public float Z;
/// <summary></summary>
        public float W;
    }
}
