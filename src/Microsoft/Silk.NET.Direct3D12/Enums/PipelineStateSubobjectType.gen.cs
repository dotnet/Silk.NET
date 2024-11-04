// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE")]
    public enum PipelineStateSubobjectType : int
    {
        [Obsolete("Deprecated in favour of \"RootSignature\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE")]
        PipelineStateSubobjectTypeRootSignature = 0x0,
        [Obsolete("Deprecated in favour of \"VS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS")]
        PipelineStateSubobjectTypeVS = 0x1,
        [Obsolete("Deprecated in favour of \"PS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS")]
        PipelineStateSubobjectTypePS = 0x2,
        [Obsolete("Deprecated in favour of \"DS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS")]
        PipelineStateSubobjectTypeDS = 0x3,
        [Obsolete("Deprecated in favour of \"HS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS")]
        PipelineStateSubobjectTypeHS = 0x4,
        [Obsolete("Deprecated in favour of \"GS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS")]
        PipelineStateSubobjectTypeGS = 0x5,
        [Obsolete("Deprecated in favour of \"CS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS")]
        PipelineStateSubobjectTypeCS = 0x6,
        [Obsolete("Deprecated in favour of \"StreamOutput\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT")]
        PipelineStateSubobjectTypeStreamOutput = 0x7,
        [Obsolete("Deprecated in favour of \"Blend\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND")]
        PipelineStateSubobjectTypeBlend = 0x8,
        [Obsolete("Deprecated in favour of \"SampleMask\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK")]
        PipelineStateSubobjectTypeSampleMask = 0x9,
        [Obsolete("Deprecated in favour of \"Rasterizer\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER")]
        PipelineStateSubobjectTypeRasterizer = 0xA,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL")]
        PipelineStateSubobjectTypeDepthStencil = 0xB,
        [Obsolete("Deprecated in favour of \"InputLayout\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT")]
        PipelineStateSubobjectTypeInputLayout = 0xC,
        [Obsolete("Deprecated in favour of \"IBStripCutValue\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE")]
        PipelineStateSubobjectTypeIBStripCutValue = 0xD,
        [Obsolete("Deprecated in favour of \"PrimitiveTopology\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY")]
        PipelineStateSubobjectTypePrimitiveTopology = 0xE,
        [Obsolete("Deprecated in favour of \"RenderTargetFormats\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS")]
        PipelineStateSubobjectTypeRenderTargetFormats = 0xF,
        [Obsolete("Deprecated in favour of \"DepthStencilFormat\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT")]
        PipelineStateSubobjectTypeDepthStencilFormat = 0x10,
        [Obsolete("Deprecated in favour of \"SampleDesc\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC")]
        PipelineStateSubobjectTypeSampleDesc = 0x11,
        [Obsolete("Deprecated in favour of \"NodeMask\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        PipelineStateSubobjectTypeNodeMask = 0x12,
        [Obsolete("Deprecated in favour of \"CachedPso\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO")]
        PipelineStateSubobjectTypeCachedPso = 0x13,
        [Obsolete("Deprecated in favour of \"Flags\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS")]
        PipelineStateSubobjectTypeFlags = 0x14,
        [Obsolete("Deprecated in favour of \"DepthStencil1\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1")]
        PipelineStateSubobjectTypeDepthStencil1 = 0x15,
        [Obsolete("Deprecated in favour of \"ViewInstancing\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING")]
        PipelineStateSubobjectTypeViewInstancing = 0x16,
        [Obsolete("Deprecated in favour of \"As\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS")]
        PipelineStateSubobjectTypeAs = 0x18,
        [Obsolete("Deprecated in favour of \"MS\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS")]
        PipelineStateSubobjectTypeMS = 0x19,
        [Obsolete("Deprecated in favour of \"DepthStencil2\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2")]
        PipelineStateSubobjectTypeDepthStencil2 = 0x1A,
        [Obsolete("Deprecated in favour of \"Rasterizer1\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1")]
        PipelineStateSubobjectTypeRasterizer1 = 0x1B,
        [Obsolete("Deprecated in favour of \"Rasterizer2\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2")]
        PipelineStateSubobjectTypeRasterizer2 = 0x1C,
        [Obsolete("Deprecated in favour of \"MaxValid\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        PipelineStateSubobjectTypeMaxValid = 0x1D,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE")]
        RootSignature = 0x0,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS")]
        VS = 0x1,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS")]
        PS = 0x2,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS")]
        DS = 0x3,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS")]
        HS = 0x4,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS")]
        GS = 0x5,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS")]
        CS = 0x6,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT")]
        StreamOutput = 0x7,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND")]
        Blend = 0x8,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK")]
        SampleMask = 0x9,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER")]
        Rasterizer = 0xA,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL")]
        DepthStencil = 0xB,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT")]
        InputLayout = 0xC,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE")]
        IBStripCutValue = 0xD,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY")]
        PrimitiveTopology = 0xE,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS")]
        RenderTargetFormats = 0xF,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT")]
        DepthStencilFormat = 0x10,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC")]
        SampleDesc = 0x11,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        NodeMask = 0x12,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO")]
        CachedPso = 0x13,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS")]
        Flags = 0x14,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1")]
        DepthStencil1 = 0x15,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING")]
        ViewInstancing = 0x16,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS")]
        As = 0x18,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS")]
        MS = 0x19,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2")]
        DepthStencil2 = 0x1A,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1")]
        Rasterizer1 = 0x1B,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2")]
        Rasterizer2 = 0x1C,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        MaxValid = 0x1D,
    }
}
