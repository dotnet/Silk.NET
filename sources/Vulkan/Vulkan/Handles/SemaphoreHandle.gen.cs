// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSemaphore")]
[NameAffix("Suffix", "_T", -1)]
[NameAffix("Suffix", "Handle", 1)]
public readonly unsafe partial struct SemaphoreHandle
{
    public readonly void* Handle;

    public SemaphoreHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SemaphoreHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SemaphoreHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SemaphoreHandle left, SemaphoreHandle right) =>
        left.Equals(right);

    public static bool operator !=(SemaphoreHandle left, SemaphoreHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SemaphoreHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SemaphoreHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator SemaphoreHandle(NullPtr _) => default;
}
