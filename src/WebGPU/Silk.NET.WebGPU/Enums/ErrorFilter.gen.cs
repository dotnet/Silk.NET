// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUErrorFilter")]
    public enum ErrorFilter : int
    {
        [NativeName("Name", "WGPUErrorFilter_Validation")]
        Validation = 0x0,
        [NativeName("Name", "WGPUErrorFilter_OutOfMemory")]
        OutOfMemory = 0x1,
        [NativeName("Name", "WGPUErrorFilter_Internal")]
        Internal = 0x2,
        [NativeName("Name", "WGPUErrorFilter_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
