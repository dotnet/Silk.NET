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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION")]
    public unsafe partial struct VideoEncoderAV1CodecConfiguration
    {
        public VideoEncoderAV1CodecConfiguration
        (
            VideoEncoderAV1FeatureFlags? featureFlags = null,
            uint? orderHintBitsMinus1 = null
        ) : this()
        {
            if (featureFlags is not null)
            {
                FeatureFlags = featureFlags.Value;
            }

            if (orderHintBitsMinus1 is not null)
            {
                OrderHintBitsMinus1 = orderHintBitsMinus1.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Name", "FeatureFlags")]
        public VideoEncoderAV1FeatureFlags FeatureFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OrderHintBitsMinus1")]
        public uint OrderHintBitsMinus1;
    }
}
