// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BARRIER_LAYOUT")]
    public enum BarrierLayout : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_UNDEFINED")]
        BarrierLayoutUndefined = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Common\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMMON")]
        BarrierLayoutCommon = 0x0,
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_PRESENT")]
        BarrierLayoutPresent = 0x0,
        [Obsolete("Deprecated in favour of \"GenericRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_GENERIC_READ")]
        BarrierLayoutGenericRead = 0x1,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RENDER_TARGET")]
        BarrierLayoutRenderTarget = 0x2,
        [Obsolete("Deprecated in favour of \"UnorderedAccess\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_UNORDERED_ACCESS")]
        BarrierLayoutUnorderedAccess = 0x3,
        [Obsolete("Deprecated in favour of \"DepthStencilWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_WRITE")]
        BarrierLayoutDepthStencilWrite = 0x4,
        [Obsolete("Deprecated in favour of \"DepthStencilRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_READ")]
        BarrierLayoutDepthStencilRead = 0x5,
        [Obsolete("Deprecated in favour of \"ShaderResource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_SHADER_RESOURCE")]
        BarrierLayoutShaderResource = 0x6,
        [Obsolete("Deprecated in favour of \"CopySource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COPY_SOURCE")]
        BarrierLayoutCopySource = 0x7,
        [Obsolete("Deprecated in favour of \"CopyDest\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COPY_DEST")]
        BarrierLayoutCopyDest = 0x8,
        [Obsolete("Deprecated in favour of \"ResolveSource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RESOLVE_SOURCE")]
        BarrierLayoutResolveSource = 0x9,
        [Obsolete("Deprecated in favour of \"ResolveDest\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RESOLVE_DEST")]
        BarrierLayoutResolveDest = 0xA,
        [Obsolete("Deprecated in favour of \"ShadingRateSource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_SHADING_RATE_SOURCE")]
        BarrierLayoutShadingRateSource = 0xB,
        [Obsolete("Deprecated in favour of \"VideoDecodeRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_DECODE_READ")]
        BarrierLayoutVideoDecodeRead = 0xC,
        [Obsolete("Deprecated in favour of \"VideoDecodeWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_DECODE_WRITE")]
        BarrierLayoutVideoDecodeWrite = 0xD,
        [Obsolete("Deprecated in favour of \"VideoProcessRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_READ")]
        BarrierLayoutVideoProcessRead = 0xE,
        [Obsolete("Deprecated in favour of \"VideoProcessWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_WRITE")]
        BarrierLayoutVideoProcessWrite = 0xF,
        [Obsolete("Deprecated in favour of \"VideoEncodeRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ")]
        BarrierLayoutVideoEncodeRead = 0x10,
        [Obsolete("Deprecated in favour of \"VideoEncodeWrite\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE")]
        BarrierLayoutVideoEncodeWrite = 0x11,
        [Obsolete("Deprecated in favour of \"DirectQueueCommon\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COMMON")]
        BarrierLayoutDirectQueueCommon = 0x12,
        [Obsolete("Deprecated in favour of \"DirectQueueGenericRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ")]
        BarrierLayoutDirectQueueGenericRead = 0x13,
        [Obsolete("Deprecated in favour of \"DirectQueueUnorderedAccess\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_UNORDERED_ACCESS")]
        BarrierLayoutDirectQueueUnorderedAccess = 0x14,
        [Obsolete("Deprecated in favour of \"DirectQueueShaderResource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_SHADER_RESOURCE")]
        BarrierLayoutDirectQueueShaderResource = 0x15,
        [Obsolete("Deprecated in favour of \"DirectQueueCopySource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_SOURCE")]
        BarrierLayoutDirectQueueCopySource = 0x16,
        [Obsolete("Deprecated in favour of \"DirectQueueCopyDest\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_DEST")]
        BarrierLayoutDirectQueueCopyDest = 0x17,
        [Obsolete("Deprecated in favour of \"ComputeQueueCommon\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COMMON")]
        BarrierLayoutComputeQueueCommon = 0x18,
        [Obsolete("Deprecated in favour of \"ComputeQueueGenericRead\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_GENERIC_READ")]
        BarrierLayoutComputeQueueGenericRead = 0x19,
        [Obsolete("Deprecated in favour of \"ComputeQueueUnorderedAccess\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_UNORDERED_ACCESS")]
        BarrierLayoutComputeQueueUnorderedAccess = 0x1A,
        [Obsolete("Deprecated in favour of \"ComputeQueueShaderResource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_SHADER_RESOURCE")]
        BarrierLayoutComputeQueueShaderResource = 0x1B,
        [Obsolete("Deprecated in favour of \"ComputeQueueCopySource\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_SOURCE")]
        BarrierLayoutComputeQueueCopySource = 0x1C,
        [Obsolete("Deprecated in favour of \"ComputeQueueCopyDest\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_DEST")]
        BarrierLayoutComputeQueueCopyDest = 0x1D,
        [Obsolete("Deprecated in favour of \"DirectQueueGenericReadComputeQueueAccessible\"")]
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ_COMPUTE_QUEUE_ACCESSIBLE")]
        BarrierLayoutDirectQueueGenericReadComputeQueueAccessible = 0x1F,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_UNDEFINED")]
        Undefined = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMMON")]
        Common = 0x0,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_PRESENT")]
        Present = 0x0,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_GENERIC_READ")]
        GenericRead = 0x1,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RENDER_TARGET")]
        RenderTarget = 0x2,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_UNORDERED_ACCESS")]
        UnorderedAccess = 0x3,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_WRITE")]
        DepthStencilWrite = 0x4,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_READ")]
        DepthStencilRead = 0x5,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_SHADER_RESOURCE")]
        ShaderResource = 0x6,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COPY_SOURCE")]
        CopySource = 0x7,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COPY_DEST")]
        CopyDest = 0x8,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RESOLVE_SOURCE")]
        ResolveSource = 0x9,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_RESOLVE_DEST")]
        ResolveDest = 0xA,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_SHADING_RATE_SOURCE")]
        ShadingRateSource = 0xB,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_DECODE_READ")]
        VideoDecodeRead = 0xC,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_DECODE_WRITE")]
        VideoDecodeWrite = 0xD,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_READ")]
        VideoProcessRead = 0xE,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_WRITE")]
        VideoProcessWrite = 0xF,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ")]
        VideoEncodeRead = 0x10,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE")]
        VideoEncodeWrite = 0x11,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COMMON")]
        DirectQueueCommon = 0x12,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ")]
        DirectQueueGenericRead = 0x13,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_UNORDERED_ACCESS")]
        DirectQueueUnorderedAccess = 0x14,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_SHADER_RESOURCE")]
        DirectQueueShaderResource = 0x15,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_SOURCE")]
        DirectQueueCopySource = 0x16,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_DEST")]
        DirectQueueCopyDest = 0x17,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COMMON")]
        ComputeQueueCommon = 0x18,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_GENERIC_READ")]
        ComputeQueueGenericRead = 0x19,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_UNORDERED_ACCESS")]
        ComputeQueueUnorderedAccess = 0x1A,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_SHADER_RESOURCE")]
        ComputeQueueShaderResource = 0x1B,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_SOURCE")]
        ComputeQueueCopySource = 0x1C,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_DEST")]
        ComputeQueueCopyDest = 0x1D,
        [NativeName("Name", "D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ_COMPUTE_QUEUE_ACCESSIBLE")]
        DirectQueueGenericReadComputeQueueAccessible = 0x1F,
    }
}
