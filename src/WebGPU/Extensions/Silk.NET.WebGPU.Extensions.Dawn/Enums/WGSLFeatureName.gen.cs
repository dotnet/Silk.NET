// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
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
        [NativeName("Name", "WGPUWGSLFeatureName_ChromiumTestingUnimplemented")]
        ChromiumTestingUnimplemented = 0x3E8,
        [NativeName("Name", "WGPUWGSLFeatureName_ChromiumTestingUnsafeExperimental")]
        ChromiumTestingUnsafeExperimental = 0x3E9,
        [NativeName("Name", "WGPUWGSLFeatureName_ChromiumTestingExperimental")]
        ChromiumTestingExperimental = 0x3EA,
        [NativeName("Name", "WGPUWGSLFeatureName_ChromiumTestingShippedWithKillswitch")]
        ChromiumTestingShippedWithKillswitch = 0x3EB,
        [NativeName("Name", "WGPUWGSLFeatureName_ChromiumTestingShipped")]
        ChromiumTestingShipped = 0x3EC,
        [NativeName("Name", "WGPUWGSLFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
