// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ListNameType : uint
{
    BYTE = 0x1400,
    UnsignedByte = 0x1401,
    Short = 0x1402,
    UnsignedShort = 0x1403,
    INT = 0x1404,
    UnsignedInt = 0x1405,
    Float = 0x1406,
    X2Bytes = 0x1407,
    X3Bytes = 0x1408,
    X4Bytes = 0x1409
}
