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
    [NativeName("Name", "D2D1_ARC_SEGMENT")]
    public unsafe partial struct ArcSegment
    {
        public ArcSegment
        (
            Silk.NET.Maths.Vector2D<float>? point = null,
            Silk.NET.Maths.Vector2D<float>? size = null,
            float? rotationAngle = null,
            SweepDirection? sweepDirection = null,
            ArcSize? arcSize = null
        ) : this()
        {
            if (point is not null)
            {
                Point = point.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (rotationAngle is not null)
            {
                RotationAngle = rotationAngle.Value;
            }

            if (sweepDirection is not null)
            {
                SweepDirection = sweepDirection.Value;
            }

            if (arcSize is not null)
            {
                ArcSize = arcSize.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point")]
        public Silk.NET.Maths.Vector2D<float> Point;

        [NativeName("Type", "D2D1_SIZE_F")]
        [NativeName("Type.Name", "D2D1_SIZE_F")]
        [NativeName("Name", "size")]
        public Silk.NET.Maths.Vector2D<float> Size;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "rotationAngle")]
        public float RotationAngle;

        [NativeName("Type", "D2D1_SWEEP_DIRECTION")]
        [NativeName("Type.Name", "D2D1_SWEEP_DIRECTION")]
        [NativeName("Name", "sweepDirection")]
        public SweepDirection SweepDirection;

        [NativeName("Type", "D2D1_ARC_SIZE")]
        [NativeName("Type.Name", "D2D1_ARC_SIZE")]
        [NativeName("Name", "arcSize")]
        public ArcSize ArcSize;
    }
}
