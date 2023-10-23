// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagMSHLFLAGS")]
    public enum MSHLFlags : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "MSHLFLAGS_NORMAL")]
        MshlflagsNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Tablestrong\"")]
        [NativeName("Name", "MSHLFLAGS_TABLESTRONG")]
        MshlflagsTablestrong = 0x1,
        [Obsolete("Deprecated in favour of \"Tableweak\"")]
        [NativeName("Name", "MSHLFLAGS_TABLEWEAK")]
        MshlflagsTableweak = 0x2,
        [Obsolete("Deprecated in favour of \"Noping\"")]
        [NativeName("Name", "MSHLFLAGS_NOPING")]
        MshlflagsNoping = 0x4,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "MSHLFLAGS_RESERVED1")]
        MshlflagsReserved1 = 0x8,
        [Obsolete("Deprecated in favour of \"Reserved2\"")]
        [NativeName("Name", "MSHLFLAGS_RESERVED2")]
        MshlflagsReserved2 = 0x10,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "MSHLFLAGS_RESERVED3")]
        MshlflagsReserved3 = 0x20,
        [Obsolete("Deprecated in favour of \"Reserved4\"")]
        [NativeName("Name", "MSHLFLAGS_RESERVED4")]
        MshlflagsReserved4 = 0x40,
        [NativeName("Name", "MSHLFLAGS_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "MSHLFLAGS_TABLESTRONG")]
        Tablestrong = 0x1,
        [NativeName("Name", "MSHLFLAGS_TABLEWEAK")]
        Tableweak = 0x2,
        [NativeName("Name", "MSHLFLAGS_NOPING")]
        Noping = 0x4,
        [NativeName("Name", "MSHLFLAGS_RESERVED1")]
        Reserved1 = 0x8,
        [NativeName("Name", "MSHLFLAGS_RESERVED2")]
        Reserved2 = 0x10,
        [NativeName("Name", "MSHLFLAGS_RESERVED3")]
        Reserved3 = 0x20,
        [NativeName("Name", "MSHLFLAGS_RESERVED4")]
        Reserved4 = 0x40,
    }
}
