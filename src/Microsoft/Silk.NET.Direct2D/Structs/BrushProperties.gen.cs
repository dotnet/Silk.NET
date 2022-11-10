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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BRUSH_PROPERTIES")]
    public unsafe partial struct BrushProperties
    {
        public BrushProperties
        (
            float? opacity = null,
            Silk.NET.Maths.Matrix3X2<float>? transform = null
        ) : this()
        {
            if (opacity is not null)
            {
                Opacity = opacity.Value;
            }

            if (transform is not null)
            {
                Transform = transform.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "opacity")]
        public float Opacity;

        [NativeName("Type", "D2D1_MATRIX_3X2_F")]
        [NativeName("Type.Name", "D2D1_MATRIX_3X2_F")]
        [NativeName("Name", "transform")]
        public Silk.NET.Maths.Matrix3X2<float> Transform;
    }
}
