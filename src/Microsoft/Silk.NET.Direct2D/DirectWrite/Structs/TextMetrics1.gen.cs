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
    [NativeName("Name", "DWRITE_TEXT_METRICS1")]
    public unsafe partial struct TextMetrics1
    {
        public TextMetrics1
        (
            float? left = null,
            float? top = null,
            float? width = null,
            float? widthIncludingTrailingWhitespace = null,
            float? height = null,
            float? layoutWidth = null,
            float? layoutHeight = null,
            uint? maxBidiReorderingDepth = null,
            uint? lineCount = null,
            float? heightIncludingTrailingWhitespace = null
        ) : this()
        {
            if (left is not null)
            {
                Left = left.Value;
            }

            if (top is not null)
            {
                Top = top.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (widthIncludingTrailingWhitespace is not null)
            {
                WidthIncludingTrailingWhitespace = widthIncludingTrailingWhitespace.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (layoutWidth is not null)
            {
                LayoutWidth = layoutWidth.Value;
            }

            if (layoutHeight is not null)
            {
                LayoutHeight = layoutHeight.Value;
            }

            if (maxBidiReorderingDepth is not null)
            {
                MaxBidiReorderingDepth = maxBidiReorderingDepth.Value;
            }

            if (lineCount is not null)
            {
                LineCount = lineCount.Value;
            }

            if (heightIncludingTrailingWhitespace is not null)
            {
                HeightIncludingTrailingWhitespace = heightIncludingTrailingWhitespace.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "left")]
        public float Left;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "top")]
        public float Top;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "width")]
        public float Width;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "widthIncludingTrailingWhitespace")]
        public float WidthIncludingTrailingWhitespace;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "height")]
        public float Height;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "layoutWidth")]
        public float LayoutWidth;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "layoutHeight")]
        public float LayoutHeight;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "maxBidiReorderingDepth")]
        public uint MaxBidiReorderingDepth;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "lineCount")]
        public uint LineCount;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "heightIncludingTrailingWhitespace")]
        public float HeightIncludingTrailingWhitespace;
    }
}
