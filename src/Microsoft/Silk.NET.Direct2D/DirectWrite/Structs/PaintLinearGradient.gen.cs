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
    [NativeName("Name", "PAINT_LINEAR_GRADIENT")]
    public unsafe partial struct PaintLinearGradient
    {
        public PaintLinearGradient
        (
            uint? extendMode = null,
            uint? gradientStopCount = null,
            float? x0 = null,
            float? y0 = null,
            float? x1 = null,
            float? y1 = null,
            float? x2 = null,
            float? y2 = null
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

            if (x1 is not null)
            {
                X1 = x1.Value;
            }

            if (y1 is not null)
            {
                Y1 = y1.Value;
            }

            if (x2 is not null)
            {
                X2 = x2.Value;
            }

            if (y2 is not null)
            {
                Y2 = y2.Value;
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
        [NativeName("Name", "x1")]
        public float X1;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y1")]
        public float Y1;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x2")]
        public float X2;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y2")]
        public float Y2;
    }
}
