// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_WORK_GRAPH_FLAGS")]
    public enum WorkGraphFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_WORK_GRAPH_FLAG_NONE")]
        WorkGraphFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"IncludeAllAvailableNodes\"")]
        [NativeName("Name", "D3D12_WORK_GRAPH_FLAG_INCLUDE_ALL_AVAILABLE_NODES")]
        WorkGraphFlagIncludeAllAvailableNodes = 0x1,
        [NativeName("Name", "D3D12_WORK_GRAPH_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_WORK_GRAPH_FLAG_INCLUDE_ALL_AVAILABLE_NODES")]
        IncludeAllAvailableNodes = 0x1,
    }
}
