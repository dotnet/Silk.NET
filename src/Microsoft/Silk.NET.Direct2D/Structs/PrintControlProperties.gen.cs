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
    [NativeName("Name", "D2D1_PRINT_CONTROL_PROPERTIES")]
    public unsafe partial struct PrintControlProperties
    {
        public PrintControlProperties
        (
            PrintFontSubsetMode? fontSubset = null,
            float? rasterDPI = null,
            ColorSpace? colorSpace = null
        ) : this()
        {
            if (fontSubset is not null)
            {
                FontSubset = fontSubset.Value;
            }

            if (rasterDPI is not null)
            {
                RasterDPI = rasterDPI.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }
        }


        [NativeName("Type", "D2D1_PRINT_FONT_SUBSET_MODE")]
        [NativeName("Type.Name", "D2D1_PRINT_FONT_SUBSET_MODE")]
        [NativeName("Name", "fontSubset")]
        public PrintFontSubsetMode FontSubset;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "rasterDPI")]
        public float RasterDPI;

        [NativeName("Type", "D2D1_COLOR_SPACE")]
        [NativeName("Type.Name", "D2D1_COLOR_SPACE")]
        [NativeName("Name", "colorSpace")]
        public ColorSpace ColorSpace;
    }
}
