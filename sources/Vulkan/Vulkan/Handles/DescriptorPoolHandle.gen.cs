// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe partial struct DescriptorPoolHandle
{
    public readonly void* Handle;

    public bool Equals(DescriptorPoolHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is DescriptorPoolHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(DescriptorPoolHandle left, DescriptorPoolHandle right) =>
        left.Equals(right);

    public static bool operator !=(DescriptorPoolHandle left, DescriptorPoolHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(DescriptorPoolHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(DescriptorPoolHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator DescriptorPoolHandle(NullPtr _) => default;
}
