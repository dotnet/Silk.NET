// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferTarget : uint
{
    ReadFramebuffer = 0x8CA8,
    DrawFramebuffer = 0x8CA9,
    Framebuffer = 0x8D40,
    FramebufferOES = 0x8D40
}
