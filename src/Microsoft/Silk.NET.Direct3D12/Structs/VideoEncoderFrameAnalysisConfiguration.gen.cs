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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_ANALYSIS_CONFIGURATION")]
    public unsafe partial struct VideoEncoderFrameAnalysisConfiguration
    {
        public VideoEncoderFrameAnalysisConfiguration
        (
            Silk.NET.Core.Bool32? enabled = null,
            uint? pow2DownscaleFactor = null
        ) : this()
        {
            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }

            if (pow2DownscaleFactor is not null)
            {
                Pow2DownscaleFactor = pow2DownscaleFactor.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enabled")]
        public Silk.NET.Core.Bool32 Enabled;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Pow2DownscaleFactor")]
        public uint Pow2DownscaleFactor;
    }
}
