// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUPredefinedColorSpace")]
    public enum PredefinedColorSpace : int
    {
        [NativeName("Name", "WGPUPredefinedColorSpace_SRGB")]
        Srgb = 0x1,
        [NativeName("Name", "WGPUPredefinedColorSpace_DisplayP3")]
        DisplayP3 = 0x2,
        [NativeName("Name", "WGPUPredefinedColorSpace_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
