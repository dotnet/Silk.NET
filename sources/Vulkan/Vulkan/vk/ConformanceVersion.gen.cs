// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConformanceVersion")]
public partial struct ConformanceVersion
{
    [NativeName("major")]
    public byte Major;

    [NativeName("minor")]
    public byte Minor;

    [NativeName("subminor")]
    public byte Subminor;

    [NativeName("patch")]
    public byte Patch;
}
