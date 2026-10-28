// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphModelCacheTypeQCOM")]
public enum DataGraphModelCacheTypeQCOM : uint
{
    [NativeName("VK_DATA_GRAPH_MODEL_CACHE_TYPE_GENERIC_BINARY_QCOM")]
    GenericBinary = 0,
}
