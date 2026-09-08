// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_semaphore_khr")]
public readonly unsafe partial struct SemaphoreHandleKHR : IEquatable<SemaphoreHandleKHR>
{
    public readonly void* Handle;

    public SemaphoreHandleKHR(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SemaphoreHandleKHR other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SemaphoreHandleKHR other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SemaphoreHandleKHR left, SemaphoreHandleKHR right) =>
        left.Equals(right);

    public static bool operator !=(SemaphoreHandleKHR left, SemaphoreHandleKHR right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SemaphoreHandleKHR left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SemaphoreHandleKHR left, NullPtr right) => !left.Equals(right);

    public static implicit operator SemaphoreHandleKHR(NullPtr _) => default;
}
