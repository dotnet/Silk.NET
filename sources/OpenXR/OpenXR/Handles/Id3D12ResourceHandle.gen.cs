// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("ID3D12Resource")]
public readonly unsafe partial struct Id3D12ResourceHandle : IEquatable<Id3D12ResourceHandle>
{
    public readonly void* Handle;

    public Id3D12ResourceHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(Id3D12ResourceHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is Id3D12ResourceHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(Id3D12ResourceHandle left, Id3D12ResourceHandle right) =>
        left.Equals(right);

    public static bool operator !=(Id3D12ResourceHandle left, Id3D12ResourceHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(Id3D12ResourceHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(Id3D12ResourceHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator Id3D12ResourceHandle(NullPtr _) => default;
}
