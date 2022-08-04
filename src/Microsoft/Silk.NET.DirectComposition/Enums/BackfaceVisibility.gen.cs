// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY")]
    public enum BackfaceVisibility : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Visible\"")]
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE")]
        BackfaceVisibilityVisible = 0x0,
        [Obsolete("Deprecated in favour of \"Hidden\"")]
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN")]
        BackfaceVisibilityHidden = 0x1,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT")]
        BackfaceVisibilityInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE")]
        Visible = 0x0,
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN")]
        Hidden = 0x1,
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
