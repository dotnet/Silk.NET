// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum AudioFormat : uint
{
    Unknown = 0x0000U,
    U8 = 0x0008U,
    S8 = 0x8008U,
    S16Le = 0x8010U,
    S16Be = 0x9010U,
    S32Le = 0x8020U,
    S32Be = 0x9020U,
    F32Le = 0x8120U,
    F32Be = 0x9120U,
    S16 = S16Le,
    S32 = S32Le,
    F32 = F32Le,
}
