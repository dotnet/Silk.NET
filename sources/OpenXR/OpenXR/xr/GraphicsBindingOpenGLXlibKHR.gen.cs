// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLXlibKHR")]
public unsafe partial struct GraphicsBindingOpenGLXlibKHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.GraphicsBindingOpenglXlibKHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("xDisplay")]
    public XDisplayHandle XDisplay;

    [NativeName("visualid")]
    public uint Visualid;

    [NativeName("glxFBConfig")]
    public GlxfbConfigRecHandle GlxFBConfig;

    [NativeName("glxDrawable")]
    public nuint GlxDrawable;

    [NativeName("glxContext")]
    public GLXcontextRecHandle GlxContext;

    public GraphicsBindingOpenGLXlibKHR() { }
}
