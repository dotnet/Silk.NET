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
    [NativeName("Name", "D2D1_QUADRATIC_BEZIER_SEGMENT")]
    public unsafe partial struct QuadraticBezierSegment
    {
        public QuadraticBezierSegment
        (
            Silk.NET.Maths.Vector2D<float>? point1 = null,
            Silk.NET.Maths.Vector2D<float>? point2 = null
        ) : this()
        {
            if (point1 is not null)
            {
                Point1 = point1.Value;
            }

            if (point2 is not null)
            {
                Point2 = point2.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point1")]
        public Silk.NET.Maths.Vector2D<float> Point1;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point2")]
        public Silk.NET.Maths.Vector2D<float> Point2;
    }
}
