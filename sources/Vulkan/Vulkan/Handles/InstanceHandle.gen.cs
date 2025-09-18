// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe partial struct InstanceHandle
{
    public readonly void* Handle;

    public bool Equals(InstanceHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is InstanceHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(InstanceHandle left, InstanceHandle right) => left.Equals(right);

    public static bool operator !=(InstanceHandle left, InstanceHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(InstanceHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(InstanceHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator InstanceHandle(NullPtr _) => default;
}
