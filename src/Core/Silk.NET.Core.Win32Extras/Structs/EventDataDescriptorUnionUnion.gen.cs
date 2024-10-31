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
    [NativeName("Name", "__AnonymousRecord_evntprov_L185_C9")]
    public unsafe partial struct EventDataDescriptorUnionUnion
    {
        public EventDataDescriptorUnionUnion
        (
            byte? type = null,
            byte? reserved1 = null,
            ushort? reserved2 = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Type")]
        public byte Type;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Reserved1")]
        public byte Reserved1;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Reserved2")]
        public ushort Reserved2;
    }
}
