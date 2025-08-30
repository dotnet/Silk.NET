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
    [NativeName("Name", "PAINT_SWEEP_GRADIENT")]
    public unsafe partial struct PaintSweepGradient
    {
        public PaintSweepGradient
        (
            uint? extendMode = null,
            uint? gradientStopCount = null,
            float? centerX = null,
            float? centerY = null,
            float? startAngle = null,
            float? endAngle = null
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

            if (centerX is not null)
            {
                CenterX = centerX.Value;
            }

            if (centerY is not null)
            {
                CenterY = centerY.Value;
            }

            if (startAngle is not null)
            {
                StartAngle = startAngle.Value;
            }

            if (endAngle is not null)
            {
                EndAngle = endAngle.Value;
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
        [NativeName("Name", "centerX")]
        public float CenterX;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "centerY")]
        public float CenterY;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "startAngle")]
        public float StartAngle;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "endAngle")]
        public float EndAngle;
    }
}
