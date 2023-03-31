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
    [NativeName("Name", "DWRITE_HIT_TEST_METRICS")]
    public unsafe partial struct HitTestMetrics
    {
        public HitTestMetrics
        (
            uint? textPosition = null,
            uint? length = null,
            float? left = null,
            float? top = null,
            float? width = null,
            float? height = null,
            uint? bidiLevel = null,
            Silk.NET.Core.Bool32? isText = null,
            Silk.NET.Core.Bool32? isTrimmed = null
        ) : this()
        {
            if (textPosition is not null)
            {
                TextPosition = textPosition.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

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

            if (height is not null)
            {
                Height = height.Value;
            }

            if (bidiLevel is not null)
            {
                BidiLevel = bidiLevel.Value;
            }

            if (isText is not null)
            {
                IsText = isText.Value;
            }

            if (isTrimmed is not null)
            {
                IsTrimmed = isTrimmed.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "textPosition")]
        public uint TextPosition;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "length")]
        public uint Length;

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
        [NativeName("Name", "height")]
        public float Height;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "bidiLevel")]
        public uint BidiLevel;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "isText")]
        public Silk.NET.Core.Bool32 IsText;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "isTrimmed")]
        public Silk.NET.Core.Bool32 IsTrimmed;
    }
}
