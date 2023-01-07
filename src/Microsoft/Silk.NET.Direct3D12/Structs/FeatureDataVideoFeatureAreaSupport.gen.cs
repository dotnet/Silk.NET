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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT")]
    public unsafe partial struct FeatureDataVideoFeatureAreaSupport
    {
        public FeatureDataVideoFeatureAreaSupport
        (
            uint? nodeIndex = null,
            Silk.NET.Core.Bool32? videoDecodeSupport = null,
            Silk.NET.Core.Bool32? videoProcessSupport = null,
            Silk.NET.Core.Bool32? videoEncodeSupport = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (videoDecodeSupport is not null)
            {
                VideoDecodeSupport = videoDecodeSupport.Value;
            }

            if (videoProcessSupport is not null)
            {
                VideoProcessSupport = videoProcessSupport.Value;
            }

            if (videoEncodeSupport is not null)
            {
                VideoEncodeSupport = videoEncodeSupport.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VideoDecodeSupport")]
        public Silk.NET.Core.Bool32 VideoDecodeSupport;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VideoProcessSupport")]
        public Silk.NET.Core.Bool32 VideoProcessSupport;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VideoEncodeSupport")]
        public Silk.NET.Core.Bool32 VideoEncodeSupport;
    }
}
