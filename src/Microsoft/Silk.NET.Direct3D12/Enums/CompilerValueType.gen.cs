// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE")]
    public enum CompilerValueType : int
    {
        [Obsolete("Deprecated in favour of \"ObjectCode\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_OBJECT_CODE")]
        CompilerValueTypeObjectCode = 0x0,
        [Obsolete("Deprecated in favour of \"Metadata\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_METADATA")]
        CompilerValueTypeMetadata = 0x1,
        [Obsolete("Deprecated in favour of \"DebugPdb\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_DEBUG_PDB")]
        CompilerValueTypeDebugPdb = 0x2,
        [Obsolete("Deprecated in favour of \"PerformanceData\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_PERFORMANCE_DATA")]
        CompilerValueTypePerformanceData = 0x3,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_OBJECT_CODE")]
        ObjectCode = 0x0,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_METADATA")]
        Metadata = 0x1,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_DEBUG_PDB")]
        DebugPdb = 0x2,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_PERFORMANCE_DATA")]
        PerformanceData = 0x3,
    }
}
