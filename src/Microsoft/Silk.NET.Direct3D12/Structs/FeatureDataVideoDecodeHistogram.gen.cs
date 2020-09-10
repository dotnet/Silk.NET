// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM")]
    public unsafe partial struct FeatureDataVideoDecodeHistogram
    {
        public FeatureDataVideoDecodeHistogram
        (
            uint nodeIndex = default,
            Guid decodeProfile = default,
            uint width = default,
            uint height = default,
            Silk.NET.DXGI.Format decodeFormat = default,
            VideoDecodeHistogramComponentFlags components = default,
            uint binCount = default,
            uint counterBitDepth = default
        )
        {
            NodeIndex = nodeIndex;
            DecodeProfile = decodeProfile;
            Width = width;
            Height = height;
            DecodeFormat = decodeFormat;
            Components = components;
            BinCount = binCount;
            CounterBitDepth = counterBitDepth;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DecodeProfile")]
        public Guid DecodeProfile;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DecodeFormat")]
        public Silk.NET.DXGI.Format DecodeFormat;

        [NativeName("Type", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS")]
        [NativeName("Name", "Components")]
        public VideoDecodeHistogramComponentFlags Components;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BinCount")]
        public uint BinCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CounterBitDepth")]
        public uint CounterBitDepth;
    }
}
