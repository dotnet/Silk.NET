// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_egl_image_properties_khr")]
public enum EglImagePropertiesKHR : intptr_t
{
    [NativeName("CL_EGL_YUV_PLANE_INTEL")]
    YuvPlaneINTEL = unchecked((intptr_t)0x4107),
}
