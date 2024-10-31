// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SET_WORK_GRAPH_FLAGS")]
    public enum SetWorkGraphFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_SET_WORK_GRAPH_FLAG_NONE")]
        SetWorkGraphFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Initialize\"")]
        [NativeName("Name", "D3D12_SET_WORK_GRAPH_FLAG_INITIALIZE")]
        SetWorkGraphFlagInitialize = 0x1,
        [NativeName("Name", "D3D12_SET_WORK_GRAPH_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_SET_WORK_GRAPH_FLAG_INITIALIZE")]
        Initialize = 0x1,
    }
}
