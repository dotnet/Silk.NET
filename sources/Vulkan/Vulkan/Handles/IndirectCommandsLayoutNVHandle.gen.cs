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

public readonly unsafe partial struct IndirectCommandsLayoutNVHandle
{
    public readonly void* Handle;

    public bool Equals(IndirectCommandsLayoutNVHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) =>
        obj is IndirectCommandsLayoutNVHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(
        IndirectCommandsLayoutNVHandle left,
        IndirectCommandsLayoutNVHandle right
    ) => left.Equals(right);

    public static bool operator !=(
        IndirectCommandsLayoutNVHandle left,
        IndirectCommandsLayoutNVHandle right
    ) => !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(IndirectCommandsLayoutNVHandle left, NullPtr right) =>
        left.Equals(right);

    public static bool operator !=(IndirectCommandsLayoutNVHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator IndirectCommandsLayoutNVHandle(NullPtr _) => default;
}
