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
    [NativeName("Name", "D3D12_NODE_GPU_INPUT")]
    public unsafe partial struct NodeGpuInput
    {
        public NodeGpuInput
        (
            uint? entrypointIndex = null,
            uint? numRecords = null,
            GpuVirtualAddressAndStride? records = null
        ) : this()
        {
            if (entrypointIndex is not null)
            {
                EntrypointIndex = entrypointIndex.Value;
            }

            if (numRecords is not null)
            {
                NumRecords = numRecords.Value;
            }

            if (records is not null)
            {
                Records = records.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EntrypointIndex")]
        public uint EntrypointIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRecords")]
        public uint NumRecords;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "Records")]
        public GpuVirtualAddressAndStride Records;
    }
}
