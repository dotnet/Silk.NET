// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_gl_context_info")]
    public enum GlContextInfo : int
    {
        [NativeName("Name", "CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR")]
        CurrentDeviceForGLContext = 0x2006,
        [NativeName("Name", "CL_DEVICES_FOR_GL_CONTEXT_KHR")]
        DevicesForGLContext = 0x2007,
    }
}
