// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "Handle", 0)]
[NativeName("VkPipelineBinaryKHR_T")]
public readonly unsafe partial struct PipelineBinaryKHR
{
    public readonly void* Handle;

    public PipelineBinaryKHR(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(PipelineBinaryKHR other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is PipelineBinaryKHR other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(PipelineBinaryKHR left, PipelineBinaryKHR right) =>
        left.Equals(right);

    public static bool operator !=(PipelineBinaryKHR left, PipelineBinaryKHR right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(PipelineBinaryKHR left, NullPtr right) => left.Equals(right);

    public static bool operator !=(PipelineBinaryKHR left, NullPtr right) => !left.Equals(right);

    public static implicit operator PipelineBinaryKHR(NullPtr _) => default;
}
