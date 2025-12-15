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
        [Obsolete("Deprecated in favour of \"Common\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_COMMON")]
        ResourceStateCommon = 0x0,
        [Obsolete("Deprecated in favour of \"VertexAndConstantBuffer\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER")]
        ResourceStateVertexAndConstantBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"IndexBuffer\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDEX_BUFFER")]
        ResourceStateIndexBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RENDER_TARGET")]
        ResourceStateRenderTarget = 0x4,
        [Obsolete("Deprecated in favour of \"UnorderedAccess\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_UNORDERED_ACCESS")]
        ResourceStateUnorderedAccess = 0x8,
        [Obsolete("Deprecated in favour of \"DepthWrite\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_WRITE")]
        ResourceStateDepthWrite = 0x10,
        [Obsolete("Deprecated in favour of \"DepthRead\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_READ")]
        ResourceStateDepthRead = 0x20,
        [Obsolete("Deprecated in favour of \"NonPixelShaderResource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE")]
        ResourceStateNonPixelShaderResource = 0x40,
        [Obsolete("Deprecated in favour of \"PixelShaderResource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE")]
        ResourceStatePixelShaderResource = 0x80,
        [Obsolete("Deprecated in favour of \"StreamOut\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_STREAM_OUT")]
        ResourceStateStreamOut = 0x100,
        [Obsolete("Deprecated in favour of \"IndirectArgument\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT")]
        ResourceStateIndirectArgument = 0x200,
        [Obsolete("Deprecated in favour of \"CopyDest\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_DEST")]
        ResourceStateCopyDest = 0x400,
        [Obsolete("Deprecated in favour of \"CopySource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_SOURCE")]
        ResourceStateCopySource = 0x800,
        [Obsolete("Deprecated in favour of \"ResolveDest\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_DEST")]
        ResourceStateResolveDest = 0x1000,
        [Obsolete("Deprecated in favour of \"ResolveSource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_SOURCE")]
        ResourceStateResolveSource = 0x2000,
        [Obsolete("Deprecated in favour of \"RaytracingAccelerationStructure\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE")]
        ResourceStateRaytracingAccelerationStructure = 0x400000,
        [Obsolete("Deprecated in favour of \"ShadingRateSource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE")]
        ResourceStateShadingRateSource = 0x1000000,
        [Obsolete("Deprecated in favour of \"ReservedInternal8000\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_8000")]
        ResourceStateReservedInternal8000 = 0x8000,
        [Obsolete("Deprecated in favour of \"ReservedInternal4000\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_4000")]
        ResourceStateReservedInternal4000 = 0x4000,
        [Obsolete("Deprecated in favour of \"ReservedInternal100000\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_100000")]
        ResourceStateReservedInternal100000 = 0x100000,
        [Obsolete("Deprecated in favour of \"ReservedInternal40000000\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_40000000")]
        ResourceStateReservedInternal40000000 = 0x40000000,
        [Obsolete("Deprecated in favour of \"ReservedInternal80000000\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_80000000")]
        ResourceStateReservedInternal80000000 = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"GenericRead\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_GENERIC_READ")]
        ResourceStateGenericRead = 0xAC3,
        [Obsolete("Deprecated in favour of \"AllShaderResource\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE")]
        ResourceStateAllShaderResource = 0xC0,
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_PRESENT")]
        ResourceStatePresent = 0x0,
        [Obsolete("Deprecated in favour of \"Predication\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_PREDICATION")]
        ResourceStatePredication = 0x200,
        [Obsolete("Deprecated in favour of \"VideoDecodeRead\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_READ")]
        ResourceStateVideoDecodeRead = 0x10000,
        [Obsolete("Deprecated in favour of \"VideoDecodeWrite\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE")]
        ResourceStateVideoDecodeWrite = 0x20000,
        [Obsolete("Deprecated in favour of \"VideoProcessRead\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ")]
        ResourceStateVideoProcessRead = 0x40000,
        [Obsolete("Deprecated in favour of \"VideoProcessWrite\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE")]
        ResourceStateVideoProcessWrite = 0x80000,
        [Obsolete("Deprecated in favour of \"VideoEncodeRead\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ")]
        ResourceStateVideoEncodeRead = 0x200000,
        [Obsolete("Deprecated in favour of \"VideoEncodeWrite\"")]
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE")]
        ResourceStateVideoEncodeWrite = 0x800000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_COMMON")]
        Common = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER")]
        VertexAndConstantBuffer = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDEX_BUFFER")]
        IndexBuffer = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RENDER_TARGET")]
        RenderTarget = 0x4,
        [NativeName("Name", "D3D12_RESOURCE_STATE_UNORDERED_ACCESS")]
        UnorderedAccess = 0x8,
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_WRITE")]
        DepthWrite = 0x10,
        [NativeName("Name", "D3D12_RESOURCE_STATE_DEPTH_READ")]
        DepthRead = 0x20,
        [NativeName("Name", "D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE")]
        NonPixelShaderResource = 0x40,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE")]
        PixelShaderResource = 0x80,
        [NativeName("Name", "D3D12_RESOURCE_STATE_STREAM_OUT")]
        StreamOut = 0x100,
        [NativeName("Name", "D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT")]
        IndirectArgument = 0x200,
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_DEST")]
        CopyDest = 0x400,
        [NativeName("Name", "D3D12_RESOURCE_STATE_COPY_SOURCE")]
        CopySource = 0x800,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_DEST")]
        ResolveDest = 0x1000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESOLVE_SOURCE")]
        ResolveSource = 0x2000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE")]
        RaytracingAccelerationStructure = 0x400000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE")]
        ShadingRateSource = 0x1000000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_8000")]
        ReservedInternal8000 = 0x8000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_4000")]
        ReservedInternal4000 = 0x4000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_100000")]
        ReservedInternal100000 = 0x100000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_40000000")]
        ReservedInternal40000000 = 0x40000000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_RESERVED_INTERNAL_80000000")]
        ReservedInternal80000000 = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_RESOURCE_STATE_GENERIC_READ")]
        GenericRead = 0xAC3,
        [NativeName("Name", "D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE")]
        AllShaderResource = 0xC0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PRESENT")]
        Present = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_STATE_PREDICATION")]
        Predication = 0x200,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_READ")]
        VideoDecodeRead = 0x10000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE")]
        VideoDecodeWrite = 0x20000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ")]
        VideoProcessRead = 0x40000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE")]
        VideoProcessWrite = 0x80000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ")]
        VideoEncodeRead = 0x200000,
        [NativeName("Name", "D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE")]
        VideoEncodeWrite = 0x800000,
    }
}
