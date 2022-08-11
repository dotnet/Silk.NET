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
    [NativeName("Name", "D2D1_ELLIPSE")]
    public unsafe partial struct Ellipse
    {
        public Ellipse
        (
            Silk.NET.Maths.Vector2D<float>? point = null,
            float? radiusX = null,
            float? radiusY = null
        ) : this()
        {
            if (point is not null)
            {
                Point = point.Value;
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
        [NativeName("Name", "point")]
        public Silk.NET.Maths.Vector2D<float> Point;

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
