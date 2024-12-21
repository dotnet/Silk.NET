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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT")]
    public unsafe partial struct VideoEncoderFrameSubregionLayoutConfigSupport
    {
        public VideoEncoderFrameSubregionLayoutConfigSupport
        (
            uint? dataSize = null,
            VideoEncoderFrameSubregionLayoutConfigSupportUnion? anonymous = null,
            VideoEncoderAV1FrameSubregionLayoutConfigSupport* pAV1Support = null
        ) : this()
        {
            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pAV1Support is not null)
            {
                PAV1Support = pAV1Support;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7181_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderFrameSubregionLayoutConfigSupportUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1FrameSubregionLayoutConfigSupport* PAV1Support
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1Support;
        }
#else
        public VideoEncoderAV1FrameSubregionLayoutConfigSupport* PAV1Support
        {
            get => Anonymous.PAV1Support;
            set => Anonymous.PAV1Support = value;
        }
#endif

    }
}
