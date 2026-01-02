// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum AlphaFunction : uint
{
    Never = unchecked((uint)0x0200),
    Less = unchecked((uint)0x0201),
    Equal = unchecked((uint)0x0202),
    Lequal = unchecked((uint)0x0203),
    Greater = unchecked((uint)0x0204),
    Notequal = unchecked((uint)0x0205),
    Gequal = unchecked((uint)0x0206),
    Always = unchecked((uint)0x0207),
}
