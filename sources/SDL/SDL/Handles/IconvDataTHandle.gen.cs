// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe partial struct IconvDataTHandle
{
    public readonly void* Handle;

    public IconvDataTHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(IconvDataTHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is IconvDataTHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(IconvDataTHandle left, IconvDataTHandle right) =>
        left.Equals(right);

    public static bool operator !=(IconvDataTHandle left, IconvDataTHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(IconvDataTHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(IconvDataTHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator IconvDataTHandle(NullPtr _) => default;
}
