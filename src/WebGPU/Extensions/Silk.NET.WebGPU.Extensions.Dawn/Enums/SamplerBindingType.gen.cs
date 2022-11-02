// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUSamplerBindingType")]
    public enum SamplerBindingType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUSamplerBindingType_Undefined")]
        SamplerBindingTypeUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Filtering\"")]
        [NativeName("Name", "WGPUSamplerBindingType_Filtering")]
        SamplerBindingTypeFiltering = 0x1,
        [Obsolete("Deprecated in favour of \"NonFiltering\"")]
        [NativeName("Name", "WGPUSamplerBindingType_NonFiltering")]
        SamplerBindingTypeNonFiltering = 0x2,
        [Obsolete("Deprecated in favour of \"Comparison\"")]
        [NativeName("Name", "WGPUSamplerBindingType_Comparison")]
        SamplerBindingTypeComparison = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUSamplerBindingType_Force32")]
        SamplerBindingTypeForce32 = 0x7FFFFFFF,
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
