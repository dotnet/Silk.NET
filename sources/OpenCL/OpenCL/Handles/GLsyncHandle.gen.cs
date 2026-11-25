// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("__GLsync")]
public readonly unsafe partial struct GLsyncHandle : IEquatable<GLsyncHandle>
{
    public readonly void* Handle;

    public GLsyncHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(GLsyncHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is GLsyncHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(GLsyncHandle left, GLsyncHandle right) => left.Equals(right);

    public static bool operator !=(GLsyncHandle left, GLsyncHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(GLsyncHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(GLsyncHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator GLsyncHandle(NullPtr _) => default;
}
