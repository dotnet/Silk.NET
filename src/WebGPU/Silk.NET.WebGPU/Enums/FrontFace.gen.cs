// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUFrontFace")]
    public enum FrontFace : int
    {
        [NativeName("Name", "WGPUFrontFace_CCW")]
        Ccw = 0x0,
        [NativeName("Name", "WGPUFrontFace_CW")]
        CW = 0x1,
        [NativeName("Name", "WGPUFrontFace_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
