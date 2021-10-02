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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_VideoPropertyRange")]
    public unsafe partial struct VideoPropertyRange
    {
        public VideoPropertyRange
        (
            float? minValue = null,
            float? maxValue = null,
            float? defaultValue = null,
            float? stepSize = null
        ) : this()
        {
            if (minValue is not null)
            {
                MinValue = minValue.Value;
            }

            if (maxValue is not null)
            {
                MaxValue = maxValue.Value;
            }

            if (defaultValue is not null)
            {
                DefaultValue = defaultValue.Value;
            }

            if (stepSize is not null)
            {
                StepSize = stepSize.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinValue")]
        public float MinValue;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxValue")]
        public float MaxValue;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DefaultValue")]
        public float DefaultValue;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "StepSize")]
        public float StepSize;
    }
}
