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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS")]
    public unsafe partial struct FeatureDataVideoDecodeFormats
    {
        public FeatureDataVideoDecodeFormats
        (
            uint? nodeIndex = null,
            VideoDecodeConfiguration? configuration = null,
            uint? formatCount = null,
            Silk.NET.DXGI.Format* pOutputFormats = null
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

            if (pOutputFormats is not null)
            {
                POutputFormats = pOutputFormats;
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

        [NativeName("Type", "DXGI_FORMAT *")]
        [NativeName("Type.Name", "DXGI_FORMAT *")]
        [NativeName("Name", "pOutputFormats")]
        public Silk.NET.DXGI.Format* POutputFormats;
    }
}
