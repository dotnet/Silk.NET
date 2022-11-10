// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_EMBOSS_PROP")]
    public enum EmbossProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "D2D1_EMBOSS_PROP_HEIGHT")]
        EmbossPropHeight = 0x0,
        [Obsolete("Deprecated in favour of \"Direction\"")]
        [NativeName("Name", "D2D1_EMBOSS_PROP_DIRECTION")]
        EmbossPropDirection = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_EMBOSS_PROP_FORCE_DWORD")]
        EmbossPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_EMBOSS_PROP_HEIGHT")]
        Height = 0x0,
        [NativeName("Name", "D2D1_EMBOSS_PROP_DIRECTION")]
        Direction = 0x1,
        [NativeName("Name", "D2D1_EMBOSS_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
