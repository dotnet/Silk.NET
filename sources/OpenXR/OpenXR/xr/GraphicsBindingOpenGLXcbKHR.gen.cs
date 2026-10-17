// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLXcbKHR")]
public unsafe partial struct GraphicsBindingOpenGLXcbKHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.GraphicsBindingOpenglXcbKHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("connection")]
    public XcbConnectionTHandle Connection;

    [NativeName("screenNumber")]
    public uint ScreenNumber;

    [NativeName("fbconfigid")]
    public uint Fbconfigid;

    [NativeName("visualid")]
    public uint Visualid;

    [NativeName("glxDrawable")]
    public uint GlxDrawable;

    [NativeName("glxContext")]
    public uint GlxContext;

    public GraphicsBindingOpenGLXcbKHR() { }
}
