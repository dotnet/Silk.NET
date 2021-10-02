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
    [NativeName("Name", "_DXVA2_ValueRange")]
    public unsafe partial struct DXVA2ValueRange
    {
        public DXVA2ValueRange
        (
            DXVA2Fixed32? minValue = null,
            DXVA2Fixed32? maxValue = null,
            DXVA2Fixed32? defaultValue = null,
            DXVA2Fixed32? stepSize = null
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


        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "MinValue")]
        public DXVA2Fixed32 MinValue;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "MaxValue")]
        public DXVA2Fixed32 MaxValue;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "DefaultValue")]
        public DXVA2Fixed32 DefaultValue;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "StepSize")]
        public DXVA2Fixed32 StepSize;
    }
}
