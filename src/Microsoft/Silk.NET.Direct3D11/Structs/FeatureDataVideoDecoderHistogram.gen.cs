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
    [NativeName("Name", "D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM")]
    public unsafe partial struct FeatureDataVideoDecoderHistogram
    {
        public FeatureDataVideoDecoderHistogram
        (
            VideoDecoderDesc? decoderDesc = null,
            VideoDecoderHistogramComponentFlags? components = null,
            uint? binCount = null,
            uint? counterBitDepth = null
        ) : this()
        {
            if (decoderDesc is not null)
            {
                DecoderDesc = decoderDesc.Value;
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


        [NativeName("Type", "D3D11_VIDEO_DECODER_DESC")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_DESC")]
        [NativeName("Name", "DecoderDesc")]
        public VideoDecoderDesc DecoderDesc;

        [NativeName("Type", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS")]
        [NativeName("Name", "Components")]
        public VideoDecoderHistogramComponentFlags Components;

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
