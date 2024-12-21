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
    [NativeName("Name", "D3D12_BROADCASTING_LAUNCH_OVERRIDES")]
    public unsafe partial struct BroadcastingLaunchOverrides
    {
        public BroadcastingLaunchOverrides
        (
            uint* pLocalRootArgumentsTableIndex = null,
            int* pProgramEntry = null,
            NodeID* pNewName = null,
            NodeID* pShareInputOf = null,
            uint* pDispatchGrid = null,
            uint* pMaxDispatchGrid = null,
            uint? numOutputOverrides = null,
            NodeOutputOverrides* pOutputOverrides = null
        ) : this()
        {
            if (pLocalRootArgumentsTableIndex is not null)
            {
                PLocalRootArgumentsTableIndex = pLocalRootArgumentsTableIndex;
            }

            if (pProgramEntry is not null)
            {
                PProgramEntry = pProgramEntry;
            }

            if (pNewName is not null)
            {
                PNewName = pNewName;
            }

            if (pShareInputOf is not null)
            {
                PShareInputOf = pShareInputOf;
            }

            if (pDispatchGrid is not null)
            {
                PDispatchGrid = pDispatchGrid;
            }

            if (pMaxDispatchGrid is not null)
            {
                PMaxDispatchGrid = pMaxDispatchGrid;
            }

            if (numOutputOverrides is not null)
            {
                NumOutputOverrides = numOutputOverrides.Value;
            }

            if (pOutputOverrides is not null)
            {
                POutputOverrides = pOutputOverrides;
            }
        }


        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pLocalRootArgumentsTableIndex")]
        public uint* PLocalRootArgumentsTableIndex;

        [NativeName("Type", "const BOOL *")]
        [NativeName("Type.Name", "const BOOL *")]
        [NativeName("Name", "pProgramEntry")]
        public int* PProgramEntry;

        [NativeName("Type", "const D3D12_NODE_ID *")]
        [NativeName("Type.Name", "const D3D12_NODE_ID *")]
        [NativeName("Name", "pNewName")]
        public NodeID* PNewName;

        [NativeName("Type", "const D3D12_NODE_ID *")]
        [NativeName("Type.Name", "const D3D12_NODE_ID *")]
        [NativeName("Name", "pShareInputOf")]
        public NodeID* PShareInputOf;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pDispatchGrid")]
        public uint* PDispatchGrid;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pMaxDispatchGrid")]
        public uint* PMaxDispatchGrid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumOutputOverrides")]
        public uint NumOutputOverrides;

        [NativeName("Type", "const D3D12_NODE_OUTPUT_OVERRIDES *")]
        [NativeName("Type.Name", "const D3D12_NODE_OUTPUT_OVERRIDES *")]
        [NativeName("Name", "pOutputOverrides")]
        public NodeOutputOverrides* POutputOverrides;
    }
}
