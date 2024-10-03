// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum BlendFactor : uint
{
    Zero = 0x1,
    One = 0x2,
    SrcColor = 0x3,
    OneMinusSrcColor = 0x4,
    SrcAlpha = 0x5,
    OneMinusSrcAlpha = 0x6,
    DstColor = 0x7,
    OneMinusDstColor = 0x8,
    DstAlpha = 0x9,
    OneMinusDstAlpha = 0xA,
}
