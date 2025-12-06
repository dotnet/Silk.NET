// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetVariantValueEXT")]
public enum GetVariantValueEXT : uint
{
    [NativeName("GL_VARIANT_VALUE_EXT")]
    Value = 34788,

    [NativeName("GL_VARIANT_DATATYPE_EXT")]
    Datatype = 34789,

    [NativeName("GL_VARIANT_ARRAY_STRIDE_EXT")]
    ArrayStride = 34790,

    [NativeName("GL_VARIANT_ARRAY_TYPE_EXT")]
    ArrayType = 34791,
}
