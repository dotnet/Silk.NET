// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAGS")]
    public enum MultipleFenceWaitFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE")]
        MultipleFenceWaitFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Any\"")]
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY")]
        MultipleFenceWaitFlagAny = 0x1,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL")]
        MultipleFenceWaitFlagAll = 0x0,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY")]
        Any = 0x1,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL")]
        All = 0x0,
    }
}
