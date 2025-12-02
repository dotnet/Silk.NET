// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SemaphoreParameterName")]
public enum SemaphoreParameterName : uint
{
    [NativeName("GL_D3D12_FENCE_VALUE_EXT")]
    D3D12FenceValueEXT = unchecked((uint)0x9595),

    [NativeName("GL_TIMELINE_SEMAPHORE_VALUE_NV")]
    TimelineSemaphoreValueNV = unchecked((uint)0x9595),

    [NativeName("GL_SEMAPHORE_TYPE_NV")]
    SemaphoreTypeNV = unchecked((uint)0x95B3),

    [NativeName("GL_SEMAPHORE_TYPE_BINARY_NV")]
    SemaphoreTypeBinaryNV = unchecked((uint)0x95B4),

    [NativeName("GL_SEMAPHORE_TYPE_TIMELINE_NV")]
    SemaphoreTypeTimelineNV = unchecked((uint)0x95B5),
}
