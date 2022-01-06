// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_ETW_PMC_COUNTER_OWNER_TYPE")]
    public enum EtwPmcCounterOwnerType : int
    {
        [NativeName("Name", "EtwPmcOwnerFree")]
        EtwPmcOwnerFree = 0x0,
        [NativeName("Name", "EtwPmcOwnerUntagged")]
        EtwPmcOwnerUntagged = 0x1,
        [NativeName("Name", "EtwPmcOwnerTagged")]
        EtwPmcOwnerTagged = 0x2,
        [NativeName("Name", "EtwPmcOwnerTaggedWithSource")]
        EtwPmcOwnerTaggedWithSource = 0x3,
    }
}
