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
    [NativeName("Name", "DWRITE_LINE_SPACING")]
    public unsafe partial struct LineSpacing
    {
        public LineSpacing
        (
            LineSpacingMethod? method = null,
            float? height = null,
            float? baseline = null,
            float? leadingBefore = null,
            FontLineGapUsage? fontLineGapUsage = null
        ) : this()
        {
            if (method is not null)
            {
                Method = method.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (baseline is not null)
            {
                Baseline = baseline.Value;
            }

            if (leadingBefore is not null)
            {
                LeadingBefore = leadingBefore.Value;
            }

            if (fontLineGapUsage is not null)
            {
                FontLineGapUsage = fontLineGapUsage.Value;
            }
        }


        [NativeName("Type", "DWRITE_LINE_SPACING_METHOD")]
        [NativeName("Type.Name", "DWRITE_LINE_SPACING_METHOD")]
        [NativeName("Name", "method")]
        public LineSpacingMethod Method;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "height")]
        public float Height;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "baseline")]
        public float Baseline;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "leadingBefore")]
        public float LeadingBefore;

        [NativeName("Type", "DWRITE_FONT_LINE_GAP_USAGE")]
        [NativeName("Type.Name", "DWRITE_FONT_LINE_GAP_USAGE")]
        [NativeName("Name", "fontLineGapUsage")]
        public FontLineGapUsage FontLineGapUsage;
    }
}
