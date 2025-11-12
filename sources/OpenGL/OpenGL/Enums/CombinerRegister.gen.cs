// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerRegister : uint
{
    Texture0ARB = unchecked((uint)0x84C0),
    Texture1ARB = unchecked((uint)0x84C1),
    PrimaryColorNV = unchecked((uint)0x852C),
    SecondaryColorNV = unchecked((uint)0x852D),
    Spare0NV = unchecked((uint)0x852E),
    Spare1NV = unchecked((uint)0x852F),
    DiscardNV = unchecked((uint)0x8530),
}
