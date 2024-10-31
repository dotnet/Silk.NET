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
    [NativeName("Name", "D3D12_NODE_OUTPUT_OVERRIDES")]
    public unsafe partial struct NodeOutputOverrides
    {
        public NodeOutputOverrides
        (
            uint? outputIndex = null,
            NodeID* pNewName = null,
            int* pAllowSparseNodes = null,
            uint* pMaxRecords = null,
            uint* pMaxRecordsSharedWithOutputIndex = null
        ) : this()
        {
            if (outputIndex is not null)
            {
                OutputIndex = outputIndex.Value;
            }

            if (pNewName is not null)
            {
                PNewName = pNewName;
            }

            if (pAllowSparseNodes is not null)
            {
                PAllowSparseNodes = pAllowSparseNodes;
            }

            if (pMaxRecords is not null)
            {
                PMaxRecords = pMaxRecords;
            }

            if (pMaxRecordsSharedWithOutputIndex is not null)
            {
                PMaxRecordsSharedWithOutputIndex = pMaxRecordsSharedWithOutputIndex;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIndex")]
        public uint OutputIndex;

        [NativeName("Type", "const D3D12_NODE_ID *")]
        [NativeName("Type.Name", "const D3D12_NODE_ID *")]
        [NativeName("Name", "pNewName")]
        public NodeID* PNewName;

        [NativeName("Type", "const BOOL *")]
        [NativeName("Type.Name", "const BOOL *")]
        [NativeName("Name", "pAllowSparseNodes")]
        public int* PAllowSparseNodes;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pMaxRecords")]
        public uint* PMaxRecords;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pMaxRecordsSharedWithOutputIndex")]
        public uint* PMaxRecordsSharedWithOutputIndex;
    }
}
