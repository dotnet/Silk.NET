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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_ANALYSIS")]
    public unsafe partial struct VideoEncoderFrameAnalysis
    {
        public VideoEncoderFrameAnalysis
        (
            ID3D12Resource* pDownscaledFrame = null,
            ulong? subresource = null,
            VideoEncodeReferenceFrames? downscaledReferences = null
        ) : this()
        {
            if (pDownscaledFrame is not null)
            {
                PDownscaledFrame = pDownscaledFrame;
            }

            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }

            if (downscaledReferences is not null)
            {
                DownscaledReferences = downscaledReferences.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pDownscaledFrame")]
        public ID3D12Resource* PDownscaledFrame;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Subresource")]
        public ulong Subresource;

        [NativeName("Type", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Name", "DownscaledReferences")]
        public VideoEncodeReferenceFrames DownscaledReferences;
    }
}
