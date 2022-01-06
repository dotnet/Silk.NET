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
        [NativeName("Name", "DXGI_DEBUG_RLO_SUMMARY")]
        DebugRloSummary = 0x1,
        [NativeName("Name", "DXGI_DEBUG_RLO_DETAIL")]
        DebugRloDetail = 0x2,
        [NativeName("Name", "DXGI_DEBUG_RLO_IGNORE_INTERNAL")]
        DebugRloIgnoreInternal = 0x4,
        [NativeName("Name", "DXGI_DEBUG_RLO_ALL")]
        DebugRloAll = 0x7,
    }
}
