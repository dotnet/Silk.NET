// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_RENDERING_PRIORITY")]
    public enum RenderingPriority : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_NORMAL")]
        RenderingPriorityNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Low\"")]
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_LOW")]
        RenderingPriorityLow = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_FORCE_DWORD")]
        RenderingPriorityForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_LOW")]
        Low = 0x1,
        [NativeName("Name", "D2D1_RENDERING_PRIORITY_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
