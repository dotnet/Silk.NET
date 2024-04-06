// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum CombinerRegister
{
    Texture0ARB = 0x84C0,
    Texture1ARB = 0x84C1,
    PrimaryColorNV = 0x852C,
    SecondaryColorNV = 0x852D,
    Spare0NV = 0x852E,
    Spare1NV = 0x852F,
    DiscardNV = 0x8530
}
