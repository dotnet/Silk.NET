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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA")]
    public unsafe partial struct VideoEncoderAV1SegmentData
    {
        public VideoEncoderAV1SegmentData
        (
            ulong? enabledFeatures = null
        ) : this()
        {
            if (enabledFeatures is not null)
            {
                EnabledFeatures = enabledFeatures.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "EnabledFeatures")]
        public ulong EnabledFeatures;
        [NativeName("Type", "INT64[8]")]
        [NativeName("Type.Name", "INT64[8]")]
        [NativeName("Name", "FeatureValue")]
        public fixed long FeatureValue[8];
    }
}
