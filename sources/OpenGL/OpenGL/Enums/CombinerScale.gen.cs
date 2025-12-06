// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerScale : uint
{
    None = unchecked((uint)0),
    ScaleByTwoNV = unchecked((uint)0x853E),
    ScaleByFourNV = unchecked((uint)0x853F),
    ScaleByOneHalfNV = unchecked((uint)0x8540),
}
