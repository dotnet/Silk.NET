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

namespace Silk.NET.Core.Win32Extras
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "_ETW_TRACE_PARTITION_INFORMATION_V2")]
    public unsafe partial struct EtwTracePartitionInformationV2
    {
        public EtwTracePartitionInformationV2
        (
            long? qpcOffsetFromRoot = null,
            uint? partitionType = null,
            char* partitionId = null,
            char* parentId = null
        ) : this()
        {
            if (qpcOffsetFromRoot is not null)
            {
                QpcOffsetFromRoot = qpcOffsetFromRoot.Value;
            }

            if (partitionType is not null)
            {
                PartitionType = partitionType.Value;
            }

            if (partitionId is not null)
            {
                PartitionId = partitionId;
            }

            if (parentId is not null)
            {
                ParentId = parentId;
            }
        }


        [NativeName("Type", "LONG64")]
        [NativeName("Type.Name", "LONG64")]
        [NativeName("Name", "QpcOffsetFromRoot")]
        public long QpcOffsetFromRoot;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "PartitionType")]
        public uint PartitionType;

        [NativeName("Type", "PWSTR")]
        [NativeName("Type.Name", "PWSTR")]
        [NativeName("Name", "PartitionId")]
        public char* PartitionId;

        [NativeName("Type", "PWSTR")]
        [NativeName("Type.Name", "PWSTR")]
        [NativeName("Name", "ParentId")]
        public char* ParentId;
    }
}
