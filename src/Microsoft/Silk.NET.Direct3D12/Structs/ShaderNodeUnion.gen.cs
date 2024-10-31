// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L14393_C5")]
    public unsafe partial struct ShaderNodeUnion
    {
        public ShaderNodeUnion
        (
            BroadcastingLaunchOverrides* pBroadcastingLaunchOverrides = null,
            CoalescingLaunchOverrides* pCoalescingLaunchOverrides = null,
            ThreadLaunchOverrides* pThreadLaunchOverrides = null,
            CommonComputeNodeOverrides* pCommonComputeNodeOverrides = null
        ) : this()
        {
            if (pBroadcastingLaunchOverrides is not null)
            {
                PBroadcastingLaunchOverrides = pBroadcastingLaunchOverrides;
            }

            if (pCoalescingLaunchOverrides is not null)
            {
                PCoalescingLaunchOverrides = pCoalescingLaunchOverrides;
            }

            if (pThreadLaunchOverrides is not null)
            {
                PThreadLaunchOverrides = pThreadLaunchOverrides;
            }

            if (pCommonComputeNodeOverrides is not null)
            {
                PCommonComputeNodeOverrides = pCommonComputeNodeOverrides;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_BROADCASTING_LAUNCH_OVERRIDES *")]
        [NativeName("Type.Name", "const D3D12_BROADCASTING_LAUNCH_OVERRIDES *")]
        [NativeName("Name", "pBroadcastingLaunchOverrides")]
        public BroadcastingLaunchOverrides* PBroadcastingLaunchOverrides;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_COALESCING_LAUNCH_OVERRIDES *")]
        [NativeName("Type.Name", "const D3D12_COALESCING_LAUNCH_OVERRIDES *")]
        [NativeName("Name", "pCoalescingLaunchOverrides")]
        public CoalescingLaunchOverrides* PCoalescingLaunchOverrides;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_THREAD_LAUNCH_OVERRIDES *")]
        [NativeName("Type.Name", "const D3D12_THREAD_LAUNCH_OVERRIDES *")]
        [NativeName("Name", "pThreadLaunchOverrides")]
        public ThreadLaunchOverrides* PThreadLaunchOverrides;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_COMMON_COMPUTE_NODE_OVERRIDES *")]
        [NativeName("Type.Name", "const D3D12_COMMON_COMPUTE_NODE_OVERRIDES *")]
        [NativeName("Name", "pCommonComputeNodeOverrides")]
        public CommonComputeNodeOverrides* PCommonComputeNodeOverrides;
    }
}
