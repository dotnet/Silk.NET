// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUAdapterType")]
    public enum AdapterType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DiscreteGpu\"")]
        [NativeName("Name", "WGPUAdapterType_DiscreteGPU")]
        AdapterTypeDiscreteGpu = 0x0,
        [Obsolete("Deprecated in favour of \"IntegratedGpu\"")]
        [NativeName("Name", "WGPUAdapterType_IntegratedGPU")]
        AdapterTypeIntegratedGpu = 0x1,
        [Obsolete("Deprecated in favour of \"Cpu\"")]
        [NativeName("Name", "WGPUAdapterType_CPU")]
        AdapterTypeCpu = 0x2,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPUAdapterType_Unknown")]
        AdapterTypeUnknown = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUAdapterType_Force32")]
        AdapterTypeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUAdapterType_DiscreteGPU")]
        DiscreteGpu = 0x0,
        [NativeName("Name", "WGPUAdapterType_IntegratedGPU")]
        IntegratedGpu = 0x1,
        [NativeName("Name", "WGPUAdapterType_CPU")]
        Cpu = 0x2,
        [NativeName("Name", "WGPUAdapterType_Unknown")]
        Unknown = 0x3,
        [NativeName("Name", "WGPUAdapterType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
