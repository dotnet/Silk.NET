// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_VERSION")]
    public enum DredVersion : int
    {
        [Obsolete("Deprecated in favour of \"D3D1210\"")]
        [NativeName("Name", "D3D12_DRED_VERSION_1_0")]
        DredVersion10 = 0x1,
        [Obsolete("Deprecated in favour of \"D3D1211\"")]
        [NativeName("Name", "D3D12_DRED_VERSION_1_1")]
        DredVersion11 = 0x2,
        [Obsolete("Deprecated in favour of \"D3D1212\"")]
        [NativeName("Name", "D3D12_DRED_VERSION_1_2")]
        DredVersion12 = 0x3,
        [Obsolete("Deprecated in favour of \"D3D1213\"")]
        [NativeName("Name", "D3D12_DRED_VERSION_1_3")]
        DredVersion13 = 0x4,
        [NativeName("Name", "D3D12_DRED_VERSION_1_0")]
        D3D1210 = 0x1,
        [NativeName("Name", "D3D12_DRED_VERSION_1_1")]
        D3D1211 = 0x2,
        [NativeName("Name", "D3D12_DRED_VERSION_1_2")]
        D3D1212 = 0x3,
        [NativeName("Name", "D3D12_DRED_VERSION_1_3")]
        D3D1213 = 0x4,
    }
}
