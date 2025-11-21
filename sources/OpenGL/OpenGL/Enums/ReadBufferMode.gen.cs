// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ReadBufferMode : uint
{
    None = unchecked((uint)0),
    FrontLeft = unchecked((uint)0x0400),
    FrontRight = unchecked((uint)0x0401),
    BackLeft = unchecked((uint)0x0402),
    BackRight = unchecked((uint)0x0403),
    Front = unchecked((uint)0x0404),
    Back = unchecked((uint)0x0405),
    Left = unchecked((uint)0x0406),
    Right = unchecked((uint)0x0407),
    Aux0 = unchecked((uint)0x0409),
    Aux1 = unchecked((uint)0x040A),
    Aux2 = unchecked((uint)0x040B),
    Aux3 = unchecked((uint)0x040C),
    ColorAttachment0 = unchecked((uint)0x8CE0),
    ColorAttachment1 = unchecked((uint)0x8CE1),
    ColorAttachment2 = unchecked((uint)0x8CE2),
    ColorAttachment3 = unchecked((uint)0x8CE3),
    ColorAttachment4 = unchecked((uint)0x8CE4),
    ColorAttachment5 = unchecked((uint)0x8CE5),
    ColorAttachment6 = unchecked((uint)0x8CE6),
    ColorAttachment7 = unchecked((uint)0x8CE7),
    ColorAttachment8 = unchecked((uint)0x8CE8),
    ColorAttachment9 = unchecked((uint)0x8CE9),
    ColorAttachment10 = unchecked((uint)0x8CEA),
    ColorAttachment11 = unchecked((uint)0x8CEB),
    ColorAttachment12 = unchecked((uint)0x8CEC),
    ColorAttachment13 = unchecked((uint)0x8CED),
    ColorAttachment14 = unchecked((uint)0x8CEE),
    ColorAttachment15 = unchecked((uint)0x8CEF),
    NoneOES = unchecked((uint)0),
}
