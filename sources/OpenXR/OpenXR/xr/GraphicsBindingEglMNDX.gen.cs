// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingEGLMNDX")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingEglMNDX
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public StructureType Type = StructureType.GraphicsBindingEglMNDX;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public void* Next;

    [NativeName("getProcAddress")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public EglGetProcAddressMNDX GetProcAddress;

    [NativeName("display")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public void* Display;

    [NativeName("config")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public void* Config;

    [NativeName("context")]
    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public void* Context;

    [SupportedApiProfile("openxr", ["XR_MNDX_egl_enable"])]
    public GraphicsBindingEglMNDX() { }
}
