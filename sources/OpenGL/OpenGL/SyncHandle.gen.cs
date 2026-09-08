// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GLsync")]
public readonly unsafe partial struct SyncHandle : IEquatable<SyncHandle>
{
    public readonly void* Handle;

    public SyncHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SyncHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SyncHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SyncHandle left, SyncHandle right) => left.Equals(right);

    public static bool operator !=(SyncHandle left, SyncHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SyncHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SyncHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator SyncHandle(NullPtr _) => default;
}
