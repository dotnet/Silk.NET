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
    [NativeName("Name", "D3D12_MULTI_NODE_GPU_INPUT")]
    public unsafe partial struct MultiNodeGpuInput
    {
        public MultiNodeGpuInput
        (
            uint? numNodeInputs = null,
            GpuVirtualAddressAndStride? nodeInputs = null
        ) : this()
        {
            if (numNodeInputs is not null)
            {
                NumNodeInputs = numNodeInputs.Value;
            }

            if (nodeInputs is not null)
            {
                NodeInputs = nodeInputs.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumNodeInputs")]
        public uint NumNodeInputs;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "NodeInputs")]
        public GpuVirtualAddressAndStride NodeInputs;
    }
}
