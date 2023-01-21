// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_BORDER_PROP")]
    public enum BorderProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EdgeModeX\"")]
        [NativeName("Name", "D2D1_BORDER_PROP_EDGE_MODE_X")]
        BorderPropEdgeModeX = 0x0,
        [Obsolete("Deprecated in favour of \"EdgeModeY\"")]
        [NativeName("Name", "D2D1_BORDER_PROP_EDGE_MODE_Y")]
        BorderPropEdgeModeY = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BORDER_PROP_FORCE_DWORD")]
        BorderPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BORDER_PROP_EDGE_MODE_X")]
        EdgeModeX = 0x0,
        [NativeName("Name", "D2D1_BORDER_PROP_EDGE_MODE_Y")]
        EdgeModeY = 0x1,
        [NativeName("Name", "D2D1_BORDER_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
