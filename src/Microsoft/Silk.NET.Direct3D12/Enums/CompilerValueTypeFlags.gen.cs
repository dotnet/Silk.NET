// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS")]
    public enum CompilerValueTypeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_NONE")]
        CompilerValueTypeFlagsNone = 0x0,
        [Obsolete("Deprecated in favour of \"ObjectCode\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_OBJECT_CODE")]
        CompilerValueTypeFlagsObjectCode = 0x1,
        [Obsolete("Deprecated in favour of \"Metadata\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_METADATA")]
        CompilerValueTypeFlagsMetadata = 0x2,
        [Obsolete("Deprecated in favour of \"DebugPdb\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_DEBUG_PDB")]
        CompilerValueTypeFlagsDebugPdb = 0x4,
        [Obsolete("Deprecated in favour of \"PerformanceData\"")]
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_PERFORMANCE_DATA")]
        CompilerValueTypeFlagsPerformanceData = 0x8,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_OBJECT_CODE")]
        ObjectCode = 0x1,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_METADATA")]
        Metadata = 0x2,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_DEBUG_PDB")]
        DebugPdb = 0x4,
        [NativeName("Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS_PERFORMANCE_DATA")]
        PerformanceData = 0x8,
    }
}
