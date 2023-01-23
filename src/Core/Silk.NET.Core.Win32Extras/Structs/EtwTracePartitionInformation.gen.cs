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
    [NativeName("Name", "_ETW_TRACE_PARTITION_INFORMATION")]
    public unsafe partial struct EtwTracePartitionInformation
    {
        public EtwTracePartitionInformation
        (
            Guid? partitionId = null,
            Guid? parentId = null,
            long? qpcOffsetFromRoot = null,
            uint? partitionType = null
        ) : this()
        {
            if (partitionId is not null)
            {
                PartitionId = partitionId.Value;
            }

            if (parentId is not null)
            {
                ParentId = parentId.Value;
            }

            if (qpcOffsetFromRoot is not null)
            {
                QpcOffsetFromRoot = qpcOffsetFromRoot.Value;
            }

            if (partitionType is not null)
            {
                PartitionType = partitionType.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "PartitionId")]
        public Guid PartitionId;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "ParentId")]
        public Guid ParentId;

        [NativeName("Type", "LONG64")]
        [NativeName("Type.Name", "LONG64")]
        [NativeName("Name", "QpcOffsetFromRoot")]
        public long QpcOffsetFromRoot;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "PartitionType")]
        public uint PartitionType;
    }
}
