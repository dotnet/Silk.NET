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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_NONE")]
        ResourceFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowRenderTarget\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET")]
        ResourceFlagAllowRenderTarget = 0x1,
        [Obsolete("Deprecated in favour of \"AllowDepthStencil\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL")]
        ResourceFlagAllowDepthStencil = 0x2,
        [Obsolete("Deprecated in favour of \"AllowUnorderedAccess\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS")]
        ResourceFlagAllowUnorderedAccess = 0x4,
        [Obsolete("Deprecated in favour of \"DenyShaderResource\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE")]
        ResourceFlagDenyShaderResource = 0x8,
        [Obsolete("Deprecated in favour of \"AllowCrossAdapter\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER")]
        ResourceFlagAllowCrossAdapter = 0x10,
        [Obsolete("Deprecated in favour of \"AllowSimultaneousAccess\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS")]
        ResourceFlagAllowSimultaneousAccess = 0x20,
        [Obsolete("Deprecated in favour of \"VideoDecodeReferenceOnly\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY")]
        ResourceFlagVideoDecodeReferenceOnly = 0x40,
        [Obsolete("Deprecated in favour of \"VideoEncodeReferenceOnly\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY")]
        ResourceFlagVideoEncodeReferenceOnly = 0x80,
        [Obsolete("Deprecated in favour of \"RaytracingAccelerationStructure\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE")]
        ResourceFlagRaytracingAccelerationStructure = 0x100,
        [Obsolete("Deprecated in favour of \"UseTightAlignment\"")]
        [NativeName("Name", "D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT")]
        ResourceFlagUseTightAlignment = 0x400,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET")]
        AllowRenderTarget = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL")]
        AllowDepthStencil = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS")]
        AllowUnorderedAccess = 0x4,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE")]
        DenyShaderResource = 0x8,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER")]
        AllowCrossAdapter = 0x10,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS")]
        AllowSimultaneousAccess = 0x20,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY")]
        VideoDecodeReferenceOnly = 0x40,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY")]
        VideoEncodeReferenceOnly = 0x80,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE")]
        RaytracingAccelerationStructure = 0x100,
        [NativeName("Name", "D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT")]
        UseTightAlignment = 0x400,
    }
}
