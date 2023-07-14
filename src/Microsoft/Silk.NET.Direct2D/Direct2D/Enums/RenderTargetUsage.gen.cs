// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_RENDER_TARGET_USAGE")]
    public enum RenderTargetUsage : int
    {
        [NativeName("Name", "D2D1_RENDER_TARGET_USAGE_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING")]
        ForceBitmapRemoting = 0x1,
        [NativeName("Name", "D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE")]
        GdiCompatible = 0x2,
        [NativeName("Name", "D2D1_RENDER_TARGET_USAGE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
