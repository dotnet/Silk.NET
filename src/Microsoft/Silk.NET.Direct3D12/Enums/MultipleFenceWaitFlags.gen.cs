// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAGS")]
    public enum MultipleFenceWaitFlags : int
    {
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE")]
        MultipleFenceWaitFlagNone = 0x0,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY")]
        MultipleFenceWaitFlagAny = 0x1,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL")]
        MultipleFenceWaitFlagAll = 0x0,
    }
}
