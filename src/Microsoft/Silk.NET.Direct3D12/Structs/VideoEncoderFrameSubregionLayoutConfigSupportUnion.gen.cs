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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L7181_C5")]
    public unsafe partial struct VideoEncoderFrameSubregionLayoutConfigSupportUnion
    {
        public VideoEncoderFrameSubregionLayoutConfigSupportUnion
        (
            VideoEncoderAV1FrameSubregionLayoutConfigSupport* pAV1Support = null
        ) : this()
        {
            if (pAV1Support is not null)
            {
                PAV1Support = pAV1Support;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT *")]
        [NativeName("Name", "pAV1Support")]
        public VideoEncoderAV1FrameSubregionLayoutConfigSupport* PAV1Support;
    }
}
