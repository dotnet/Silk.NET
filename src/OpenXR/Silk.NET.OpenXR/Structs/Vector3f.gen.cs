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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVector3f")]
    public unsafe partial struct Vector3f
    {
        public Vector3f
        (
            float? x = null,
            float? y = null,
            float? z = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (z is not null)
            {
                Z = z.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "z")]
        public float Z;
    }
}
