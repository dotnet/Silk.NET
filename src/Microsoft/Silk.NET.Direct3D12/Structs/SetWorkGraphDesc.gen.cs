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
    [NativeName("Name", "D3D12_SET_WORK_GRAPH_DESC")]
    public unsafe partial struct SetWorkGraphDesc
    {
        public SetWorkGraphDesc
        (
            ProgramIdentifier? programIdentifier = null,
            SetWorkGraphFlags? flags = null,
            GpuVirtualAddressRange? backingMemory = null,
            GpuVirtualAddressRangeAndStride? nodeLocalRootArgumentsTable = null
        ) : this()
        {
            if (programIdentifier is not null)
            {
                ProgramIdentifier = programIdentifier.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (backingMemory is not null)
            {
                BackingMemory = backingMemory.Value;
            }

            if (nodeLocalRootArgumentsTable is not null)
            {
                NodeLocalRootArgumentsTable = nodeLocalRootArgumentsTable.Value;
            }
        }


        [NativeName("Type", "D3D12_PROGRAM_IDENTIFIER")]
        [NativeName("Type.Name", "D3D12_PROGRAM_IDENTIFIER")]
        [NativeName("Name", "ProgramIdentifier")]
        public ProgramIdentifier ProgramIdentifier;

        [NativeName("Type", "D3D12_SET_WORK_GRAPH_FLAGS")]
        [NativeName("Type.Name", "D3D12_SET_WORK_GRAPH_FLAGS")]
        [NativeName("Name", "Flags")]
        public SetWorkGraphFlags Flags;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE")]
        [NativeName("Name", "BackingMemory")]
        public GpuVirtualAddressRange BackingMemory;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Name", "NodeLocalRootArgumentsTable")]
        public GpuVirtualAddressRangeAndStride NodeLocalRootArgumentsTable;
    }
}
