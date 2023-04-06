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
    [NativeName("Name", "_EVENT_FILTER_HEADER")]
    public unsafe partial struct EventFilterHeader
    {
        public EventFilterHeader
        (
            ushort? id = null,
            byte? version = null,
            ulong? instanceId = null,
            uint? size = null,
            uint? nextOffset = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (instanceId is not null)
            {
                InstanceId = instanceId.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (nextOffset is not null)
            {
                NextOffset = nextOffset.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Id")]
        public ushort Id;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Version")]
        public byte Version;
        [NativeName("Type", "UCHAR[5]")]
        [NativeName("Type.Name", "UCHAR[5]")]
        [NativeName("Name", "Reserved")]
        public fixed byte Reserved[5];

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "InstanceId")]
        public ulong InstanceId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NextOffset")]
        public uint NextOffset;
    }
}
