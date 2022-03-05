// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_FLAGS")]
    public enum ResourceFlags : int
    {
        [NativeName("Name", "D3D12_RESOURCE_FLAG_NONE")]
        ResourceFlagNone = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET")]
        ResourceFlagAllowRenderTarget = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL")]
        ResourceFlagAllowDepthStencil = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS")]
        ResourceFlagAllowUnorderedAccess = 0x4,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE")]
        ResourceFlagDenyShaderResource = 0x8,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER")]
        ResourceFlagAllowCrossAdapter = 0x10,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS")]
        ResourceFlagAllowSimultaneousAccess = 0x20,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY")]
        ResourceFlagVideoDecodeReferenceOnly = 0x40,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY")]
        ResourceFlagVideoEncodeReferenceOnly = 0x80,
    }
}
