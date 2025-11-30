// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkExternalImageFormatPropertiesNV")]
[SupportedApiProfile("vulkan")]
public partial struct ExternalImageFormatPropertiesNv
{
    [NativeName("imageFormatProperties")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public ImageFormatProperties ImageFormatProperties;

    [NativeName("externalMemoryFeatures")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public ExternalMemoryFeatureFlagsNv ExternalMemoryFeatures;

    [NativeName("exportFromImportedHandleTypes")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public ExternalMemoryHandleTypeFlagsNv ExportFromImportedHandleTypes;

    [NativeName("compatibleHandleTypes")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public ExternalMemoryHandleTypeFlagsNv CompatibleHandleTypes;
}
