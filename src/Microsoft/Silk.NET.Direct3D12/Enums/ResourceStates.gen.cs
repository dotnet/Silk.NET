// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_STATES")]
    public enum ResourceStates : int
    {
        [NativeName("Name", "D3D12_RESOURCE_STATE_COMMON")]
        ResourceStateCommon = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER")]
        ResourceStateVertexAndConstantBuffer = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDEX_BUFFER")]
        ResourceStateIndexBuffer = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RENDER_TARGET")]
        ResourceStateRenderTarget = 0x4,
        [NativeName("Name", "D3D12_RESOURCE_STATE_UNORDERED_ACCESS")]
        ResourceStateUnorderedAccess = 0x8,
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_WRITE")]
        ResourceStateDepthWrite = 0x10,
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_READ")]
        ResourceStateDepthRead = 0x20,
        [NativeName("Name", "D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE")]
        ResourceStateNonPixelShaderResource = 0x40,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE")]
        ResourceStatePixelShaderResource = 0x80,
        [NativeName("Name", "D3D12_RESOURCE_STATE_STREAM_OUT")]
        ResourceStateStreamOut = 0x100,
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT")]
        ResourceStateIndirectArgument = 0x200,
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_DEST")]
        ResourceStateCopyDest = 0x400,
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_SOURCE")]
        ResourceStateCopySource = 0x800,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_DEST")]
        ResourceStateResolveDest = 0x1000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_SOURCE")]
        ResourceStateResolveSource = 0x2000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE")]
        ResourceStateRaytracingAccelerationStructure = 0x400000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE")]
        ResourceStateShadingRateSource = 0x1000000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_GENERIC_READ")]
        ResourceStateGenericRead = 0xAC3,
        [NativeName("Name", "D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE")]
        ResourceStateAllShaderResource = 0xC0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PRESENT")]
        ResourceStatePresent = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PREDICATION")]
        ResourceStatePredication = 0x200,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_READ")]
        ResourceStateVideoDecodeRead = 0x10000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE")]
        ResourceStateVideoDecodeWrite = 0x20000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ")]
        ResourceStateVideoProcessRead = 0x40000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE")]
        ResourceStateVideoProcessWrite = 0x80000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ")]
        ResourceStateVideoEncodeRead = 0x200000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE")]
        ResourceStateVideoEncodeWrite = 0x800000,
    }
}
