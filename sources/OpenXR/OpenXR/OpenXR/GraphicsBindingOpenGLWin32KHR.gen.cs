// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLWin32KHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingOpenGLWin32KHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public StructureType Type = StructureType.GraphicsBindingOpenglWin32KHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public void* Next;

    [NativeName("hDC")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public HdcHandle Hdc;

    [NativeName("hGLRC")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public HglrcHandle HGlrc;

    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GraphicsBindingOpenGLWin32KHR() { }
}
