// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUDx12Compiler")]
    public enum Dx12Compiler : int
    {
        [NativeName("Name", "WGPUDx12Compiler_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUDx12Compiler_Fxc")]
        Fxc = 0x1,
        [NativeName("Name", "WGPUDx12Compiler_Dxc")]
        Dxc = 0x2,
        [NativeName("Name", "WGPUDx12Compiler_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
