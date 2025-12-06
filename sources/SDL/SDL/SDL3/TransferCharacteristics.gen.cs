// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum TransferCharacteristics : uint
{
    Unknown = 0,
    Bt709 = 1,
    Unspecified = 2,
    Gamma22 = 4,
    Gamma28 = 5,
    Bt601 = 6,
    Smpte240 = 7,
    Linear = 8,
    Log100 = 9,
    Log100Sqrt10 = 10,
    Iec61966 = 11,
    Bt1361 = 12,
    Srgb = 13,
    Bt2020X10Bit = 14,
    Bt2020X12Bit = 15,
    Pq = 16,
    Smpte428 = 17,
    Hlg = 18,
    Custom = 31,
}
