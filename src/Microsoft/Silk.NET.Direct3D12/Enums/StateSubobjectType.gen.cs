// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE")]
    public enum StateSubobjectType : int
    {
        [Obsolete("Deprecated in favour of \"StateObjectConfig\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG")]
        StateSubobjectTypeStateObjectConfig = 0x0,
        [Obsolete("Deprecated in favour of \"GlobalRootSignature\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE")]
        StateSubobjectTypeGlobalRootSignature = 0x1,
        [Obsolete("Deprecated in favour of \"LocalRootSignature\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE")]
        StateSubobjectTypeLocalRootSignature = 0x2,
        [Obsolete("Deprecated in favour of \"NodeMask\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        StateSubobjectTypeNodeMask = 0x3,
        [Obsolete("Deprecated in favour of \"DxilLibrary\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY")]
        StateSubobjectTypeDxilLibrary = 0x5,
        [Obsolete("Deprecated in favour of \"ExistingCollection\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION")]
        StateSubobjectTypeExistingCollection = 0x6,
        [Obsolete("Deprecated in favour of \"SubobjectToExportsAssociation\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        StateSubobjectTypeSubobjectToExportsAssociation = 0x7,
        [Obsolete("Deprecated in favour of \"DxilSubobjectToExportsAssociation\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        StateSubobjectTypeDxilSubobjectToExportsAssociation = 0x8,
        [Obsolete("Deprecated in favour of \"RaytracingShaderConfig\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG")]
        StateSubobjectTypeRaytracingShaderConfig = 0x9,
        [Obsolete("Deprecated in favour of \"RaytracingPipelineConfig\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG")]
        StateSubobjectTypeRaytracingPipelineConfig = 0xA,
        [Obsolete("Deprecated in favour of \"HitGroup\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP")]
        StateSubobjectTypeHitGroup = 0xB,
        [Obsolete("Deprecated in favour of \"RaytracingPipelineConfig1\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1")]
        StateSubobjectTypeRaytracingPipelineConfig1 = 0xC,
        [Obsolete("Deprecated in favour of \"WorkGraph\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_WORK_GRAPH")]
        StateSubobjectTypeWorkGraph = 0xD,
        [Obsolete("Deprecated in favour of \"StreamOutput\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT")]
        StateSubobjectTypeStreamOutput = 0xE,
        [Obsolete("Deprecated in favour of \"Blend\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_BLEND")]
        StateSubobjectTypeBlend = 0xF,
        [Obsolete("Deprecated in favour of \"SampleMask\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_MASK")]
        StateSubobjectTypeSampleMask = 0x10,
        [Obsolete("Deprecated in favour of \"Rasterizer\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RASTERIZER")]
        StateSubobjectTypeRasterizer = 0x11,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL")]
        StateSubobjectTypeDepthStencil = 0x12,
        [Obsolete("Deprecated in favour of \"InputLayout\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT")]
        StateSubobjectTypeInputLayout = 0x13,
        [Obsolete("Deprecated in favour of \"IBStripCutValue\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE")]
        StateSubobjectTypeIBStripCutValue = 0x14,
        [Obsolete("Deprecated in favour of \"PrimitiveTopology\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY")]
        StateSubobjectTypePrimitiveTopology = 0x15,
        [Obsolete("Deprecated in favour of \"RenderTargetFormats\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS")]
        StateSubobjectTypeRenderTargetFormats = 0x16,
        [Obsolete("Deprecated in favour of \"DepthStencilFormat\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT")]
        StateSubobjectTypeDepthStencilFormat = 0x17,
        [Obsolete("Deprecated in favour of \"SampleDesc\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_DESC")]
        StateSubobjectTypeSampleDesc = 0x18,
        [Obsolete("Deprecated in favour of \"Flags\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_FLAGS")]
        StateSubobjectTypeFlags = 0x1A,
        [Obsolete("Deprecated in favour of \"DepthStencil1\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1")]
        StateSubobjectTypeDepthStencil1 = 0x1B,
        [Obsolete("Deprecated in favour of \"ViewInstancing\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING")]
        StateSubobjectTypeViewInstancing = 0x1C,
        [Obsolete("Deprecated in favour of \"GenericProgram\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_GENERIC_PROGRAM")]
        StateSubobjectTypeGenericProgram = 0x1D,
        [Obsolete("Deprecated in favour of \"DepthStencil2\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2")]
        StateSubobjectTypeDepthStencil2 = 0x1E,
        [Obsolete("Deprecated in favour of \"MaxValid\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        StateSubobjectTypeMaxValid = 0x1F,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG")]
        StateObjectConfig = 0x0,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE")]
        GlobalRootSignature = 0x1,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE")]
        LocalRootSignature = 0x2,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        NodeMask = 0x3,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY")]
        DxilLibrary = 0x5,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION")]
        ExistingCollection = 0x6,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        SubobjectToExportsAssociation = 0x7,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        DxilSubobjectToExportsAssociation = 0x8,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG")]
        RaytracingShaderConfig = 0x9,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG")]
        RaytracingPipelineConfig = 0xA,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP")]
        HitGroup = 0xB,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1")]
        RaytracingPipelineConfig1 = 0xC,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_WORK_GRAPH")]
        WorkGraph = 0xD,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT")]
        StreamOutput = 0xE,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_BLEND")]
        Blend = 0xF,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_MASK")]
        SampleMask = 0x10,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RASTERIZER")]
        Rasterizer = 0x11,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL")]
        DepthStencil = 0x12,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT")]
        InputLayout = 0x13,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE")]
        IBStripCutValue = 0x14,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY")]
        PrimitiveTopology = 0x15,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS")]
        RenderTargetFormats = 0x16,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT")]
        DepthStencilFormat = 0x17,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_DESC")]
        SampleDesc = 0x18,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_FLAGS")]
        Flags = 0x1A,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1")]
        DepthStencil1 = 0x1B,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING")]
        ViewInstancing = 0x1C,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_GENERIC_PROGRAM")]
        GenericProgram = 0x1D,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2")]
        DepthStencil2 = 0x1E,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        MaxValid = 0x1F,
    }
}
