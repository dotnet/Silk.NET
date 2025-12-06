// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_TransferCharacteristics")]
public enum TransferCharacteristics
{
    [NativeName("SDL_TRANSFER_CHARACTERISTICS_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_BT709")]
    Bt709 = 1,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_GAMMA22")]
    Gamma22 = 4,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_GAMMA28")]
    Gamma28 = 5,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_BT601")]
    Bt601 = 6,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_SMPTE240")]
    Smpte240 = 7,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_LINEAR")]
    Linear = 8,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_LOG100")]
    Log100 = 9,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_LOG100_SQRT10")]
    Log100Sqrt10 = 10,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_IEC61966")]
    Iec61966 = 11,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_BT1361")]
    Bt1361 = 12,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_SRGB")]
    Srgb = 13,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_BT2020_10BIT")]
    Bt2020X10Bit = 14,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_BT2020_12BIT")]
    Bt2020X12Bit = 15,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_PQ")]
    Pq = 16,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_SMPTE428")]
    Smpte428 = 17,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_HLG")]
    Hlg = 18,

    [NativeName("SDL_TRANSFER_CHARACTERISTICS_CUSTOM")]
    Custom = 31,
}
