// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING")]
    public enum ShaderComponentMapping : int
    {
        [Obsolete("Deprecated in favour of \"FromMemoryComponent0\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_0")]
        ShaderComponentMappingFromMemoryComponent0 = 0x0,
        [Obsolete("Deprecated in favour of \"FromMemoryComponent1\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_1")]
        ShaderComponentMappingFromMemoryComponent1 = 0x1,
        [Obsolete("Deprecated in favour of \"FromMemoryComponent2\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_2")]
        ShaderComponentMappingFromMemoryComponent2 = 0x2,
        [Obsolete("Deprecated in favour of \"FromMemoryComponent3\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_3")]
        ShaderComponentMappingFromMemoryComponent3 = 0x3,
        [Obsolete("Deprecated in favour of \"ForceValue0\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_0")]
        ShaderComponentMappingForceValue0 = 0x4,
        [Obsolete("Deprecated in favour of \"ForceValue1\"")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_1")]
        ShaderComponentMappingForceValue1 = 0x5,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_0")]
        FromMemoryComponent0 = 0x0,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_1")]
        FromMemoryComponent1 = 0x1,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_2")]
        FromMemoryComponent2 = 0x2,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FROM_MEMORY_COMPONENT_3")]
        FromMemoryComponent3 = 0x3,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_0")]
        ForceValue0 = 0x4,
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_FORCE_VALUE_1")]
        ForceValue1 = 0x5,
    }
}
