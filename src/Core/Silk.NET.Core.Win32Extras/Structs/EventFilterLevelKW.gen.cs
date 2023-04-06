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
    [NativeName("Name", "_EVENT_FILTER_LEVEL_KW")]
    public unsafe partial struct EventFilterLevelKW
    {
        public EventFilterLevelKW
        (
            ulong? matchAnyKeyword = null,
            ulong? matchAllKeyword = null,
            byte? level = null,
            byte? filterIn = null
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
    }
}
