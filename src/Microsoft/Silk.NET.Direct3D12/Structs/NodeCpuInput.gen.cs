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
    [NativeName("Name", "D3D12_NODE_CPU_INPUT")]
    public unsafe partial struct NodeCpuInput
    {
        public NodeCpuInput
        (
            uint? entrypointIndex = null,
            uint? numRecords = null,
            void* pRecords = null,
            ulong? recordStrideInBytes = null
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

            if (pRecords is not null)
            {
                PRecords = pRecords;
            }

            if (recordStrideInBytes is not null)
            {
                RecordStrideInBytes = recordStrideInBytes.Value;
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

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pRecords")]
        public void* PRecords;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "RecordStrideInBytes")]
        public ulong RecordStrideInBytes;
    }
}
