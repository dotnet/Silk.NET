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
    [NativeName("Name", "D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES")]
    public unsafe partial struct LinearGradientBrushProperties
    {
        public LinearGradientBrushProperties
        (
            Silk.NET.Maths.Vector2D<float>? startPoint = null,
            Silk.NET.Maths.Vector2D<float>? endPoint = null
        ) : this()
        {
            if (startPoint is not null)
            {
                StartPoint = startPoint.Value;
            }

            if (endPoint is not null)
            {
                EndPoint = endPoint.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "startPoint")]
        public Silk.NET.Maths.Vector2D<float> StartPoint;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "endPoint")]
        public Silk.NET.Maths.Vector2D<float> EndPoint;
    }
}
