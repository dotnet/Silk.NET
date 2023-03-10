// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAGS")]
    public enum RootSignatureFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_NONE")]
        RootSignatureFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowInputAssemblerInputLayout\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT")]
        RootSignatureFlagAllowInputAssemblerInputLayout = 0x1,
        [Obsolete("Deprecated in favour of \"DenyVertexShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyVertexShaderRootAccess = 0x2,
        [Obsolete("Deprecated in favour of \"DenyHullShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyHullShaderRootAccess = 0x4,
        [Obsolete("Deprecated in favour of \"DenyDomainShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyDomainShaderRootAccess = 0x8,
        [Obsolete("Deprecated in favour of \"DenyGeometryShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyGeometryShaderRootAccess = 0x10,
        [Obsolete("Deprecated in favour of \"DenyPixelShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyPixelShaderRootAccess = 0x20,
        [Obsolete("Deprecated in favour of \"AllowStreamOutput\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT")]
        RootSignatureFlagAllowStreamOutput = 0x40,
        [Obsolete("Deprecated in favour of \"LocalRootSignature\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE")]
        RootSignatureFlagLocalRootSignature = 0x80,
        [Obsolete("Deprecated in favour of \"DenyAmplificationShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyAmplificationShaderRootAccess = 0x100,
        [Obsolete("Deprecated in favour of \"DenyMeshShaderRootAccess\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyMeshShaderRootAccess = 0x200,
        [Obsolete("Deprecated in favour of \"CbvSrvUavHeapDirectlyIndexed\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_CBV_SRV_UAV_HEAP_DIRECTLY_INDEXED")]
        RootSignatureFlagCbvSrvUavHeapDirectlyIndexed = 0x400,
        [Obsolete("Deprecated in favour of \"SamplerHeapDirectlyIndexed\"")]
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_SAMPLER_HEAP_DIRECTLY_INDEXED")]
        RootSignatureFlagSamplerHeapDirectlyIndexed = 0x800,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT")]
        AllowInputAssemblerInputLayout = 0x1,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS")]
        DenyVertexShaderRootAccess = 0x2,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS")]
        DenyHullShaderRootAccess = 0x4,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS")]
        DenyDomainShaderRootAccess = 0x8,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS")]
        DenyGeometryShaderRootAccess = 0x10,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS")]
        DenyPixelShaderRootAccess = 0x20,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT")]
        AllowStreamOutput = 0x40,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE")]
        LocalRootSignature = 0x80,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS")]
        DenyAmplificationShaderRootAccess = 0x100,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS")]
        DenyMeshShaderRootAccess = 0x200,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_CBV_SRV_UAV_HEAP_DIRECTLY_INDEXED")]
        CbvSrvUavHeapDirectlyIndexed = 0x400,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_SAMPLER_HEAP_DIRECTLY_INDEXED")]
        SamplerHeapDirectlyIndexed = 0x800,
    }
}
