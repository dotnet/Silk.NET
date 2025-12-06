// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public enum BlendMode : uint
{
    None = 0x00000000U,
    Blend = 0x00000001U,
    BlendPremultiplied = 0x00000010U,
    Add = 0x00000002U,
    AddPremultiplied = 0x00000020U,
    Mod = 0x00000004U,
    Mul = 0x00000008U,
    Invalid = 0x7FFFFFFFU,
}
