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
    [NativeName("Name", "_CLASSIC_EVENT_ID")]
    public unsafe partial struct ClassicEventID
    {
        public ClassicEventID
        (
            Guid? eventGuid = null,
            byte? type = null
        ) : this()
        {
            if (eventGuid is not null)
            {
                EventGuid = eventGuid.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "EventGuid")]
        public Guid EventGuid;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Type")]
        public byte Type;
        [NativeName("Type", "UCHAR[7]")]
        [NativeName("Type.Name", "UCHAR[7]")]
        [NativeName("Name", "Reserved")]
        public fixed byte Reserved[7];
    }
}
