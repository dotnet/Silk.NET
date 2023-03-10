// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_FINDEX_SEARCH_OPS")]
    public enum FindexSearchOps : int
    {
        [NativeName("Name", "FindExSearchNameMatch")]
        FindExSearchNameMatch = 0x0,
        [NativeName("Name", "FindExSearchLimitToDirectories")]
        FindExSearchLimitToDirectories = 0x1,
        [NativeName("Name", "FindExSearchLimitToDevices")]
        FindExSearchLimitToDevices = 0x2,
        [NativeName("Name", "FindExSearchMaxSearchOp")]
        FindExSearchMaxSearchOp = 0x3,
    }
}
