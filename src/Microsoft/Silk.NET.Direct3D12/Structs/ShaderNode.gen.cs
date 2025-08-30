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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_SHADER_NODE")]
    public unsafe partial struct ShaderNode
    {
        public ShaderNode
        (
            char* shader = null,
            NodeOverridesType? overridesType = null,
            ShaderNodeUnion? anonymous = null,
            BroadcastingLaunchOverrides* pBroadcastingLaunchOverrides = null,
            CoalescingLaunchOverrides* pCoalescingLaunchOverrides = null,
            ThreadLaunchOverrides* pThreadLaunchOverrides = null,
            CommonComputeNodeOverrides* pCommonComputeNodeOverrides = null
        ) : this()
        {
            if (shader is not null)
            {
                Shader = shader;
            }

            if (overridesType is not null)
            {
                OverridesType = overridesType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Shader")]
        public char* Shader;

        [NativeName("Type", "D3D12_NODE_OVERRIDES_TYPE")]
        [NativeName("Type.Name", "D3D12_NODE_OVERRIDES_TYPE")]
        [NativeName("Name", "OverridesType")]
        public NodeOverridesType OverridesType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L14393_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderNodeUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref BroadcastingLaunchOverrides* PBroadcastingLaunchOverrides
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PBroadcastingLaunchOverrides;
        }
#else
        public BroadcastingLaunchOverrides* PBroadcastingLaunchOverrides
        {
            get => Anonymous.PBroadcastingLaunchOverrides;
            set => Anonymous.PBroadcastingLaunchOverrides = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CoalescingLaunchOverrides* PCoalescingLaunchOverrides
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PCoalescingLaunchOverrides;
        }
#else
        public CoalescingLaunchOverrides* PCoalescingLaunchOverrides
        {
            get => Anonymous.PCoalescingLaunchOverrides;
            set => Anonymous.PCoalescingLaunchOverrides = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ThreadLaunchOverrides* PThreadLaunchOverrides
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PThreadLaunchOverrides;
        }
#else
        public ThreadLaunchOverrides* PThreadLaunchOverrides
        {
            get => Anonymous.PThreadLaunchOverrides;
            set => Anonymous.PThreadLaunchOverrides = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CommonComputeNodeOverrides* PCommonComputeNodeOverrides
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PCommonComputeNodeOverrides;
        }
#else
        public CommonComputeNodeOverrides* PCommonComputeNodeOverrides
        {
            get => Anonymous.PCommonComputeNodeOverrides;
            set => Anonymous.PCommonComputeNodeOverrides = value;
        }
#endif

    }
}
