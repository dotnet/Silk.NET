// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum PixelType : uint
{
    Unknown,
    Index1,
    Index4,
    Index8,
    Packed8,
    Packed16,
    Packed32,
    Arrayu8,
    Arrayu16,
    Arrayu32,
    Arrayf16,
    Arrayf32,
    Index2,
}
