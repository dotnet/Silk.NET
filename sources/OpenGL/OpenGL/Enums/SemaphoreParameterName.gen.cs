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
    D3D12FenceValueEXT = 38293,

    [NativeName("GL_TIMELINE_SEMAPHORE_VALUE_NV")]
    TimelineSemaphoreValueNV = 38293,

    [NativeName("GL_SEMAPHORE_TYPE_NV")]
    SemaphoreTypeNV = 38323,

    [NativeName("GL_SEMAPHORE_TYPE_BINARY_NV")]
    SemaphoreTypeBinaryNV = 38324,

    [NativeName("GL_SEMAPHORE_TYPE_TIMELINE_NV")]
    SemaphoreTypeTimelineNV = 38325,
}
