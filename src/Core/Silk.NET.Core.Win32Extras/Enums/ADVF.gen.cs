// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagADVF")]
    public enum ADVF : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Nodata\"")]
        [NativeName("Name", "ADVF_NODATA")]
        AdvfNodata = 0x1,
        [Obsolete("Deprecated in favour of \"Primefirst\"")]
        [NativeName("Name", "ADVF_PRIMEFIRST")]
        AdvfPrimefirst = 0x2,
        [Obsolete("Deprecated in favour of \"Onlyonce\"")]
        [NativeName("Name", "ADVF_ONLYONCE")]
        AdvfOnlyonce = 0x4,
        [Obsolete("Deprecated in favour of \"Dataonstop\"")]
        [NativeName("Name", "ADVF_DATAONSTOP")]
        AdvfDataonstop = 0x40,
        [Obsolete("Deprecated in favour of \"AcheNohandler\"")]
        [NativeName("Name", "ADVFCACHE_NOHANDLER")]
        AdvfcacheNohandler = 0x8,
        [Obsolete("Deprecated in favour of \"AcheForcebuiltin\"")]
        [NativeName("Name", "ADVFCACHE_FORCEBUILTIN")]
        AdvfcacheForcebuiltin = 0x10,
        [Obsolete("Deprecated in favour of \"AcheOnsave\"")]
        [NativeName("Name", "ADVFCACHE_ONSAVE")]
        AdvfcacheOnsave = 0x20,
        [NativeName("Name", "ADVF_NODATA")]
        Nodata = 0x1,
        [NativeName("Name", "ADVF_PRIMEFIRST")]
        Primefirst = 0x2,
        [NativeName("Name", "ADVF_ONLYONCE")]
        Onlyonce = 0x4,
        [NativeName("Name", "ADVF_DATAONSTOP")]
        Dataonstop = 0x40,
        [NativeName("Name", "ADVFCACHE_NOHANDLER")]
        AcheNohandler = 0x8,
        [NativeName("Name", "ADVFCACHE_FORCEBUILTIN")]
        AcheForcebuiltin = 0x10,
        [NativeName("Name", "ADVFCACHE_ONSAVE")]
        AcheOnsave = 0x20,
    }
}
