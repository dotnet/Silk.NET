// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum PackedLayout : uint
{
    None,
    X332,
    X4444,
    X1555,
    X5551,
    X565,
    X8888,
    X2101010,
    X1010102,
}
