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
    [NativeName("Name", "D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES")]
    public unsafe partial struct RadialGradientBrushProperties
    {
        public RadialGradientBrushProperties
        (
            Silk.NET.Maths.Vector2D<float>? center = null,
            Silk.NET.Maths.Vector2D<float>? gradientOriginOffset = null,
            float? radiusX = null,
            float? radiusY = null
        ) : this()
        {
            if (center is not null)
            {
                Center = center.Value;
            }

            if (gradientOriginOffset is not null)
            {
                GradientOriginOffset = gradientOriginOffset.Value;
            }

            if (radiusX is not null)
            {
                RadiusX = radiusX.Value;
            }

            if (radiusY is not null)
            {
                RadiusY = radiusY.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "center")]
        public Silk.NET.Maths.Vector2D<float> Center;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "gradientOriginOffset")]
        public Silk.NET.Maths.Vector2D<float> GradientOriginOffset;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "radiusX")]
        public float RadiusX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "radiusY")]
        public float RadiusY;
    }
}
