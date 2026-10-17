// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingD3D12KHR")]
public unsafe partial struct GraphicsBindingD3D12KHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.GraphicsBindingD3D12KHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("device")]
    public Id3D12DeviceHandle Device;

    [NativeName("queue")]
    public Id3D12CommandQueueHandle Queue;

    public GraphicsBindingD3D12KHR() { }
}
