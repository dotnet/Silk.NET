// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDrawMeshTasksIndirectCommandEXT")]
public partial struct DrawMeshTasksIndirectCommandEXT
{
    [NativeName("groupCountX")]
    public uint GroupCountX;

    [NativeName("groupCountY")]
    public uint GroupCountY;

    [NativeName("groupCountZ")]
    public uint GroupCountZ;
}
