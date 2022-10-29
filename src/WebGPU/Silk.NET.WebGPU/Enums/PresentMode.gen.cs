// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUPresentMode")]
    public enum PresentMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Immediate\"")]
        [NativeName("Name", "WGPUPresentMode_Immediate")]
        PresentModeImmediate = 0x0,
        [Obsolete("Deprecated in favour of \"Mailbox\"")]
        [NativeName("Name", "WGPUPresentMode_Mailbox")]
        PresentModeMailbox = 0x1,
        [Obsolete("Deprecated in favour of \"Fifo\"")]
        [NativeName("Name", "WGPUPresentMode_Fifo")]
        PresentModeFifo = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUPresentMode_Force32")]
        PresentModeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUPresentMode_Immediate")]
        Immediate = 0x0,
        [NativeName("Name", "WGPUPresentMode_Mailbox")]
        Mailbox = 0x1,
        [NativeName("Name", "WGPUPresentMode_Fifo")]
        Fifo = 0x2,
        [NativeName("Name", "WGPUPresentMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
