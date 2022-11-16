// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_RENDER_TARGET_TYPE")]
    public enum RenderTargetType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_DEFAULT")]
        RenderTargetTypeDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_SOFTWARE")]
        RenderTargetTypeSoftware = 0x1,
        [Obsolete("Deprecated in favour of \"Hardware\"")]
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_HARDWARE")]
        RenderTargetTypeHardware = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_FORCE_DWORD")]
        RenderTargetTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_SOFTWARE")]
        Software = 0x1,
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_HARDWARE")]
        Hardware = 0x2,
        [NativeName("Name", "D2D1_RENDER_TARGET_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
