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
    [NativeName("Name", "__AnonymousRecord_d3d12_L20997_C5")]
    public unsafe partial struct DispatchGraphDescUnion
    {
        public DispatchGraphDescUnion
        (
            NodeCpuInput? nodeCPUInput = null,
            ulong? nodeGPUInput = null,
            MultiNodeCpuInput? multiNodeCPUInput = null,
            ulong? multiNodeGPUInput = null
        ) : this()
        {
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


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_NODE_CPU_INPUT")]
        [NativeName("Type.Name", "D3D12_NODE_CPU_INPUT")]
        [NativeName("Name", "NodeCPUInput")]
        public NodeCpuInput NodeCPUInput;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "NodeGPUInput")]
        public ulong NodeGPUInput;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_MULTI_NODE_CPU_INPUT")]
        [NativeName("Type.Name", "D3D12_MULTI_NODE_CPU_INPUT")]
        [NativeName("Name", "MultiNodeCPUInput")]
        public MultiNodeCpuInput MultiNodeCPUInput;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "MultiNodeGPUInput")]
        public ulong MultiNodeGPUInput;
    }
}
