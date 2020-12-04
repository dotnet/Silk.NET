// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE")]
    public enum StateSubobjectType
    {
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG")]
        StateSubobjectTypeStateObjectConfig = 0x0,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE")]
        StateSubobjectTypeGlobalRootSignature = 0x1,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE")]
        StateSubobjectTypeLocalRootSignature = 0x2,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK")]
        StateSubobjectTypeNodeMask = 0x3,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY")]
        StateSubobjectTypeDxilLibrary = 0x5,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION")]
        StateSubobjectTypeExistingCollection = 0x6,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        StateSubobjectTypeSubobjectToExportsAssociation = 0x7,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
        StateSubobjectTypeDxilSubobjectToExportsAssociation = 0x8,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG")]
        StateSubobjectTypeRaytracingShaderConfig = 0x9,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG")]
        StateSubobjectTypeRaytracingPipelineConfig = 0xA,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP")]
        StateSubobjectTypeHitGroup = 0xB,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1")]
        StateSubobjectTypeRaytracingPipelineConfig1 = 0xC,
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        StateSubobjectTypeMaxValid = 0xD,
    }
}
