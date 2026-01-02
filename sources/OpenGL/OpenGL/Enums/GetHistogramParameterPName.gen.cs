// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetHistogramParameterPName : uint
{
    Width = unchecked((uint)0x8026),
    Format = unchecked((uint)0x8027),
    RedSize = unchecked((uint)0x8028),
    GreenSize = unchecked((uint)0x8029),
    BlueSize = unchecked((uint)0x802A),
    AlphaSize = unchecked((uint)0x802B),
    LuminanceSize = unchecked((uint)0x802C),
    Sink = unchecked((uint)0x802D),
    WidthEXT = unchecked((uint)0x8026),
    FormatEXT = unchecked((uint)0x8027),
    RedSizeEXT = unchecked((uint)0x8028),
    GreenSizeEXT = unchecked((uint)0x8029),
    BlueSizeEXT = unchecked((uint)0x802A),
    AlphaSizeEXT = unchecked((uint)0x802B),
    LuminanceSizeEXT = unchecked((uint)0x802C),
    SinkEXT = unchecked((uint)0x802D),
}
