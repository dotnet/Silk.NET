// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLXlibKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingOpenGLXlibKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public StructureType Type = StructureType.GraphicsBindingOpenglXlibKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public void* Next;

    [NativeName("xDisplay")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public XDisplayHandle XDisplay;

    [NativeName("visualid")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint Visualid;

    [NativeName("glxFBConfig")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GlxfbConfigRecHandle GlxFBConfig;

    [NativeName("glxDrawable")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public nuint GlxDrawable;

    [NativeName("glxContext")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GLXcontextRecHandle GlxContext;

    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GraphicsBindingOpenGLXlibKHR() { }
}
