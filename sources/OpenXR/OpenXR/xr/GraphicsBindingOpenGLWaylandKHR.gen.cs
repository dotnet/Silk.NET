// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingOpenGLWaylandKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingOpenGLWaylandKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public StructureType Type = StructureType.GraphicsBindingOpenglWaylandKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public void* Next;

    [NativeName("display")]
    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public WlDisplayHandle Display;

    [SupportedApiProfile("openxr", ["XR_KHR_opengl_enable"])]
    public GraphicsBindingOpenGLWaylandKHR() { }
}
