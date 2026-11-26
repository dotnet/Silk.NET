// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_screen_context")]
public readonly unsafe partial struct ScreenContextHandle : IEquatable<ScreenContextHandle>
{
    public readonly void* Handle;

    public ScreenContextHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(ScreenContextHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is ScreenContextHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(ScreenContextHandle left, ScreenContextHandle right) =>
        left.Equals(right);

    public static bool operator !=(ScreenContextHandle left, ScreenContextHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(ScreenContextHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(ScreenContextHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator ScreenContextHandle(NullPtr _) => default;
}
