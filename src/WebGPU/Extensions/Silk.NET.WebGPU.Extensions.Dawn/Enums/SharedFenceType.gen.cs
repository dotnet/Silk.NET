// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUSharedFenceType")]
    public enum SharedFenceType : int
    {
        [NativeName("Name", "WGPUSharedFenceType_DXGISharedHandle")]
        DxgiSharedHandle = 0x4,
        [NativeName("Name", "WGPUSharedFenceType_MTLSharedEvent")]
        MtlSharedEvent = 0x5,
        [NativeName("Name", "WGPUSharedFenceType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUSharedFenceType_VkSemaphoreOpaqueFD")]
        VkSemaphoreOpaqueFD = 0x1,
        [NativeName("Name", "WGPUSharedFenceType_VkSemaphoreSyncFD")]
        VkSemaphoreSyncFD = 0x2,
        [NativeName("Name", "WGPUSharedFenceType_VkSemaphoreZirconHandle")]
        VkSemaphoreZirconHandle = 0x3,
        [Obsolete("Deprecated in favour of \"DxgiSharedHandle\"")]
        [NativeName("Name", "WGPUSharedFenceType_DXGISharedHandle")]
        DxgisharedHandle = 0x4,
        [Obsolete("Deprecated in favour of \"MtlSharedEvent\"")]
        [NativeName("Name", "WGPUSharedFenceType_MTLSharedEvent")]
        MtlsharedEvent = 0x5,
        [NativeName("Name", "WGPUSharedFenceType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
