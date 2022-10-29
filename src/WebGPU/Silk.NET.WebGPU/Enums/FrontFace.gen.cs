// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUFrontFace")]
    public enum FrontFace : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Ccw\"")]
        [NativeName("Name", "WGPUFrontFace_CCW")]
        FrontFaceCcw = 0x0,
        [Obsolete("Deprecated in favour of \"CW\"")]
        [NativeName("Name", "WGPUFrontFace_CW")]
        FrontFaceCW = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUFrontFace_Force32")]
        FrontFaceForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUFrontFace_CCW")]
        Ccw = 0x0,
        [NativeName("Name", "WGPUFrontFace_CW")]
        CW = 0x1,
        [NativeName("Name", "WGPUFrontFace_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
