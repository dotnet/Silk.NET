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
    [NativeName("Name", "_EVENT_FILTER_EVENT_NAME")]
    public unsafe partial struct EventFilterEventName
    {
        public EventFilterEventName
        (
            ulong? matchAnyKeyword = null,
            ulong? matchAllKeyword = null,
            byte? level = null,
            byte? filterIn = null,
            ushort? nameCount = null
        ) : this()
        {
            if (matchAnyKeyword is not null)
            {
                MatchAnyKeyword = matchAnyKeyword.Value;
            }

            if (matchAllKeyword is not null)
            {
                MatchAllKeyword = matchAllKeyword.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (filterIn is not null)
            {
                FilterIn = filterIn.Value;
            }

            if (nameCount is not null)
            {
                NameCount = nameCount.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "MatchAnyKeyword")]
        public ulong MatchAnyKeyword;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "MatchAllKeyword")]
        public ulong MatchAllKeyword;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Level")]
        public byte Level;

        [NativeName("Type", "BOOLEAN")]
        [NativeName("Type.Name", "BOOLEAN")]
        [NativeName("Name", "FilterIn")]
        public byte FilterIn;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "NameCount")]
        public ushort NameCount;
        [NativeName("Type", "UCHAR[1]")]
        [NativeName("Type.Name", "UCHAR[1]")]
        [NativeName("Name", "Names")]
        public fixed byte Names[1];
    }
}
