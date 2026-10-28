// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkViewport")]
public partial struct Viewport
{
    [NativeName("x")]
    public float X;

    [NativeName("y")]
    public float Y;

    [NativeName("width")]
    public float Width;

    [NativeName("height")]
    public float Height;

    [NativeName("minDepth")]
    public float MinDepth;

    [NativeName("maxDepth")]
    public float MaxDepth;
}
