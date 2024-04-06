// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum OcclusionQueryEventMaskAMD
{
    DepthPassEventBit = 0x00000001,
    DepthFailEventBit = 0x00000002,
    StencilFailEventBit = 0x00000004,
    DepthBoundsFailEventBit = 0x00000008,
    AllEventBits = 0xFFFFFFFF
}
