// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSamplerBindingType")]
    public enum SamplerBindingType : int
    {
        [NativeName("Name", "WGPUSamplerBindingType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUSamplerBindingType_Filtering")]
        Filtering = 0x1,
        [NativeName("Name", "WGPUSamplerBindingType_NonFiltering")]
        NonFiltering = 0x2,
        [NativeName("Name", "WGPUSamplerBindingType_Comparison")]
        Comparison = 0x3,
        [NativeName("Name", "WGPUSamplerBindingType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
