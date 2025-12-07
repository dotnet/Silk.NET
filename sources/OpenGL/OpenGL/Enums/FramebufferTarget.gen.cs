// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferTarget : uint
{
    ReadFramebuffer = unchecked((uint)0x8CA8),
    DrawFramebuffer = unchecked((uint)0x8CA9),
    Framebuffer = unchecked((uint)0x8D40),
    FramebufferOES = unchecked((uint)0x8D40),
}
