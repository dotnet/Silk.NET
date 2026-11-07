// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceFaultAddressTypeKHR")]
public enum DeviceFaultAddressTypeKHR : uint
{
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_KHR")]
    None = 0,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_KHR")]
    ReadInvalid = 1,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_KHR")]
    WriteInvalid = 2,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_KHR")]
    ExecuteInvalid = 3,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_KHR")]
    InstructionPointerUnknown = 4,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_KHR")]
    InstructionPointerInvalid = 5,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_KHR")]
    InstructionPointerFault = 6,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT")]
    NoneEXT = None,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT")]
    ReadInvalidEXT = ReadInvalid,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT")]
    WriteInvalidEXT = WriteInvalid,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT")]
    ExecuteInvalidEXT = ExecuteInvalid,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT")]
    InstructionPointerUnknownEXT = InstructionPointerUnknown,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT")]
    InstructionPointerInvalidEXT = InstructionPointerInvalid,

    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT")]
    InstructionPointerFaultEXT = InstructionPointerFault,
}
