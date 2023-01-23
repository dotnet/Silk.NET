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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA")]
    public unsafe partial struct HDStreamStateOutputRateData
    {
        public HDStreamStateOutputRateData
        (
            Silk.NET.Core.Bool32? repeatFrame = null,
            HDOutputRate? outputRate = null,
            HDRational? customRate = null
        ) : this()
        {
            if (repeatFrame is not null)
            {
                RepeatFrame = repeatFrame.Value;
            }

            if (outputRate is not null)
            {
                OutputRate = outputRate.Value;
            }

            if (customRate is not null)
            {
                CustomRate = customRate.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "RepeatFrame")]
        public Silk.NET.Core.Bool32 RepeatFrame;

        [NativeName("Type", "DXVAHD_OUTPUT_RATE")]
        [NativeName("Type.Name", "DXVAHD_OUTPUT_RATE")]
        [NativeName("Name", "OutputRate")]
        public HDOutputRate OutputRate;

        [NativeName("Type", "DXVAHD_RATIONAL")]
        [NativeName("Type.Name", "DXVAHD_RATIONAL")]
        [NativeName("Name", "CustomRate")]
        public HDRational CustomRate;
    }
}
