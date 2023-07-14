// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_ETW_PMC_COUNTER_OWNER_TYPE")]
    public enum EtwPmcCounterOwnerType : int
    {
        [Obsolete("Deprecated in favour of \"Free\"")]
        [NativeName("Name", "EtwPmcOwnerFree")]
        EtwPmcOwnerFree = 0x0,
        [Obsolete("Deprecated in favour of \"Untagged\"")]
        [NativeName("Name", "EtwPmcOwnerUntagged")]
        EtwPmcOwnerUntagged = 0x1,
        [Obsolete("Deprecated in favour of \"Tagged\"")]
        [NativeName("Name", "EtwPmcOwnerTagged")]
        EtwPmcOwnerTagged = 0x2,
        [Obsolete("Deprecated in favour of \"TaggedWithSource\"")]
        [NativeName("Name", "EtwPmcOwnerTaggedWithSource")]
        EtwPmcOwnerTaggedWithSource = 0x3,
        [NativeName("Name", "EtwPmcOwnerFree")]
        Free = 0x0,
        [NativeName("Name", "EtwPmcOwnerUntagged")]
        Untagged = 0x1,
        [NativeName("Name", "EtwPmcOwnerTagged")]
        Tagged = 0x2,
        [NativeName("Name", "EtwPmcOwnerTaggedWithSource")]
        TaggedWithSource = 0x3,
    }
}
