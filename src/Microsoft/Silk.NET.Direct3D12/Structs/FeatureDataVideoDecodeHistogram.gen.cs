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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM")]
    public unsafe partial struct FeatureDataVideoDecodeHistogram
    {
        public FeatureDataVideoDecodeHistogram
        (
            uint? nodeIndex = null,
            Guid? decodeProfile = null,
            uint? width = null,
            uint? height = null,
            Silk.NET.DXGI.Format? decodeFormat = null,
            VideoDecodeHistogramComponentFlags? components = null,
            uint? binCount = null,
            uint? counterBitDepth = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (decodeProfile is not null)
            {
                DecodeProfile = decodeProfile.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (decodeFormat is not null)
            {
                DecodeFormat = decodeFormat.Value;
            }

            if (components is not null)
            {
                Components = components.Value;
            }

            if (binCount is not null)
            {
                BinCount = binCount.Value;
            }

            if (counterBitDepth is not null)
            {
                CounterBitDepth = counterBitDepth.Value;
            }
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
