// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY")]
    public enum BackfaceVisibility : int
    {
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE")]
        Visible = 0x0,
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN")]
        Hidden = 0x1,
        [NativeName("Name", "DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
