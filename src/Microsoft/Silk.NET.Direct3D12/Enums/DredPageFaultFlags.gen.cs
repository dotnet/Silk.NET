// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_PAGE_FAULT_FLAGS")]
    public enum DredPageFaultFlags : int
    {
        [NativeName("Name", "D3D12_DRED_PAGE_FAULT_FLAGS_NONE")]
        DredPageFaultFlagsNone = 0x0,
    }
}
