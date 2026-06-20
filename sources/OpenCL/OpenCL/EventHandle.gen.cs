// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_event")]
public readonly unsafe partial struct EventHandle : IEquatable<EventHandle>
{
    public readonly void* Handle;

    public EventHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(EventHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is EventHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(EventHandle left, EventHandle right) => left.Equals(right);

    public static bool operator !=(EventHandle left, EventHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(EventHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(EventHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator EventHandle(NullPtr _) => default;
}
