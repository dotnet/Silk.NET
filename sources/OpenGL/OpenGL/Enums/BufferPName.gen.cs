// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum BufferPName : uint
{
    Size = unchecked((uint)0x8764),
    Usage = unchecked((uint)0x8765),
    Access = unchecked((uint)0x88BB),
    Mapped = unchecked((uint)0x88BC),
    AccessFlags = unchecked((uint)0x911F),
    MapLength = unchecked((uint)0x9120),
    MapOffset = unchecked((uint)0x9121),
    ImmutableStorage = unchecked((uint)0x821F),
    StorageFlags = unchecked((uint)0x8220),
    SizeARB = unchecked((uint)0x8764),
    UsageARB = unchecked((uint)0x8765),
    AccessARB = unchecked((uint)0x88BB),
    MappedARB = unchecked((uint)0x88BC),
}
