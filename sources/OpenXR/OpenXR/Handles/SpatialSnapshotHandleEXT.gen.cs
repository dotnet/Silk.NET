// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialSnapshotEXT")]
public readonly unsafe partial struct SpatialSnapshotHandleEXT
    : IEquatable<SpatialSnapshotHandleEXT>
{
    public readonly void* Handle;

    public SpatialSnapshotHandleEXT(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SpatialSnapshotHandleEXT other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is SpatialSnapshotHandleEXT other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SpatialSnapshotHandleEXT left, SpatialSnapshotHandleEXT right) =>
        left.Equals(right);

    public static bool operator !=(SpatialSnapshotHandleEXT left, SpatialSnapshotHandleEXT right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SpatialSnapshotHandleEXT left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(SpatialSnapshotHandleEXT left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator SpatialSnapshotHandleEXT(NullPtr _) => default;
}
