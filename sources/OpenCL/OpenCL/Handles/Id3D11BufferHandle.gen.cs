// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("ID3D11Buffer")]
public readonly unsafe partial struct Id3D11BufferHandle : IEquatable<Id3D11BufferHandle>
{
    public readonly void* Handle;

    public Id3D11BufferHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(Id3D11BufferHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is Id3D11BufferHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(Id3D11BufferHandle left, Id3D11BufferHandle right) =>
        left.Equals(right);

    public static bool operator !=(Id3D11BufferHandle left, Id3D11BufferHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(Id3D11BufferHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(Id3D11BufferHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator Id3D11BufferHandle(NullPtr _) => default;
}
