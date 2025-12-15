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
    [NativeName("Name", "D3D12_VIDEO_DECODER_DESC")]
    public unsafe partial struct VideoDecoderDesc
    {
        public VideoDecoderDesc
        (
            uint? nodeMask = null,
            VideoDecodeConfiguration? configuration = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (configuration is not null)
            {
                Configuration = configuration.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;
    }
}
