// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShadingRateQCOM : uint
{
    Rate1X1Pixels = unchecked((uint)0x96A6),
    Rate1X2Pixels = unchecked((uint)0x96A7),
    Rate2X1Pixels = unchecked((uint)0x96A8),
    Rate2X2Pixels = unchecked((uint)0x96A9),
    Rate4X2Pixels = unchecked((uint)0x96AC),
    Rate4X4Pixels = unchecked((uint)0x96AE),
}
