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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_CUSTOM_RATE")]
    public unsafe partial struct VideoProcessorCustomRate
    {
        public VideoProcessorCustomRate
        (
            Silk.NET.DXGI.Rational? customRate = null,
            uint? outputFrames = null,
            Silk.NET.Core.Bool32? inputInterlaced = null,
            uint? inputFramesOrFields = null
        ) : this()
        {
            if (customRate is not null)
            {
                CustomRate = customRate.Value;
            }

            if (outputFrames is not null)
            {
                OutputFrames = outputFrames.Value;
            }

            if (inputInterlaced is not null)
            {
                InputInterlaced = inputInterlaced.Value;
            }

            if (inputFramesOrFields is not null)
            {
                InputFramesOrFields = inputFramesOrFields.Value;
            }
        }


        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "CustomRate")]
        public Silk.NET.DXGI.Rational CustomRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputFrames")]
        public uint OutputFrames;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InputInterlaced")]
        public Silk.NET.Core.Bool32 InputInterlaced;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFramesOrFields")]
        public uint InputFramesOrFields;
    }
}
