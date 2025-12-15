// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUPresentMode")]
    public enum PresentMode : int
    {
        [NativeName("Name", "WGPUPresentMode_Fifo")]
        Fifo = 0x0,
        [NativeName("Name", "WGPUPresentMode_FifoRelaxed")]
        FifoRelaxed = 0x1,
        [NativeName("Name", "WGPUPresentMode_Immediate")]
        Immediate = 0x2,
        [NativeName("Name", "WGPUPresentMode_Mailbox")]
        Mailbox = 0x3,
        [NativeName("Name", "WGPUPresentMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
