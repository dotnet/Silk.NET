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
    [NativeName("Name", "D2D1_SVG_LENGTH")]
    public unsafe partial struct SvgLength
    {
        public SvgLength
        (
            float? value = null,
            SvgLengthUnits? units = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }

            if (units is not null)
            {
                Units = units.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "value")]
        public float Value;

        [NativeName("Type", "D2D1_SVG_LENGTH_UNITS")]
        [NativeName("Type.Name", "D2D1_SVG_LENGTH_UNITS")]
        [NativeName("Name", "units")]
        public SvgLengthUnits Units;
    }
}
