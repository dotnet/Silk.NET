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
    [NativeName("Name", "DWRITE_OVERHANG_METRICS")]
    public unsafe partial struct OverhangMetrics
    {
        public OverhangMetrics
        (
            float? left = null,
            float? top = null,
            float? right = null,
            float? bottom = null
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

            if (right is not null)
            {
                Right = right.Value;
            }

            if (bottom is not null)
            {
                Bottom = bottom.Value;
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
        [NativeName("Name", "right")]
        public float Right;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "bottom")]
        public float Bottom;
    }
}
