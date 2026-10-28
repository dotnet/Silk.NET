// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("ID3D11Texture2D")]
public readonly unsafe partial struct Id3D11Texture2DHandle : IEquatable<Id3D11Texture2DHandle>
{
    public readonly void* Handle;

    public Id3D11Texture2DHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(Id3D11Texture2DHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is Id3D11Texture2DHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(Id3D11Texture2DHandle left, Id3D11Texture2DHandle right) =>
        left.Equals(right);

    public static bool operator !=(Id3D11Texture2DHandle left, Id3D11Texture2DHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(Id3D11Texture2DHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(Id3D11Texture2DHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator Id3D11Texture2DHandle(NullPtr _) => default;
}
