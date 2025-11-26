// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe partial struct SharedObjectHandle
{
    public readonly void* Handle;

    public SharedObjectHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SharedObjectHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SharedObjectHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SharedObjectHandle left, SharedObjectHandle right) =>
        left.Equals(right);

    public static bool operator !=(SharedObjectHandle left, SharedObjectHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SharedObjectHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SharedObjectHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator SharedObjectHandle(NullPtr _) => default;
}
