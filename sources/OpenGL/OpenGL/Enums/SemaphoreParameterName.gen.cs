// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SemaphoreParameterName : uint
{
    D3D12FenceValueEXT = unchecked((uint)0x9595),
    TimelineSemaphoreValueNV = unchecked((uint)0x9595),
    SemaphoreTypeNV = unchecked((uint)0x95B3),
    SemaphoreTypeBinaryNV = unchecked((uint)0x95B4),
    SemaphoreTypeTimelineNV = unchecked((uint)0x95B5),
}
