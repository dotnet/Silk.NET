// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ContextFlagMask : uint
{
    ForwardCompatibleBit = unchecked((uint)0x00000001),
    DebugBit = unchecked((uint)0x00000002),
    RobustAccessBit = unchecked((uint)0x00000004),
    NoErrorBit = unchecked((uint)0x00000008),
    RobustAccessBitARB = unchecked((uint)0x00000004),
    NoErrorBitKHR = unchecked((uint)0x00000008),
    DebugBitKHR = unchecked((uint)0x00000002),
    ProtectedContentBitEXT = unchecked((uint)0x00000010),
}
