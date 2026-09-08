// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTriangleMeshFB")]
public readonly unsafe partial struct TriangleMeshHandleFB : IEquatable<TriangleMeshHandleFB>
{
    public readonly void* Handle;

    public TriangleMeshHandleFB(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(TriangleMeshHandleFB other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is TriangleMeshHandleFB other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(TriangleMeshHandleFB left, TriangleMeshHandleFB right) =>
        left.Equals(right);

    public static bool operator !=(TriangleMeshHandleFB left, TriangleMeshHandleFB right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(TriangleMeshHandleFB left, NullPtr right) => left.Equals(right);

    public static bool operator !=(TriangleMeshHandleFB left, NullPtr right) => !left.Equals(right);

    public static implicit operator TriangleMeshHandleFB(NullPtr _) => default;
}
