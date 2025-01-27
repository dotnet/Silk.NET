// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagPOINTERINACTIVE")]
    public enum PointerInactive : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Activateonentry\"")]
        [NativeName("Name", "POINTERINACTIVE_ACTIVATEONENTRY")]
        PointerinactiveActivateonentry = 0x1,
        [Obsolete("Deprecated in favour of \"Deactivateonleave\"")]
        [NativeName("Name", "POINTERINACTIVE_DEACTIVATEONLEAVE")]
        PointerinactiveDeactivateonleave = 0x2,
        [Obsolete("Deprecated in favour of \"Activateondrag\"")]
        [NativeName("Name", "POINTERINACTIVE_ACTIVATEONDRAG")]
        PointerinactiveActivateondrag = 0x4,
        [NativeName("Name", "POINTERINACTIVE_ACTIVATEONENTRY")]
        Activateonentry = 0x1,
        [NativeName("Name", "POINTERINACTIVE_DEACTIVATEONLEAVE")]
        Deactivateonleave = 0x2,
        [NativeName("Name", "POINTERINACTIVE_ACTIVATEONDRAG")]
        Activateondrag = 0x4,
    }
}
