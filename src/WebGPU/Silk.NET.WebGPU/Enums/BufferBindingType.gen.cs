// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBufferBindingType")]
    public enum BufferBindingType : int
    {
        [NativeName("Name", "WGPUBufferBindingType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUBufferBindingType_Uniform")]
        Uniform = 0x1,
        [NativeName("Name", "WGPUBufferBindingType_Storage")]
        Storage = 0x2,
        [NativeName("Name", "WGPUBufferBindingType_ReadOnlyStorage")]
        ReadOnlyStorage = 0x3,
        [NativeName("Name", "WGPUBufferBindingType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
