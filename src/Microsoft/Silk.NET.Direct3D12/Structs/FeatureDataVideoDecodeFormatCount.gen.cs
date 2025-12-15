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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_FORMAT_COUNT")]
    public unsafe partial struct FeatureDataVideoDecodeFormatCount
    {
        public FeatureDataVideoDecodeFormatCount
        (
            uint? nodeIndex = null,
            VideoDecodeConfiguration? configuration = null,
            uint? formatCount = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (configuration is not null)
            {
                Configuration = configuration.Value;
            }

            if (formatCount is not null)
            {
                FormatCount = formatCount.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FormatCount")]
        public uint FormatCount;
    }
}
