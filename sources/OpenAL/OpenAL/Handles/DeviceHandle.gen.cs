// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

public readonly unsafe partial struct DeviceHandle
{
    public readonly void* Handle;

    public bool Equals(DeviceHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is DeviceHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(DeviceHandle left, DeviceHandle right) => left.Equals(right);

    public static bool operator !=(DeviceHandle left, DeviceHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(DeviceHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(DeviceHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator DeviceHandle(NullPtr _) => default;
}
