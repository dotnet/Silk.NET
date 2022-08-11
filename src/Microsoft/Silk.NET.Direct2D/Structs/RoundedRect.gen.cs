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
    [NativeName("Name", "D2D1_ROUNDED_RECT")]
    public unsafe partial struct RoundedRect
    {
        public RoundedRect
        (
            Silk.NET.Maths.Box2D<float>? rect = null,
            float? radiusX = null,
            float? radiusY = null
        ) : this()
        {
            if (rect is not null)
            {
                Rect = rect.Value;
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


        [NativeName("Type", "D2D1_RECT_F")]
        [NativeName("Type.Name", "D2D1_RECT_F")]
        [NativeName("Name", "rect")]
        public Silk.NET.Maths.Box2D<float> Rect;

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
