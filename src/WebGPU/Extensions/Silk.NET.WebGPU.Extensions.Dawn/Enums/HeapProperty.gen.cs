// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUHeapProperty")]
    public enum HeapProperty : int
    {
        [NativeName("Name", "WGPUHeapProperty_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUHeapProperty_DeviceLocal")]
        DeviceLocal = 0x1,
        [NativeName("Name", "WGPUHeapProperty_HostVisible")]
        HostVisible = 0x2,
        [NativeName("Name", "WGPUHeapProperty_HostCoherent")]
        HostCoherent = 0x4,
        [NativeName("Name", "WGPUHeapProperty_HostUncached")]
        HostUncached = 0x8,
        [NativeName("Name", "WGPUHeapProperty_HostCached")]
        HostCached = 0x10,
        [NativeName("Name", "WGPUHeapProperty_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
