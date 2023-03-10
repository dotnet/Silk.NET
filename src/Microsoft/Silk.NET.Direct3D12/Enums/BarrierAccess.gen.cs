// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_BARRIER_ACCESS")]
    public enum BarrierAccess : int
    {
        [Obsolete("Deprecated in favour of \"Common\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COMMON")]
        BarrierAccessCommon = 0x0,
        [Obsolete("Deprecated in favour of \"VertexBuffer\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VERTEX_BUFFER")]
        BarrierAccessVertexBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"ConstantBuffer\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_CONSTANT_BUFFER")]
        BarrierAccessConstantBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"IndexBuffer\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_INDEX_BUFFER")]
        BarrierAccessIndexBuffer = 0x4,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RENDER_TARGET")]
        BarrierAccessRenderTarget = 0x8,
        [Obsolete("Deprecated in favour of \"UnorderedAccess\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_UNORDERED_ACCESS")]
        BarrierAccessUnorderedAccess = 0x10,
        [Obsolete("Deprecated in favour of \"DepthStencilWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_DEPTH_STENCIL_WRITE")]
        BarrierAccessDepthStencilWrite = 0x20,
        [Obsolete("Deprecated in favour of \"DepthStencilRead\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_DEPTH_STENCIL_READ")]
        BarrierAccessDepthStencilRead = 0x40,
        [Obsolete("Deprecated in favour of \"ShaderResource\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_SHADER_RESOURCE")]
        BarrierAccessShaderResource = 0x80,
        [Obsolete("Deprecated in favour of \"StreamOutput\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_STREAM_OUTPUT")]
        BarrierAccessStreamOutput = 0x100,
        [Obsolete("Deprecated in favour of \"IndirectArgument\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_INDIRECT_ARGUMENT")]
        BarrierAccessIndirectArgument = 0x200,
        [Obsolete("Deprecated in favour of \"Predication\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_PREDICATION")]
        BarrierAccessPredication = 0x200,
        [Obsolete("Deprecated in favour of \"CopyDest\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COPY_DEST")]
        BarrierAccessCopyDest = 0x400,
        [Obsolete("Deprecated in favour of \"CopySource\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COPY_SOURCE")]
        BarrierAccessCopySource = 0x800,
        [Obsolete("Deprecated in favour of \"ResolveDest\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RESOLVE_DEST")]
        BarrierAccessResolveDest = 0x1000,
        [Obsolete("Deprecated in favour of \"ResolveSource\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RESOLVE_SOURCE")]
        BarrierAccessResolveSource = 0x2000,
        [Obsolete("Deprecated in favour of \"RaytracingAccelerationStructureRead\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_READ")]
        BarrierAccessRaytracingAccelerationStructureRead = 0x4000,
        [Obsolete("Deprecated in favour of \"RaytracingAccelerationStructureWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_WRITE")]
        BarrierAccessRaytracingAccelerationStructureWrite = 0x8000,
        [Obsolete("Deprecated in favour of \"ShadingRateSource\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_SHADING_RATE_SOURCE")]
        BarrierAccessShadingRateSource = 0x10000,
        [Obsolete("Deprecated in favour of \"VideoDecodeRead\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_DECODE_READ")]
        BarrierAccessVideoDecodeRead = 0x20000,
        [Obsolete("Deprecated in favour of \"VideoDecodeWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_DECODE_WRITE")]
        BarrierAccessVideoDecodeWrite = 0x40000,
        [Obsolete("Deprecated in favour of \"VideoProcessRead\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_PROCESS_READ")]
        BarrierAccessVideoProcessRead = 0x80000,
        [Obsolete("Deprecated in favour of \"VideoProcessWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_PROCESS_WRITE")]
        BarrierAccessVideoProcessWrite = 0x100000,
        [Obsolete("Deprecated in favour of \"VideoEncodeRead\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_ENCODE_READ")]
        BarrierAccessVideoEncodeRead = 0x200000,
        [Obsolete("Deprecated in favour of \"VideoEncodeWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_ENCODE_WRITE")]
        BarrierAccessVideoEncodeWrite = 0x400000,
        [Obsolete("Deprecated in favour of \"NoAccess\"")]
        [NativeName("Name", "D3D12_BARRIER_ACCESS_NO_ACCESS")]
        BarrierAccessNoAccess = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COMMON")]
        Common = 0x0,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VERTEX_BUFFER")]
        VertexBuffer = 0x1,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_CONSTANT_BUFFER")]
        ConstantBuffer = 0x2,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_INDEX_BUFFER")]
        IndexBuffer = 0x4,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RENDER_TARGET")]
        RenderTarget = 0x8,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_UNORDERED_ACCESS")]
        UnorderedAccess = 0x10,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_DEPTH_STENCIL_WRITE")]
        DepthStencilWrite = 0x20,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_DEPTH_STENCIL_READ")]
        DepthStencilRead = 0x40,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_SHADER_RESOURCE")]
        ShaderResource = 0x80,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_STREAM_OUTPUT")]
        StreamOutput = 0x100,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_INDIRECT_ARGUMENT")]
        IndirectArgument = 0x200,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_PREDICATION")]
        Predication = 0x200,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COPY_DEST")]
        CopyDest = 0x400,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_COPY_SOURCE")]
        CopySource = 0x800,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RESOLVE_DEST")]
        ResolveDest = 0x1000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RESOLVE_SOURCE")]
        ResolveSource = 0x2000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_READ")]
        RaytracingAccelerationStructureRead = 0x4000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_WRITE")]
        RaytracingAccelerationStructureWrite = 0x8000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_SHADING_RATE_SOURCE")]
        ShadingRateSource = 0x10000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_DECODE_READ")]
        VideoDecodeRead = 0x20000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_DECODE_WRITE")]
        VideoDecodeWrite = 0x40000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_PROCESS_READ")]
        VideoProcessRead = 0x80000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_PROCESS_WRITE")]
        VideoProcessWrite = 0x100000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_ENCODE_READ")]
        VideoEncodeRead = 0x200000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_VIDEO_ENCODE_WRITE")]
        VideoEncodeWrite = 0x400000,
        [NativeName("Name", "D3D12_BARRIER_ACCESS_NO_ACCESS")]
        NoAccess = unchecked((int) 0xFFFFFFFF80000000),
    }
}
