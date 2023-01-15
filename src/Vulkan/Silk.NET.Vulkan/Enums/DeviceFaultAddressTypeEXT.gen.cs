// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceFaultAddressTypeEXT")]
    public enum DeviceFaultAddressTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"NoneExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT")]
        DeviceFaultAddressTypeNoneExt = 0,
        [Obsolete("Deprecated in favour of \"ReadInvalidExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT")]
        DeviceFaultAddressTypeReadInvalidExt = 1,
        [Obsolete("Deprecated in favour of \"WriteInvalidExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT")]
        DeviceFaultAddressTypeWriteInvalidExt = 2,
        [Obsolete("Deprecated in favour of \"ExecuteInvalidExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT")]
        DeviceFaultAddressTypeExecuteInvalidExt = 3,
        [Obsolete("Deprecated in favour of \"InstructionPointerUnknownExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT")]
        DeviceFaultAddressTypeInstructionPointerUnknownExt = 4,
        [Obsolete("Deprecated in favour of \"InstructionPointerInvalidExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT")]
        DeviceFaultAddressTypeInstructionPointerInvalidExt = 5,
        [Obsolete("Deprecated in favour of \"InstructionPointerFaultExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT")]
        DeviceFaultAddressTypeInstructionPointerFaultExt = 6,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT")]
        NoneExt = 0,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT")]
        ReadInvalidExt = 1,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT")]
        WriteInvalidExt = 2,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT")]
        ExecuteInvalidExt = 3,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT")]
        InstructionPointerUnknownExt = 4,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT")]
        InstructionPointerInvalidExt = 5,
        [NativeName("Name", "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT")]
        InstructionPointerFaultExt = 6,
    }
}
