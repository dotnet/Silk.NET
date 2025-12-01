// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Gamepad")]
public readonly unsafe partial struct GamepadHandle
{
    public readonly void* Handle;

    public GamepadHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(GamepadHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is GamepadHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(GamepadHandle left, GamepadHandle right) => left.Equals(right);

    public static bool operator !=(GamepadHandle left, GamepadHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(GamepadHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(GamepadHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator GamepadHandle(NullPtr _) => default;
}
