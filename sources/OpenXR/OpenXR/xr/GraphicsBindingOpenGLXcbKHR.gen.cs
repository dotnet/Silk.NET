// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLXcbKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingOpenGLXcbKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public StructureType Type = StructureType.GraphicsBindingOpenglXcbKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public void* Next;

    [NativeName("connection")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public XcbConnectionTHandle Connection;

    [NativeName("screenNumber")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint ScreenNumber;

    [NativeName("fbconfigid")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint Fbconfigid;

    [NativeName("visualid")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint Visualid;

    [NativeName("glxDrawable")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint GlxDrawable;

    [NativeName("glxContext")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public uint GlxContext;

    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GraphicsBindingOpenGLXcbKHR() { }
}
