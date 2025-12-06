// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferStatus : uint
{
    Undefined = unchecked((uint)0x8219),
    Complete = unchecked((uint)0x8CD5),
    IncompleteAttachment = unchecked((uint)0x8CD6),
    IncompleteMissingAttachment = unchecked((uint)0x8CD7),
    IncompleteDrawBuffer = unchecked((uint)0x8CDB),
    IncompleteReadBuffer = unchecked((uint)0x8CDC),
    Unsupported = unchecked((uint)0x8CDD),
    IncompleteMultisample = unchecked((uint)0x8D56),
    IncompleteLayerTargets = unchecked((uint)0x8DA8),
}
