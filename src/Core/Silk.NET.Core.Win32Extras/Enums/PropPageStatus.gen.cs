// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagPROPPAGESTATUS")]
    public enum PropPageStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Dirty\"")]
        [NativeName("Name", "PROPPAGESTATUS_DIRTY")]
        ProppagestatusDirty = 0x1,
        [Obsolete("Deprecated in favour of \"Validate\"")]
        [NativeName("Name", "PROPPAGESTATUS_VALIDATE")]
        ProppagestatusValidate = 0x2,
        [Obsolete("Deprecated in favour of \"Clean\"")]
        [NativeName("Name", "PROPPAGESTATUS_CLEAN")]
        ProppagestatusClean = 0x4,
        [NativeName("Name", "PROPPAGESTATUS_DIRTY")]
        Dirty = 0x1,
        [NativeName("Name", "PROPPAGESTATUS_VALIDATE")]
        Validate = 0x2,
        [NativeName("Name", "PROPPAGESTATUS_CLEAN")]
        Clean = 0x4,
    }
}
