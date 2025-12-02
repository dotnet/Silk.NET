// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SUN", -1)]
[NativeName("ReplacementCodeTypeSUN")]
public enum ReplacementCodeType : uint
{
    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = 5121,

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = 5123,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,
}
