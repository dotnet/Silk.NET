// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct4x8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct4x8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct4x8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProduct64BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
