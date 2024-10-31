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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6974_C5")]
    public unsafe partial struct VideoEncoderProfileDescUnion
    {
        public VideoEncoderProfileDescUnion
        (
            VideoEncoderProfileH264* pH264Profile = null,
            VideoEncoderProfileHevc* pHEVCProfile = null,
            VideoEncoderAV1Profile* pAV1Profile = null
        ) : this()
        {
            if (pH264Profile is not null)
            {
                PH264Profile = pH264Profile;
            }

            if (pHEVCProfile is not null)
            {
                PHEVCProfile = pHEVCProfile;
            }

            if (pAV1Profile is not null)
            {
                PAV1Profile = pAV1Profile;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_H264 *")]
        [NativeName("Name", "pH264Profile")]
        public VideoEncoderProfileH264* PH264Profile;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC *")]
        [NativeName("Name", "pHEVCProfile")]
        public VideoEncoderProfileHevc* PHEVCProfile;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_PROFILE *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE *")]
        [NativeName("Name", "pAV1Profile")]
        public VideoEncoderAV1Profile* PAV1Profile;
    }
}
