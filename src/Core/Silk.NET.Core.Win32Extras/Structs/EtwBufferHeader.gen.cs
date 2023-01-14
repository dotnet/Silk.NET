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
    [NativeName("Name", "ETW_BUFFER_HEADER")]
    public unsafe partial struct EtwBufferHeader
    {
        public EtwBufferHeader
        (
            long? timeStamp = null,
            EtwBufferContext? clientContext = null,
            uint? reserved3 = null,
            uint? filledBytes = null
        ) : this()
        {
            if (timeStamp is not null)
            {
                TimeStamp = timeStamp.Value;
            }

            if (clientContext is not null)
            {
                ClientContext = clientContext.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (filledBytes is not null)
            {
                FilledBytes = filledBytes.Value;
            }
        }

        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "Reserved1")]
        public fixed uint Reserved1[4];

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "TimeStamp")]
        public long TimeStamp;
        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "Reserved2")]
        public fixed uint Reserved2[4];

        [NativeName("Type", "ETW_BUFFER_CONTEXT")]
        [NativeName("Type.Name", "ETW_BUFFER_CONTEXT")]
        [NativeName("Name", "ClientContext")]
        public EtwBufferContext ClientContext;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Reserved3")]
        public uint Reserved3;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FilledBytes")]
        public uint FilledBytes;
        [NativeName("Type", "ULONG[5]")]
        [NativeName("Type.Name", "ULONG[5]")]
        [NativeName("Name", "Reserved4")]
        public fixed uint Reserved4[5];
    }
}
