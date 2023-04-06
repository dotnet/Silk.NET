// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DEVICE_CONTEXT_OPTIONS")]
    public enum DeviceContextOptions : int
    {
        [NativeName("Name", "D2D1_DEVICE_CONTEXT_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_DEVICE_CONTEXT_OPTIONS_ENABLE_MULTITHREADED_OPTIMIZATIONS")]
        EnableMultithreadedOptimizations = 0x1,
        [NativeName("Name", "D2D1_DEVICE_CONTEXT_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
