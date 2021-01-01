// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE")]
    public enum PipelineStateSubobjectType : int
    {
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE")]
        PipelineStateSubobjectTypeRootSignature = 0x0,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS")]
        PipelineStateSubobjectTypeVS = 0x1,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS")]
        PipelineStateSubobjectTypePS = 0x2,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS")]
        PipelineStateSubobjectTypeDS = 0x3,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS")]
        PipelineStateSubobjectTypeHS = 0x4,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS")]
        PipelineStateSubobjectTypeGS = 0x5,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS")]
        PipelineStateSubobjectTypeCS = 0x6,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT")]
        PipelineStateSubobjectTypeStreamOutput = 0x7,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND")]
        PipelineStateSubobjectTypeBlend = 0x8,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK")]
        PipelineStateSubobjectTypeSampleMask = 0x9,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER")]
        PipelineStateSubobjectTypeRasterizer = 0xA,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL")]
        PipelineStateSubobjectTypeDepthStencil = 0xB,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT")]
        PipelineStateSubobjectTypeInputLayout = 0xC,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE")]
        PipelineStateSubobjectTypeIBStripCutValue = 0xD,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY")]
        PipelineStateSubobjectTypePrimitiveTopology = 0xE,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS")]
        PipelineStateSubobjectTypeRenderTargetFormats = 0xF,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT")]
        PipelineStateSubobjectTypeDepthStencilFormat = 0x10,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC")]
        PipelineStateSubobjectTypeSampleDesc = 0x11,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        PipelineStateSubobjectTypeNodeMask = 0x12,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO")]
        PipelineStateSubobjectTypeCachedPso = 0x13,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS")]
        PipelineStateSubobjectTypeFlags = 0x14,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1")]
        PipelineStateSubobjectTypeDepthStencil1 = 0x15,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING")]
        PipelineStateSubobjectTypeViewInstancing = 0x16,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS")]
        PipelineStateSubobjectTypeAs = 0x18,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS")]
        PipelineStateSubobjectTypeMS = 0x19,
        [NativeName("Name", "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        PipelineStateSubobjectTypeMaxValid = 0x1A,
    }
}
