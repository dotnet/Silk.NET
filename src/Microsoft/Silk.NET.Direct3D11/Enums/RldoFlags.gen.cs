// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_RLDO_FLAGS")]
    public enum RldoFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Summary\"")]
        [NativeName("Name", "D3D11_RLDO_SUMMARY")]
        RldoSummary = 0x1,
        [Obsolete("Deprecated in favour of \"Detail\"")]
        [NativeName("Name", "D3D11_RLDO_DETAIL")]
        RldoDetail = 0x2,
        [Obsolete("Deprecated in favour of \"IgnoreInternal\"")]
        [NativeName("Name", "D3D11_RLDO_IGNORE_INTERNAL")]
        RldoIgnoreInternal = 0x4,
        [NativeName("Name", "D3D11_RLDO_SUMMARY")]
        Summary = 0x1,
        [NativeName("Name", "D3D11_RLDO_DETAIL")]
        Detail = 0x2,
        [NativeName("Name", "D3D11_RLDO_IGNORE_INTERNAL")]
        IgnoreInternal = 0x4,
    }
}
