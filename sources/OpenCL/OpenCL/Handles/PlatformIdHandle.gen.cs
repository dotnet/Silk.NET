// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_platform_id")]
public readonly unsafe partial struct PlatformIdHandle : IEquatable<PlatformIdHandle>
{
    public readonly void* Handle;

    public PlatformIdHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(PlatformIdHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is PlatformIdHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(PlatformIdHandle left, PlatformIdHandle right) =>
        left.Equals(right);

    public static bool operator !=(PlatformIdHandle left, PlatformIdHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(PlatformIdHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(PlatformIdHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator PlatformIdHandle(NullPtr _) => default;
}
