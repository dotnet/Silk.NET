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
        [Obsolete("Deprecated in favour of \"MaxValid\"")]
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        StateSubobjectTypeMaxValid = 0xD,
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
        [NativeName("Name", "D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID")]
        MaxValid = 0xD,
    }
}
