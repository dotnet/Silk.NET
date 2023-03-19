// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUAdapterType")]
    public enum AdapterType : int
    {
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
