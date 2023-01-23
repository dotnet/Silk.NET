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
    [NativeName("Name", "DSTORAGE_QUEUE_INFO")]
    public unsafe partial struct QueueInfo
    {
        public QueueInfo
        (
            QueueDesc? desc = null,
            ushort? emptySlotCount = null,
            ushort? requestCountUntilAutoSubmit = null
        ) : this()
        {
            if (desc is not null)
            {
                Desc = desc.Value;
            }

            if (emptySlotCount is not null)
            {
                EmptySlotCount = emptySlotCount.Value;
            }

            if (requestCountUntilAutoSubmit is not null)
            {
                RequestCountUntilAutoSubmit = requestCountUntilAutoSubmit.Value;
            }
        }


        [NativeName("Type", "DSTORAGE_QUEUE_DESC")]
        [NativeName("Type.Name", "DSTORAGE_QUEUE_DESC")]
        [NativeName("Name", "Desc")]
        public QueueDesc Desc;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "EmptySlotCount")]
        public ushort EmptySlotCount;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "RequestCountUntilAutoSubmit")]
        public ushort RequestCountUntilAutoSubmit;
    }
}
