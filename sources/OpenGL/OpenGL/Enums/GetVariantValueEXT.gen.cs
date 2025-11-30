// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("GetVariantValueEXT")]
[Transformed]
public enum GetVariantValueEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_VALUE_EXT")]
    ValueEXT = unchecked((uint)0x87E4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_DATATYPE_EXT")]
    DatatypeEXT = unchecked((uint)0x87E5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_STRIDE_EXT")]
    ArrayStrideEXT = unchecked((uint)0x87E6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_ARRAY_TYPE_EXT")]
    ArrayTypeEXT = unchecked((uint)0x87E7),
}
