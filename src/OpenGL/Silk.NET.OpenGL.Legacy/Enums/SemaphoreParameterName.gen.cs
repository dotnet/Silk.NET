// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SemaphoreParameterName")]
    public enum SemaphoreParameterName : int
    {
        [NativeName("Name", "GL_D3D12_FENCE_VALUE_EXT")]
        D3D12FenceValueExt = 0x9595,
        [NativeName("Name", "GL_TIMELINE_SEMAPHORE_VALUE_NV")]
        TimelineSemaphoreValueNV = 0x9595,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_NV")]
        SemaphoreTypeNV = 0x95B3,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_BINARY_NV")]
        SemaphoreTypeBinaryNV = 0x95B4,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_TIMELINE_NV")]
        SemaphoreTypeTimelineNV = 0x95B5,
    }
}
