// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvKernelEnqueueFlags_")]
    public enum KernelEnqueueFlags : int
    {
        [NativeName("Name", "SpvKernelEnqueueFlagsNoWait")]
        NoWait = 0x0,
        [NativeName("Name", "SpvKernelEnqueueFlagsWaitKernel")]
        WaitKernel = 0x1,
        [NativeName("Name", "SpvKernelEnqueueFlagsWaitWorkGroup")]
        WaitWorkGroup = 0x2,
        [NativeName("Name", "SpvKernelEnqueueFlagsMax")]
        Max = 0x7FFFFFFF,
    }
}
