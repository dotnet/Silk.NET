// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUIndexFormat")]
    public enum IndexFormat : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUIndexFormat_Undefined")]
        IndexFormatUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Uint16\"")]
        [NativeName("Name", "WGPUIndexFormat_Uint16")]
        IndexFormatUint16 = 0x1,
        [Obsolete("Deprecated in favour of \"Uint32\"")]
        [NativeName("Name", "WGPUIndexFormat_Uint32")]
        IndexFormatUint32 = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUIndexFormat_Force32")]
        IndexFormatForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUIndexFormat_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUIndexFormat_Uint16")]
        Uint16 = 0x1,
        [NativeName("Name", "WGPUIndexFormat_Uint32")]
        Uint32 = 0x2,
        [NativeName("Name", "WGPUIndexFormat_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
