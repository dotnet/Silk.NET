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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_QUEUE_DESC")]
    public unsafe partial struct QueueDesc
    {
        public QueueDesc
        (
            RequestSourceType? sourceType = null,
            ushort? capacity = null,
            Priority? priority = null,
            byte* name = null,
            Silk.NET.Direct3D12.ID3D12Device* device = null
        ) : this()
        {
            if (sourceType is not null)
            {
                SourceType = sourceType.Value;
            }

            if (capacity is not null)
            {
                Capacity = capacity.Value;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (device is not null)
            {
                Device = device;
            }
        }


        [NativeName("Type", "DSTORAGE_REQUEST_SOURCE_TYPE")]
        [NativeName("Type.Name", "DSTORAGE_REQUEST_SOURCE_TYPE")]
        [NativeName("Name", "SourceType")]
        public RequestSourceType SourceType;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "Capacity")]
        public ushort Capacity;

        [NativeName("Type", "DSTORAGE_PRIORITY")]
        [NativeName("Type.Name", "DSTORAGE_PRIORITY")]
        [NativeName("Name", "Priority")]
        public Priority Priority;

        [NativeName("Type", "const CHAR *")]
        [NativeName("Type.Name", "const CHAR *")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "ID3D12Device *")]
        [NativeName("Type.Name", "ID3D12Device *")]
        [NativeName("Name", "Device")]
        public Silk.NET.Direct3D12.ID3D12Device* Device;
    }
}
