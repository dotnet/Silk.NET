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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "PAINT_RADIAL_GRADIENT")]
    public unsafe partial struct PaintRadialGradient
    {
        public PaintRadialGradient
        (
            uint? extendMode = null,
            uint? gradientStopCount = null,
            float? x0 = null,
            float? y0 = null,
            float? radius0 = null,
            float? x1 = null,
            float? y1 = null,
            float? radius1 = null
        ) : this()
        {
            if (extendMode is not null)
            {
                ExtendMode = extendMode.Value;
            }

            if (gradientStopCount is not null)
            {
                GradientStopCount = gradientStopCount.Value;
            }

            if (x0 is not null)
            {
                X0 = x0.Value;
            }

            if (y0 is not null)
            {
                Y0 = y0.Value;
            }

            if (radius0 is not null)
            {
                Radius0 = radius0.Value;
            }

            if (x1 is not null)
            {
                X1 = x1.Value;
            }

            if (y1 is not null)
            {
                Y1 = y1.Value;
            }

            if (radius1 is not null)
            {
                Radius1 = radius1.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "extendMode")]
        public uint ExtendMode;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "gradientStopCount")]
        public uint GradientStopCount;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x0")]
        public float X0;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y0")]
        public float Y0;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius0")]
        public float Radius0;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x1")]
        public float X1;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y1")]
        public float Y1;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius1")]
        public float Radius1;
    }
}
