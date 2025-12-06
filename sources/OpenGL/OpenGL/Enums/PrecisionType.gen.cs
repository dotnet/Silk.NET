// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PrecisionType : uint
{
    LowFloat = unchecked((uint)0x8DF0),
    MediumFloat = unchecked((uint)0x8DF1),
    HighFloat = unchecked((uint)0x8DF2),
    LowInt = unchecked((uint)0x8DF3),
    MediumInt = unchecked((uint)0x8DF4),
    HighInt = unchecked((uint)0x8DF5),
}
