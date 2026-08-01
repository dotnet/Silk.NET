// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSenseDataSnapshotBD")]
public readonly unsafe partial struct SenseDataSnapshotHandleBD
    : IEquatable<SenseDataSnapshotHandleBD>
{
    public readonly void* Handle;

    public SenseDataSnapshotHandleBD(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SenseDataSnapshotHandleBD other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is SenseDataSnapshotHandleBD other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        SenseDataSnapshotHandleBD left,
        SenseDataSnapshotHandleBD right
    ) => left.Equals(right);

    public static bool operator !=(
        SenseDataSnapshotHandleBD left,
        SenseDataSnapshotHandleBD right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SenseDataSnapshotHandleBD left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(SenseDataSnapshotHandleBD left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator SenseDataSnapshotHandleBD(NullPtr _) => default;
}
