// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationCacheEXT")]
public readonly unsafe partial struct ValidationCacheHandleEXT
{
    public readonly void* Handle;

    public ValidationCacheHandleEXT(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(ValidationCacheHandleEXT other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is ValidationCacheHandleEXT other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(ValidationCacheHandleEXT left, ValidationCacheHandleEXT right) =>
        left.Equals(right);

    public static bool operator !=(ValidationCacheHandleEXT left, ValidationCacheHandleEXT right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(ValidationCacheHandleEXT left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(ValidationCacheHandleEXT left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator ValidationCacheHandleEXT(NullPtr _) => default;
}
