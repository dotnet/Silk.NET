// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("Handle", 0)]
[NativeName("VkIndirectCommandsLayoutEXTHandle")]
public readonly unsafe partial struct IndirectCommandsLayoutEXTHandle
{
    public readonly void* Handle;

    public IndirectCommandsLayoutEXTHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(IndirectCommandsLayoutEXTHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is IndirectCommandsLayoutEXTHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        IndirectCommandsLayoutEXTHandle left,
        IndirectCommandsLayoutEXTHandle right
    ) => left.Equals(right);

    public static bool operator !=(
        IndirectCommandsLayoutEXTHandle left,
        IndirectCommandsLayoutEXTHandle right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(IndirectCommandsLayoutEXTHandle left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(IndirectCommandsLayoutEXTHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator IndirectCommandsLayoutEXTHandle(NullPtr _) => default;
}
