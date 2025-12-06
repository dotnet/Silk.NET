// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe partial struct IOStreamHandle
{
    public readonly void* Handle;

    public bool Equals(IOStreamHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is IOStreamHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(IOStreamHandle left, IOStreamHandle right) => left.Equals(right);

    public static bool operator !=(IOStreamHandle left, IOStreamHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(IOStreamHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(IOStreamHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator IOStreamHandle(NullPtr _) => default;
}
