// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("ALCcontext")]
public readonly unsafe partial struct ContextHandle
{
    public readonly void* Handle;

    public ContextHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equal(ContextHandle other) => Handle == other.Handle;

    public override bool Equal(object? obj) => obj is ContextHandle other && Equal(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(ContextHandle left, ContextHandle right) => left.Equal(right);

    public static bool operator !=(ContextHandle left, ContextHandle right) => !left.Equal(right);

    public bool Equal(NullPtr _) => Handle is null;

    public static bool operator ==(ContextHandle left, NullPtr right) => left.Equal(right);

    public static bool operator !=(ContextHandle left, NullPtr right) => !left.Equal(right);

    public static implicit operator ContextHandle(NullPtr _) => default;
}
