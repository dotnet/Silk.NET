// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum ContextFlagMask
{
    ForwardCompatibleBit = 0x00000001,
    DebugBit = 0x00000002,
    RobustAccessBit = 0x00000004,
    NoErrorBit = 0x00000008,
    RobustAccessBitARB = 0x00000004,
    NoErrorBitKHR = 0x00000008,
    DebugBitKHR = 0x00000002,
    ProtectedContentBitEXT = 0x00000010
}
