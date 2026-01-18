// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUGLFenceBehaviour")]
    public enum GLFenceBehaviour : int
    {
        [NativeName("Name", "WGPUGLFenceBehaviour_Normal")]
        Normal = 0x0,
        [NativeName("Name", "WGPUGLFenceBehaviour_AutoFinish")]
        AutoFinish = 0x1,
        [NativeName("Name", "WGPUGLFenceBehaviour_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
