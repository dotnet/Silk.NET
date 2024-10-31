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
    [NativeName("Name", "D3D12_MULTI_NODE_CPU_INPUT")]
    public unsafe partial struct MultiNodeCpuInput
    {
        public MultiNodeCpuInput
        (
            uint? numNodeInputs = null,
            NodeCpuInput* pNodeInputs = null,
            ulong? nodeInputStrideInBytes = null
        ) : this()
        {
            if (numNodeInputs is not null)
            {
                NumNodeInputs = numNodeInputs.Value;
            }

            if (pNodeInputs is not null)
            {
                PNodeInputs = pNodeInputs;
            }

            if (nodeInputStrideInBytes is not null)
            {
                NodeInputStrideInBytes = nodeInputStrideInBytes.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumNodeInputs")]
        public uint NumNodeInputs;

        [NativeName("Type", "D3D12_NODE_CPU_INPUT *")]
        [NativeName("Type.Name", "D3D12_NODE_CPU_INPUT *")]
        [NativeName("Name", "pNodeInputs")]
        public NodeCpuInput* PNodeInputs;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NodeInputStrideInBytes")]
        public ulong NodeInputStrideInBytes;
    }
}
