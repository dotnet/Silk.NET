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
    [NativeName("Name", "DWRITE_FONT_AXIS_VALUE")]
    public unsafe partial struct FontAxisValue
    {
        public FontAxisValue
        (
            FontAxisTag? axisTag = null,
            float? value = null
        ) : this()
        {
            if (axisTag is not null)
            {
                AxisTag = axisTag.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "DWRITE_FONT_AXIS_TAG")]
        [NativeName("Type.Name", "DWRITE_FONT_AXIS_TAG")]
        [NativeName("Name", "axisTag")]
        public FontAxisTag AxisTag;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "value")]
        public float Value;
    }
}
