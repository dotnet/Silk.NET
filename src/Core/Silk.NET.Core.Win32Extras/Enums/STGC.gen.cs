// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagSTGC")]
    public enum STGC : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "STGC_DEFAULT")]
        StgcDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Overwrite\"")]
        [NativeName("Name", "STGC_OVERWRITE")]
        StgcOverwrite = 0x1,
        [Obsolete("Deprecated in favour of \"Onlyifcurrent\"")]
        [NativeName("Name", "STGC_ONLYIFCURRENT")]
        StgcOnlyifcurrent = 0x2,
        [Obsolete("Deprecated in favour of \"Dangerouslycommitmerelytodiskcache\"")]
        [NativeName("Name", "STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE")]
        StgcDangerouslycommitmerelytodiskcache = 0x4,
        [Obsolete("Deprecated in favour of \"Consolidate\"")]
        [NativeName("Name", "STGC_CONSOLIDATE")]
        StgcConsolidate = 0x8,
        [NativeName("Name", "STGC_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "STGC_OVERWRITE")]
        Overwrite = 0x1,
        [NativeName("Name", "STGC_ONLYIFCURRENT")]
        Onlyifcurrent = 0x2,
        [NativeName("Name", "STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE")]
        Dangerouslycommitmerelytodiskcache = 0x4,
        [NativeName("Name", "STGC_CONSOLIDATE")]
        Consolidate = 0x8,
    }
}
