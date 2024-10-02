// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public partial struct HapticDirection
{
    [NativeTypeName("Uint8")]
    public byte Type;

    [NativeTypeName("Sint32[3]")]
    public _dir_e__FixedBuffer Dir;

    [InlineArray(3)]
    public partial struct _dir_e__FixedBuffer
    {
        public int e0;
    }
}
