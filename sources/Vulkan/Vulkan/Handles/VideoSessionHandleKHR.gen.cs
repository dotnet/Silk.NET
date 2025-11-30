// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoSessionKHR")]
[NameAffix("Suffix", "_T", -1)]
[NameAffix("Suffix", "Handle", 1)]
public readonly unsafe partial struct VideoSessionHandleKHR
{
    public readonly void* Handle;

    public VideoSessionHandleKHR(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(VideoSessionHandleKHR other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is VideoSessionHandleKHR other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(VideoSessionHandleKHR left, VideoSessionHandleKHR right) =>
        left.Equals(right);

    public static bool operator !=(VideoSessionHandleKHR left, VideoSessionHandleKHR right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(VideoSessionHandleKHR left, NullPtr right) => left.Equals(right);

    public static bool operator !=(VideoSessionHandleKHR left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator VideoSessionHandleKHR(NullPtr _) => default;
}
