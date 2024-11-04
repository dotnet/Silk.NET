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
    [NativeName("Name", "D3D12_DISPATCH_GRAPH_DESC")]
    public unsafe partial struct DispatchGraphDesc
    {
        public DispatchGraphDesc
        (
            DispatchMode? mode = null,
            DispatchGraphDescUnion? anonymous = null,
            NodeCpuInput? nodeCPUInput = null,
            ulong? nodeGPUInput = null,
            MultiNodeCpuInput? multiNodeCPUInput = null,
            ulong? multiNodeGPUInput = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (nodeCPUInput is not null)
            {
                NodeCPUInput = nodeCPUInput.Value;
            }

            if (nodeGPUInput is not null)
            {
                NodeGPUInput = nodeGPUInput.Value;
            }

            if (multiNodeCPUInput is not null)
            {
                MultiNodeCPUInput = multiNodeCPUInput.Value;
            }

            if (multiNodeGPUInput is not null)
            {
                MultiNodeGPUInput = multiNodeGPUInput.Value;
            }
        }


        [NativeName("Type", "D3D12_DISPATCH_MODE")]
        [NativeName("Type.Name", "D3D12_DISPATCH_MODE")]
        [NativeName("Name", "Mode")]
        public DispatchMode Mode;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L20997_C5")]
        [NativeName("Name", "anonymous1")]
        public DispatchGraphDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref NodeCpuInput NodeCPUInput
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NodeCPUInput;
        }
#else
        public NodeCpuInput NodeCPUInput
        {
            get => Anonymous.NodeCPUInput;
            set => Anonymous.NodeCPUInput = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong NodeGPUInput
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NodeGPUInput;
        }
#else
        public ulong NodeGPUInput
        {
            get => Anonymous.NodeGPUInput;
            set => Anonymous.NodeGPUInput = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref MultiNodeCpuInput MultiNodeCPUInput
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].MultiNodeCPUInput;
        }
#else
        public MultiNodeCpuInput MultiNodeCPUInput
        {
            get => Anonymous.MultiNodeCPUInput;
            set => Anonymous.MultiNodeCPUInput = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong MultiNodeGPUInput
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].MultiNodeGPUInput;
        }
#else
        public ulong MultiNodeGPUInput
        {
            get => Anonymous.MultiNodeGPUInput;
            set => Anonymous.MultiNodeGPUInput = value;
        }
#endif

    }
}
