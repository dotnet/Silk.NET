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
    [NativeName("Name", "D2D1_STROKE_STYLE_PROPERTIES")]
    public unsafe partial struct StrokeStyleProperties
    {
        public StrokeStyleProperties
        (
            CapStyle? startCap = null,
            CapStyle? endCap = null,
            CapStyle? dashCap = null,
            LineJoin? lineJoin = null,
            float? miterLimit = null,
            DashStyle? dashStyle = null,
            float? dashOffset = null
        ) : this()
        {
            if (startCap is not null)
            {
                StartCap = startCap.Value;
            }

            if (endCap is not null)
            {
                EndCap = endCap.Value;
            }

            if (dashCap is not null)
            {
                DashCap = dashCap.Value;
            }

            if (lineJoin is not null)
            {
                LineJoin = lineJoin.Value;
            }

            if (miterLimit is not null)
            {
                MiterLimit = miterLimit.Value;
            }

            if (dashStyle is not null)
            {
                DashStyle = dashStyle.Value;
            }

            if (dashOffset is not null)
            {
                DashOffset = dashOffset.Value;
            }
        }


        [NativeName("Type", "D2D1_CAP_STYLE")]
        [NativeName("Type.Name", "D2D1_CAP_STYLE")]
        [NativeName("Name", "startCap")]
        public CapStyle StartCap;

        [NativeName("Type", "D2D1_CAP_STYLE")]
        [NativeName("Type.Name", "D2D1_CAP_STYLE")]
        [NativeName("Name", "endCap")]
        public CapStyle EndCap;

        [NativeName("Type", "D2D1_CAP_STYLE")]
        [NativeName("Type.Name", "D2D1_CAP_STYLE")]
        [NativeName("Name", "dashCap")]
        public CapStyle DashCap;

        [NativeName("Type", "D2D1_LINE_JOIN")]
        [NativeName("Type.Name", "D2D1_LINE_JOIN")]
        [NativeName("Name", "lineJoin")]
        public LineJoin LineJoin;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "miterLimit")]
        public float MiterLimit;

        [NativeName("Type", "D2D1_DASH_STYLE")]
        [NativeName("Type.Name", "D2D1_DASH_STYLE")]
        [NativeName("Name", "dashStyle")]
        public DashStyle DashStyle;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dashOffset")]
        public float DashOffset;
    }
}
