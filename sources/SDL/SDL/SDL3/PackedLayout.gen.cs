// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum PackedLayout : uint
{
    PackedlayoutNone,
    Packedlayout332,
    Packedlayout4444,
    Packedlayout1555,
    Packedlayout5551,
    Packedlayout565,
    Packedlayout8888,
    Packedlayout2101010,
    Packedlayout1010102,
}
