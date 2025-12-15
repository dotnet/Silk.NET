// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_BARRIER_SYNC")]
    public enum BarrierSync : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_NONE")]
        BarrierSyncNone = 0x0,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_ALL")]
        BarrierSyncAll = 0x1,
        [Obsolete("Deprecated in favour of \"Draw\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_DRAW")]
        BarrierSyncDraw = 0x2,
        [Obsolete("Deprecated in favour of \"IndexInput\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_INDEX_INPUT")]
        BarrierSyncIndexInput = 0x4,
        [Obsolete("Deprecated in favour of \"VertexShading\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_VERTEX_SHADING")]
        BarrierSyncVertexShading = 0x8,
        [Obsolete("Deprecated in favour of \"PixelShading\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_PIXEL_SHADING")]
        BarrierSyncPixelShading = 0x10,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_DEPTH_STENCIL")]
        BarrierSyncDepthStencil = 0x20,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_RENDER_TARGET")]
        BarrierSyncRenderTarget = 0x40,
        [Obsolete("Deprecated in favour of \"ComputeShading\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_COMPUTE_SHADING")]
        BarrierSyncComputeShading = 0x80,
        [Obsolete("Deprecated in favour of \"Raytracing\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_RAYTRACING")]
        BarrierSyncRaytracing = 0x100,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_COPY")]
        BarrierSyncCopy = 0x200,
        [Obsolete("Deprecated in favour of \"Resolve\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_RESOLVE")]
        BarrierSyncResolve = 0x400,
        [Obsolete("Deprecated in favour of \"ExecuteIndirect\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_EXECUTE_INDIRECT")]
        BarrierSyncExecuteIndirect = 0x800,
        [Obsolete("Deprecated in favour of \"Predication\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_PREDICATION")]
        BarrierSyncPredication = 0x800,
        [Obsolete("Deprecated in favour of \"AllShading\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_ALL_SHADING")]
        BarrierSyncAllShading = 0x1000,
        [Obsolete("Deprecated in favour of \"NonPixelShading\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_NON_PIXEL_SHADING")]
        BarrierSyncNonPixelShading = 0x2000,
        [Obsolete("Deprecated in favour of \"EmitRaytracingAccelerationStructurePostbuildInfo\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO")]
        BarrierSyncEmitRaytracingAccelerationStructurePostbuildInfo = 0x4000,
        [Obsolete("Deprecated in favour of \"ClearUnorderedAccessView\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW")]
        BarrierSyncClearUnorderedAccessView = 0x8000,
        [Obsolete("Deprecated in favour of \"VideoDecode\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_DECODE")]
        BarrierSyncVideoDecode = 0x100000,
        [Obsolete("Deprecated in favour of \"VideoProcess\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_PROCESS")]
        BarrierSyncVideoProcess = 0x200000,
        [Obsolete("Deprecated in favour of \"VideoEncode\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_ENCODE")]
        BarrierSyncVideoEncode = 0x400000,
        [Obsolete("Deprecated in favour of \"BuildRaytracingAccelerationStructure\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE")]
        BarrierSyncBuildRaytracingAccelerationStructure = 0x800000,
        [Obsolete("Deprecated in favour of \"CopyRaytracingAccelerationStructure\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE")]
        BarrierSyncCopyRaytracingAccelerationStructure = 0x1000000,
        [Obsolete("Deprecated in favour of \"Split\"")]
        [NativeName("Name", "D3D12_BARRIER_SYNC_SPLIT")]
        BarrierSyncSplit = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_BARRIER_SYNC_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_BARRIER_SYNC_ALL")]
        All = 0x1,
        [NativeName("Name", "D3D12_BARRIER_SYNC_DRAW")]
        Draw = 0x2,
        [NativeName("Name", "D3D12_BARRIER_SYNC_INDEX_INPUT")]
        IndexInput = 0x4,
        [NativeName("Name", "D3D12_BARRIER_SYNC_VERTEX_SHADING")]
        VertexShading = 0x8,
        [NativeName("Name", "D3D12_BARRIER_SYNC_PIXEL_SHADING")]
        PixelShading = 0x10,
        [NativeName("Name", "D3D12_BARRIER_SYNC_DEPTH_STENCIL")]
        DepthStencil = 0x20,
        [NativeName("Name", "D3D12_BARRIER_SYNC_RENDER_TARGET")]
        RenderTarget = 0x40,
        [NativeName("Name", "D3D12_BARRIER_SYNC_COMPUTE_SHADING")]
        ComputeShading = 0x80,
        [NativeName("Name", "D3D12_BARRIER_SYNC_RAYTRACING")]
        Raytracing = 0x100,
        [NativeName("Name", "D3D12_BARRIER_SYNC_COPY")]
        Copy = 0x200,
        [NativeName("Name", "D3D12_BARRIER_SYNC_RESOLVE")]
        Resolve = 0x400,
        [NativeName("Name", "D3D12_BARRIER_SYNC_EXECUTE_INDIRECT")]
        ExecuteIndirect = 0x800,
        [NativeName("Name", "D3D12_BARRIER_SYNC_PREDICATION")]
        Predication = 0x800,
        [NativeName("Name", "D3D12_BARRIER_SYNC_ALL_SHADING")]
        AllShading = 0x1000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_NON_PIXEL_SHADING")]
        NonPixelShading = 0x2000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO")]
        EmitRaytracingAccelerationStructurePostbuildInfo = 0x4000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW")]
        ClearUnorderedAccessView = 0x8000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_DECODE")]
        VideoDecode = 0x100000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_PROCESS")]
        VideoProcess = 0x200000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_VIDEO_ENCODE")]
        VideoEncode = 0x400000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE")]
        BuildRaytracingAccelerationStructure = 0x800000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE")]
        CopyRaytracingAccelerationStructure = 0x1000000,
        [NativeName("Name", "D3D12_BARRIER_SYNC_SPLIT")]
        Split = unchecked((int) 0xFFFFFFFF80000000),
    }
}
