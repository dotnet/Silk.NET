// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("ID3D11Device")]
public readonly unsafe partial struct Id3D11DeviceHandle : IEquatable<Id3D11DeviceHandle>
{
    public readonly void* Handle;

    public Id3D11DeviceHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(Id3D11DeviceHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is Id3D11DeviceHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(Id3D11DeviceHandle left, Id3D11DeviceHandle right) =>
        left.Equals(right);

    public static bool operator !=(Id3D11DeviceHandle left, Id3D11DeviceHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(Id3D11DeviceHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(Id3D11DeviceHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator Id3D11DeviceHandle(NullPtr _) => default;
}
