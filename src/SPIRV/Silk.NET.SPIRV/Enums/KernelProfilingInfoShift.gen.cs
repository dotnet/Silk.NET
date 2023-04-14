// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvKernelProfilingInfoShift_")]
    public enum KernelProfilingInfoShift : int
    {
        [NativeName("Name", "SpvKernelProfilingInfoCmdExecTimeShift")]
        CmdExecTimeShift = 0x0,
        [NativeName("Name", "SpvKernelProfilingInfoMax")]
        Max = 0x7FFFFFFF,
    }
}
