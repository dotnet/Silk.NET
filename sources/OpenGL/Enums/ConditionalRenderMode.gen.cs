// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum ConditionalRenderMode
{
    QueryWait = 0x8E13,
    QueryNoWait = 0x8E14,
    QueryByRegionWait = 0x8E15,
    QueryByRegionNoWait = 0x8E16,
    QueryWaitInverted = 0x8E17,
    QueryNoWaitInverted = 0x8E18,
    QueryByRegionWaitInverted = 0x8E19,
    QueryByRegionNoWaitInverted = 0x8E1A
}
