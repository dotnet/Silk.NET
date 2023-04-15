// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_FINDEX_SEARCH_OPS")]
    public enum FindexSearchOps : int
    {
        [Obsolete("Deprecated in favour of \"NameMatch\"")]
        [NativeName("Name", "FindExSearchNameMatch")]
        FindExSearchNameMatch = 0x0,
        [Obsolete("Deprecated in favour of \"LimitToDirectories\"")]
        [NativeName("Name", "FindExSearchLimitToDirectories")]
        FindExSearchLimitToDirectories = 0x1,
        [Obsolete("Deprecated in favour of \"LimitToDevices\"")]
        [NativeName("Name", "FindExSearchLimitToDevices")]
        FindExSearchLimitToDevices = 0x2,
        [Obsolete("Deprecated in favour of \"MaxSearchOp\"")]
        [NativeName("Name", "FindExSearchMaxSearchOp")]
        FindExSearchMaxSearchOp = 0x3,
        [NativeName("Name", "FindExSearchNameMatch")]
        NameMatch = 0x0,
        [NativeName("Name", "FindExSearchLimitToDirectories")]
        LimitToDirectories = 0x1,
        [NativeName("Name", "FindExSearchLimitToDevices")]
        LimitToDevices = 0x2,
        [NativeName("Name", "FindExSearchMaxSearchOp")]
        MaxSearchOp = 0x3,
    }
}
