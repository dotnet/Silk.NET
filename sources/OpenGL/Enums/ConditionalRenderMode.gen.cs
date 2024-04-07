// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ConditionalRenderMode : uint
{
    Wait = 0x8E13,
    NoWait = 0x8E14,
    ByRegionWait = 0x8E15,
    ByRegionNoWait = 0x8E16,
    WaitInverted = 0x8E17,
    NoWaitInverted = 0x8E18,
    ByRegionWaitInverted = 0x8E19,
    ByRegionNoWaitInverted = 0x8E1A
}
