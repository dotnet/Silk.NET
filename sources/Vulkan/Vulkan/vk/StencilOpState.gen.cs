// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkStencilOpState")]
public partial struct StencilOpState
{
    [NativeName("failOp")]
    public StencilOp FailOp;

    [NativeName("passOp")]
    public StencilOp PassOp;

    [NativeName("depthFailOp")]
    public StencilOp DepthFailOp;

    [NativeName("compareOp")]
    public CompareOp CompareOp;

    [NativeName("compareMask")]
    public uint CompareMask;

    [NativeName("writeMask")]
    public uint WriteMask;

    [NativeName("reference")]
    public uint Reference;
}
