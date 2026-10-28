// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClearColorValue")]
[StructLayout(LayoutKind.Explicit)]
public partial struct ClearColorValue
{
    [NativeName("float32")]
    [FieldOffset(0)]
    public ClearColorValueFloat32 Float32;

    [NativeName("int32")]
    [FieldOffset(0)]
    public ClearColorValueInt32 Int32;

    [NativeName("uint32")]
    [FieldOffset(0)]
    public ClearColorValueUint32 Uint32;
}
