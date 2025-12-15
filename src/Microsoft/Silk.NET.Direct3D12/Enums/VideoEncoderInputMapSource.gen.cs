// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
    public enum VideoEncoderInputMapSource : int
    {
        [Obsolete("Deprecated in favour of \"CpuBuffer\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE_CPU_BUFFER")]
        VideoEncoderInputMapSourceCpuBuffer = 0x0,
        [Obsolete("Deprecated in favour of \"GpuTexture\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE_GPU_TEXTURE")]
        VideoEncoderInputMapSourceGpuTexture = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE_CPU_BUFFER")]
        CpuBuffer = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE_GPU_TEXTURE")]
        GpuTexture = 0x1,
    }
}
