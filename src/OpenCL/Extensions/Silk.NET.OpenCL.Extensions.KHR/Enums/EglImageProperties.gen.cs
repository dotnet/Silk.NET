// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_egl_image_properties_khr")]
    public enum EglImageProperties : ulong
    {
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        YuvPlaneIntel = 0x4107,
    }
}
