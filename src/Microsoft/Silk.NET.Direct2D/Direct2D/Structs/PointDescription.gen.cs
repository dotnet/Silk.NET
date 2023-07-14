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
    [NativeName("Name", "D2D1_POINT_DESCRIPTION")]
    public unsafe partial struct PointDescription
    {
        public PointDescription
        (
            Silk.NET.Maths.Vector2D<float>? point = null,
            Silk.NET.Maths.Vector2D<float>? unitTangentVector = null,
            uint? endSegment = null,
            uint? endFigure = null,
            float? lengthToEndSegment = null
        ) : this()
        {
            if (point is not null)
            {
                Point = point.Value;
            }

            if (unitTangentVector is not null)
            {
                UnitTangentVector = unitTangentVector.Value;
            }

            if (endSegment is not null)
            {
                EndSegment = endSegment.Value;
            }

            if (endFigure is not null)
            {
                EndFigure = endFigure.Value;
            }

            if (lengthToEndSegment is not null)
            {
                LengthToEndSegment = lengthToEndSegment.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point")]
        public Silk.NET.Maths.Vector2D<float> Point;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "unitTangentVector")]
        public Silk.NET.Maths.Vector2D<float> UnitTangentVector;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "endSegment")]
        public uint EndSegment;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "endFigure")]
        public uint EndFigure;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "lengthToEndSegment")]
        public float LengthToEndSegment;
    }
}
