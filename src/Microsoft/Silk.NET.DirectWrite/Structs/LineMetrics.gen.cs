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
    [NativeName("Name", "DWRITE_LINE_METRICS")]
    public unsafe partial struct LineMetrics
    {
        public LineMetrics
        (
            uint? length = null,
            uint? trailingWhitespaceLength = null,
            uint? newlineLength = null,
            float? height = null,
            float? baseline = null,
            Silk.NET.Core.Bool32? isTrimmed = null
        ) : this()
        {
            if (length is not null)
            {
                Length = length.Value;
            }

            if (trailingWhitespaceLength is not null)
            {
                TrailingWhitespaceLength = trailingWhitespaceLength.Value;
            }

            if (newlineLength is not null)
            {
                NewlineLength = newlineLength.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (baseline is not null)
            {
                Baseline = baseline.Value;
            }

            if (isTrimmed is not null)
            {
                IsTrimmed = isTrimmed.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "length")]
        public uint Length;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "trailingWhitespaceLength")]
        public uint TrailingWhitespaceLength;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "newlineLength")]
        public uint NewlineLength;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "height")]
        public float Height;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "baseline")]
        public float Baseline;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "isTrimmed")]
        public Silk.NET.Core.Bool32 IsTrimmed;
    }
}
