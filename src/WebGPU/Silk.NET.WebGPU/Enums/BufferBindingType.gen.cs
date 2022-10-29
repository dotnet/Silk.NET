// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUBufferBindingType")]
    public enum BufferBindingType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUBufferBindingType_Undefined")]
        BufferBindingTypeUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Uniform\"")]
        [NativeName("Name", "WGPUBufferBindingType_Uniform")]
        BufferBindingTypeUniform = 0x1,
        [Obsolete("Deprecated in favour of \"Storage\"")]
        [NativeName("Name", "WGPUBufferBindingType_Storage")]
        BufferBindingTypeStorage = 0x2,
        [Obsolete("Deprecated in favour of \"ReadOnlyStorage\"")]
        [NativeName("Name", "WGPUBufferBindingType_ReadOnlyStorage")]
        BufferBindingTypeReadOnlyStorage = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBufferBindingType_Force32")]
        BufferBindingTypeForce32 = 0x7FFFFFFF,
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
