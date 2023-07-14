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
    [NativeName("Name", "_EVENT_FILTER_EVENT_ID")]
    public unsafe partial struct EventFilterEventID
    {
        public EventFilterEventID
        (
            byte? filterIn = null,
            byte? reserved = null,
            ushort? count = null
        ) : this()
        {
            if (filterIn is not null)
            {
                FilterIn = filterIn.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }
        }


        [NativeName("Type", "BOOLEAN")]
        [NativeName("Type.Name", "BOOLEAN")]
        [NativeName("Name", "FilterIn")]
        public byte FilterIn;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Reserved")]
        public byte Reserved;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Count")]
        public ushort Count;
        [NativeName("Type", "USHORT[1]")]
        [NativeName("Type.Name", "USHORT[1]")]
        [NativeName("Name", "Events")]
        public fixed ushort Events[1];
    }
}
