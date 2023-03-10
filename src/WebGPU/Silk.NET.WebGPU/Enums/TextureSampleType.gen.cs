// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUTextureSampleType")]
    public enum TextureSampleType : int
    {
        [NativeName("Name", "WGPUTextureSampleType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUTextureSampleType_Float")]
        Float = 0x1,
        [NativeName("Name", "WGPUTextureSampleType_UnfilterableFloat")]
        UnfilterableFloat = 0x2,
        [NativeName("Name", "WGPUTextureSampleType_Depth")]
        Depth = 0x3,
        [NativeName("Name", "WGPUTextureSampleType_Sint")]
        Sint = 0x4,
        [NativeName("Name", "WGPUTextureSampleType_Uint")]
        Uint = 0x5,
        [NativeName("Name", "WGPUTextureSampleType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
