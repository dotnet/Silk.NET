// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatProperties")]
public partial struct FormatProperties
{
    [NativeName("linearTilingFeatures")]
    public FormatFeatureFlags LinearTilingFeatures;

    [NativeName("optimalTilingFeatures")]
    public FormatFeatureFlags OptimalTilingFeatures;

    [NativeName("bufferFeatures")]
    public FormatFeatureFlags BufferFeatures;
}
