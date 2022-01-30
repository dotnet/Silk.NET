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
    [NativeName("Name", "_SYSTEMTIME")]
    public unsafe partial struct Systemtime
    {
        public Systemtime
        (
            ushort? wYear = null,
            ushort? wMonth = null,
            ushort? wDayOfWeek = null,
            ushort? wDay = null,
            ushort? wHour = null,
            ushort? wMinute = null,
            ushort? wSecond = null,
            ushort? wMilliseconds = null
        ) : this()
        {
            if (wYear is not null)
            {
                WYear = wYear.Value;
            }

            if (wMonth is not null)
            {
                WMonth = wMonth.Value;
            }

            if (wDayOfWeek is not null)
            {
                WDayOfWeek = wDayOfWeek.Value;
            }

            if (wDay is not null)
            {
                WDay = wDay.Value;
            }

            if (wHour is not null)
            {
                WHour = wHour.Value;
            }

            if (wMinute is not null)
            {
                WMinute = wMinute.Value;
            }

            if (wSecond is not null)
            {
                WSecond = wSecond.Value;
            }

            if (wMilliseconds is not null)
            {
                WMilliseconds = wMilliseconds.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wYear")]
        public ushort WYear;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMonth")]
        public ushort WMonth;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wDayOfWeek")]
        public ushort WDayOfWeek;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wDay")]
        public ushort WDay;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wHour")]
        public ushort WHour;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMinute")]
        public ushort WMinute;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wSecond")]
        public ushort WSecond;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMilliseconds")]
        public ushort WMilliseconds;
    }
}
