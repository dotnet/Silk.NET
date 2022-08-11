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
    [NativeName("Name", "D2D1_GRADIENT_STOP")]
    public unsafe partial struct GradientStop
    {
        public GradientStop
        (
            float? position = null,
            Silk.NET.DXGI.D3Dcolorvalue? color = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (color is not null)
            {
                Color = color.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "position")]
        public float Position;

        [NativeName("Type", "D2D1_COLOR_F")]
        [NativeName("Type.Name", "D2D1_COLOR_F")]
        [NativeName("Name", "color")]
        public Silk.NET.DXGI.D3Dcolorvalue Color;
    }
}
