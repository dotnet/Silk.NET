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
    [NativeName("Name", "_DXVAHD_CONTENT_DESC")]
    public unsafe partial struct HDContentDesc
    {
        public HDContentDesc
        (
            HDFrameFormat? inputFrameFormat = null,
            HDRational? inputFrameRate = null,
            uint? inputWidth = null,
            uint? inputHeight = null,
            HDRational? outputFrameRate = null,
            uint? outputWidth = null,
            uint? outputHeight = null
        ) : this()
        {
            if (inputFrameFormat is not null)
            {
                InputFrameFormat = inputFrameFormat.Value;
            }

            if (inputFrameRate is not null)
            {
                InputFrameRate = inputFrameRate.Value;
            }

            if (inputWidth is not null)
            {
                InputWidth = inputWidth.Value;
            }

            if (inputHeight is not null)
            {
                InputHeight = inputHeight.Value;
            }

            if (outputFrameRate is not null)
            {
                OutputFrameRate = outputFrameRate.Value;
            }

            if (outputWidth is not null)
            {
                OutputWidth = outputWidth.Value;
            }

            if (outputHeight is not null)
            {
                OutputHeight = outputHeight.Value;
            }
        }


        [NativeName("Type", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Type.Name", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Name", "InputFrameFormat")]
        public HDFrameFormat InputFrameFormat;

        [NativeName("Type", "DXVAHD_RATIONAL")]
        [NativeName("Type.Name", "DXVAHD_RATIONAL")]
        [NativeName("Name", "InputFrameRate")]
        public HDRational InputFrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputWidth")]
        public uint InputWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputHeight")]
        public uint InputHeight;

        [NativeName("Type", "DXVAHD_RATIONAL")]
        [NativeName("Type.Name", "DXVAHD_RATIONAL")]
        [NativeName("Name", "OutputFrameRate")]
        public HDRational OutputFrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputWidth")]
        public uint OutputWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputHeight")]
        public uint OutputHeight;
    }
}
