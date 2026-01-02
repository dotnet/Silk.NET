// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ConditionalRenderMode : uint
{
    Wait = unchecked((uint)0x8E13),
    NoWait = unchecked((uint)0x8E14),
    ByRegionWait = unchecked((uint)0x8E15),
    ByRegionNoWait = unchecked((uint)0x8E16),
    WaitInverted = unchecked((uint)0x8E17),
    NoWaitInverted = unchecked((uint)0x8E18),
    ByRegionWaitInverted = unchecked((uint)0x8E19),
    ByRegionNoWaitInverted = unchecked((uint)0x8E1A),
}
