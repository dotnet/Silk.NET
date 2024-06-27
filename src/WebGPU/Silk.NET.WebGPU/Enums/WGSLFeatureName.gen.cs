// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUWGSLFeatureName")]
    public enum WGSLFeatureName : int
    {
        [NativeName("Name", "WGPUWGSLFeatureName_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUWGSLFeatureName_ReadonlyAndReadwriteStorageTextures")]
        ReadonlyAndReadwriteStorageTextures = 0x1,
        [NativeName("Name", "WGPUWGSLFeatureName_Packed4x8IntegerDotProduct")]
        Packed4x8integerDotProduct = 0x2,
        [NativeName("Name", "WGPUWGSLFeatureName_UnrestrictedPointerParameters")]
        UnrestrictedPointerParameters = 0x3,
        [NativeName("Name", "WGPUWGSLFeatureName_PointerCompositeAccess")]
        PointerCompositeAccess = 0x4,
        [NativeName("Name", "WGPUWGSLFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
