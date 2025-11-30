// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NVX", 0)]
[NativeName("VkCuFunctionNVX")]
[NameAffix("Suffix", "_T", -1)]
[NameAffix("Suffix", "Handle", 1)]
public readonly unsafe partial struct CuFunctionHandleNvx
{
    public readonly void* Handle;

    public CuFunctionHandleNvx(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(CuFunctionHandleNvx other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is CuFunctionHandleNvx other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(CuFunctionHandleNvx left, CuFunctionHandleNvx right) =>
        left.Equals(right);

    public static bool operator !=(CuFunctionHandleNvx left, CuFunctionHandleNvx right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(CuFunctionHandleNvx left, NullPtr right) => left.Equals(right);

    public static bool operator !=(CuFunctionHandleNvx left, NullPtr right) => !left.Equals(right);

    public static implicit operator CuFunctionHandleNvx(NullPtr _) => default;
}
