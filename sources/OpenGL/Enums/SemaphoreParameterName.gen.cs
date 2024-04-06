// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum SemaphoreParameterName
{
    D3D12FenceValueEXT = 0x9595,
    TimelineSemaphoreValueNV = 0x9595,
    SemaphoreTypeNV = 0x95B3,
    SemaphoreTypeBinaryNV = 0x95B4,
    SemaphoreTypeTimelineNV = 0x95B5
}
