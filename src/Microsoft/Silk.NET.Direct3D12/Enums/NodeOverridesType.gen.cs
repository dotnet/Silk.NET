// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE")]
    public enum NodeOverridesType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_NONE")]
        NodeOverridesTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"BroadcastingLaunch\"")]
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_BROADCASTING_LAUNCH")]
        NodeOverridesTypeBroadcastingLaunch = 0x1,
        [Obsolete("Deprecated in favour of \"CoalescingLaunch\"")]
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_COALESCING_LAUNCH")]
        NodeOverridesTypeCoalescingLaunch = 0x2,
        [Obsolete("Deprecated in favour of \"ThreadLaunch\"")]
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_THREAD_LAUNCH")]
        NodeOverridesTypeThreadLaunch = 0x3,
        [Obsolete("Deprecated in favour of \"CommonCompute\"")]
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_COMMON_COMPUTE")]
        NodeOverridesTypeCommonCompute = 0x4,
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_BROADCASTING_LAUNCH")]
        BroadcastingLaunch = 0x1,
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_COALESCING_LAUNCH")]
        CoalescingLaunch = 0x2,
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_THREAD_LAUNCH")]
        ThreadLaunch = 0x3,
        [NativeName("Name", "D3D12_NODE_OVERRIDES_TYPE_COMMON_COMPUTE")]
        CommonCompute = 0x4,
    }
}
