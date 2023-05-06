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
    [NativeName("Name", "D2D1_BITMAP_BRUSH_PROPERTIES1")]
    public unsafe partial struct BitmapBrushProperties1
    {
        public BitmapBrushProperties1
        (
            ExtendMode? extendModeX = null,
            ExtendMode? extendModeY = null,
            InterpolationMode? interpolationMode = null
        ) : this()
        {
            if (extendModeX is not null)
            {
                ExtendModeX = extendModeX.Value;
            }

            if (extendModeY is not null)
            {
                ExtendModeY = extendModeY.Value;
            }

            if (interpolationMode is not null)
            {
                InterpolationMode = interpolationMode.Value;
            }
        }


        [NativeName("Type", "D2D1_EXTEND_MODE")]
        [NativeName("Type.Name", "D2D1_EXTEND_MODE")]
        [NativeName("Name", "extendModeX")]
        public ExtendMode ExtendModeX;

        [NativeName("Type", "D2D1_EXTEND_MODE")]
        [NativeName("Type.Name", "D2D1_EXTEND_MODE")]
        [NativeName("Name", "extendModeY")]
        public ExtendMode ExtendModeY;

        [NativeName("Type", "D2D1_INTERPOLATION_MODE")]
        [NativeName("Type.Name", "D2D1_INTERPOLATION_MODE")]
        [NativeName("Name", "interpolationMode")]
        public InterpolationMode InterpolationMode;
    }
}
