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
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_NONE")]
        RootSignatureFlagNone = 0x0,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT")]
        RootSignatureFlagAllowInputAssemblerInputLayout = 0x1,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyVertexShaderRootAccess = 0x2,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyHullShaderRootAccess = 0x4,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyDomainShaderRootAccess = 0x8,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyGeometryShaderRootAccess = 0x10,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyPixelShaderRootAccess = 0x20,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT")]
        RootSignatureFlagAllowStreamOutput = 0x40,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE")]
        RootSignatureFlagLocalRootSignature = 0x80,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyAmplificationShaderRootAccess = 0x100,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS")]
        RootSignatureFlagDenyMeshShaderRootAccess = 0x200,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_CBV_SRV_UAV_HEAP_DIRECTLY_INDEXED")]
        RootSignatureFlagCbvSrvUavHeapDirectlyIndexed = 0x400,
        [NativeName("Name", "D3D12_ROOT_SIGNATURE_FLAG_SAMPLER_HEAP_DIRECTLY_INDEXED")]
        RootSignatureFlagSamplerHeapDirectlyIndexed = 0x800,
    }
}
