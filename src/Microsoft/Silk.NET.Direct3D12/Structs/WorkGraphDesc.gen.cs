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
    [NativeName("Name", "D3D12_WORK_GRAPH_DESC")]
    public unsafe partial struct WorkGraphDesc
    {
        public WorkGraphDesc
        (
            char* programName = null,
            WorkGraphFlags? flags = null,
            uint? numEntrypoints = null,
            NodeID* pEntrypoints = null,
            uint? numExplicitlyDefinedNodes = null,
            Node* pExplicitlyDefinedNodes = null
        ) : this()
        {
            if (programName is not null)
            {
                ProgramName = programName;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numEntrypoints is not null)
            {
                NumEntrypoints = numEntrypoints.Value;
            }

            if (pEntrypoints is not null)
            {
                PEntrypoints = pEntrypoints;
            }

            if (numExplicitlyDefinedNodes is not null)
            {
                NumExplicitlyDefinedNodes = numExplicitlyDefinedNodes.Value;
            }

            if (pExplicitlyDefinedNodes is not null)
            {
                PExplicitlyDefinedNodes = pExplicitlyDefinedNodes;
            }
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "ProgramName")]
        public char* ProgramName;

        [NativeName("Type", "D3D12_WORK_GRAPH_FLAGS")]
        [NativeName("Type.Name", "D3D12_WORK_GRAPH_FLAGS")]
        [NativeName("Name", "Flags")]
        public WorkGraphFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumEntrypoints")]
        public uint NumEntrypoints;

        [NativeName("Type", "const D3D12_NODE_ID *")]
        [NativeName("Type.Name", "const D3D12_NODE_ID *")]
        [NativeName("Name", "pEntrypoints")]
        public NodeID* PEntrypoints;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumExplicitlyDefinedNodes")]
        public uint NumExplicitlyDefinedNodes;

        [NativeName("Type", "const D3D12_NODE *")]
        [NativeName("Type.Name", "const D3D12_NODE *")]
        [NativeName("Name", "pExplicitlyDefinedNodes")]
        public Node* PExplicitlyDefinedNodes;
    }
}
