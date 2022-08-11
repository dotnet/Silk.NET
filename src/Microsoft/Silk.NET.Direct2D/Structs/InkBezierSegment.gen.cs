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
    [NativeName("Name", "D2D1_INK_BEZIER_SEGMENT")]
    public unsafe partial struct InkBezierSegment
    {
        public InkBezierSegment
        (
            InkPoint? point1 = null,
            InkPoint? point2 = null,
            InkPoint? point3 = null
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

            if (point3 is not null)
            {
                Point3 = point3.Value;
            }
        }


        [NativeName("Type", "D2D1_INK_POINT")]
        [NativeName("Type.Name", "D2D1_INK_POINT")]
        [NativeName("Name", "point1")]
        public InkPoint Point1;

        [NativeName("Type", "D2D1_INK_POINT")]
        [NativeName("Type.Name", "D2D1_INK_POINT")]
        [NativeName("Name", "point2")]
        public InkPoint Point2;

        [NativeName("Type", "D2D1_INK_POINT")]
        [NativeName("Type.Name", "D2D1_INK_POINT")]
        [NativeName("Name", "point3")]
        public InkPoint Point3;
    }
}
