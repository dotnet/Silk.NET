// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_sampler")]
public readonly unsafe partial struct SamplerHandle : IEquatable<SamplerHandle>
{
    public readonly void* Handle;

    public SamplerHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SamplerHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SamplerHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SamplerHandle left, SamplerHandle right) => left.Equals(right);

    public static bool operator !=(SamplerHandle left, SamplerHandle right) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SamplerHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SamplerHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator SamplerHandle(NullPtr _) => default;
}
