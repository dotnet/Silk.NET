// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUFeatureLevel")]
    public enum FeatureLevel : int
    {
        [NativeName("Name", "WGPUFeatureLevel_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUFeatureLevel_Compatibility")]
        Compatibility = 0x1,
        [NativeName("Name", "WGPUFeatureLevel_Core")]
        Core = 0x2,
        [NativeName("Name", "WGPUFeatureLevel_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
