// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS")]
    public enum CompatibleRenderTargetOptions : int
    {
        [NativeName("Name", "D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE")]
        GdiCompatible = 0x1,
        [NativeName("Name", "D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
