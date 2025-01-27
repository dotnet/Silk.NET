// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSTGMOVE")]
    public enum STGMove : int
    {
        [Obsolete("Deprecated in favour of \"Move\"")]
        [NativeName("Name", "STGMOVE_MOVE")]
        StgmoveMove = 0x0,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "STGMOVE_COPY")]
        StgmoveCopy = 0x1,
        [Obsolete("Deprecated in favour of \"Shallowcopy\"")]
        [NativeName("Name", "STGMOVE_SHALLOWCOPY")]
        StgmoveShallowcopy = 0x2,
        [NativeName("Name", "STGMOVE_MOVE")]
        Move = 0x0,
        [NativeName("Name", "STGMOVE_COPY")]
        Copy = 0x1,
        [NativeName("Name", "STGMOVE_SHALLOWCOPY")]
        Shallowcopy = 0x2,
    }
}
