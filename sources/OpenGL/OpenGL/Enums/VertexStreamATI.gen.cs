// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexStreamATI : uint
{
    Stream0 = unchecked((uint)0x876C),
    Stream1 = unchecked((uint)0x876D),
    Stream2 = unchecked((uint)0x876E),
    Stream3 = unchecked((uint)0x876F),
    Stream4 = unchecked((uint)0x8770),
    Stream5 = unchecked((uint)0x8771),
    Stream6 = unchecked((uint)0x8772),
    Stream7 = unchecked((uint)0x8773),
}
