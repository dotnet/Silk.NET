// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DISPATCH_MODE")]
    public enum DispatchMode : int
    {
        [Obsolete("Deprecated in favour of \"NodeCpuInput\"")]
        [NativeName("Name", "D3D12_DISPATCH_MODE_NODE_CPU_INPUT")]
        DispatchModeNodeCpuInput = 0x0,
        [Obsolete("Deprecated in favour of \"NodeGpuInput\"")]
        [NativeName("Name", "D3D12_DISPATCH_MODE_NODE_GPU_INPUT")]
        DispatchModeNodeGpuInput = 0x1,
        [Obsolete("Deprecated in favour of \"MultiNodeCpuInput\"")]
        [NativeName("Name", "D3D12_DISPATCH_MODE_MULTI_NODE_CPU_INPUT")]
        DispatchModeMultiNodeCpuInput = 0x2,
        [Obsolete("Deprecated in favour of \"MultiNodeGpuInput\"")]
        [NativeName("Name", "D3D12_DISPATCH_MODE_MULTI_NODE_GPU_INPUT")]
        DispatchModeMultiNodeGpuInput = 0x3,
        [NativeName("Name", "D3D12_DISPATCH_MODE_NODE_CPU_INPUT")]
        NodeCpuInput = 0x0,
        [NativeName("Name", "D3D12_DISPATCH_MODE_NODE_GPU_INPUT")]
        NodeGpuInput = 0x1,
        [NativeName("Name", "D3D12_DISPATCH_MODE_MULTI_NODE_CPU_INPUT")]
        MultiNodeCpuInput = 0x2,
        [NativeName("Name", "D3D12_DISPATCH_MODE_MULTI_NODE_GPU_INPUT")]
        MultiNodeGpuInput = 0x3,
    }
}
