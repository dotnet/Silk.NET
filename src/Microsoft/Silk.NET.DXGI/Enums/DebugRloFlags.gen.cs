// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_DEBUG_RLO_FLAGS")]
    public enum DebugRloFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Summary\"")]
        [NativeName("Name", "DXGI_DEBUG_RLO_SUMMARY")]
        DebugRloSummary = 0x1,
        [Obsolete("Deprecated in favour of \"Detail\"")]
        [NativeName("Name", "DXGI_DEBUG_RLO_DETAIL")]
        DebugRloDetail = 0x2,
        [Obsolete("Deprecated in favour of \"IgnoreInternal\"")]
        [NativeName("Name", "DXGI_DEBUG_RLO_IGNORE_INTERNAL")]
        DebugRloIgnoreInternal = 0x4,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "DXGI_DEBUG_RLO_ALL")]
        DebugRloAll = 0x7,
        [NativeName("Name", "DXGI_DEBUG_RLO_SUMMARY")]
        Summary = 0x1,
        [NativeName("Name", "DXGI_DEBUG_RLO_DETAIL")]
        Detail = 0x2,
        [NativeName("Name", "DXGI_DEBUG_RLO_IGNORE_INTERNAL")]
        IgnoreInternal = 0x4,
        [NativeName("Name", "DXGI_DEBUG_RLO_ALL")]
        All = 0x7,
    }
}
