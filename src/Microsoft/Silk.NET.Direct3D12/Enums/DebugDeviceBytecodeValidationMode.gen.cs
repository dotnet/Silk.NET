// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_MODE")]
    public enum DebugDeviceBytecodeValidationMode : int
    {
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_DISABLED")]
        DebugDeviceBytecodeValidationDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"WhenHashBypassed\"")]
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_WHEN_HASH_BYPASSED")]
        DebugDeviceBytecodeValidationWhenHashBypassed = 0x1,
        [Obsolete("Deprecated in favour of \"AllBytecode\"")]
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_ALL_BYTECODE")]
        DebugDeviceBytecodeValidationAllBytecode = 0x2,
        [Obsolete("Deprecated in favour of \"ModeDefault\"")]
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_MODE_DEFAULT")]
        DebugDeviceBytecodeValidationModeDefault = 0x1,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_DISABLED")]
        Disabled = 0x0,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_WHEN_HASH_BYPASSED")]
        WhenHashBypassed = 0x1,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_ALL_BYTECODE")]
        AllBytecode = 0x2,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_BYTECODE_VALIDATION_MODE_DEFAULT")]
        ModeDefault = 0x1,
    }
}
