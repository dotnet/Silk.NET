// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_LIFETIME_STATE")]
    public enum LifetimeState : int
    {
        [Obsolete("Deprecated in favour of \"InUse\"")]
        [NativeName("Name", "D3D12_LIFETIME_STATE_IN_USE")]
        LifetimeStateInUse = 0x0,
        [Obsolete("Deprecated in favour of \"NotInUse\"")]
        [NativeName("Name", "D3D12_LIFETIME_STATE_NOT_IN_USE")]
        LifetimeStateNotInUse = 0x1,
        [NativeName("Name", "D3D12_LIFETIME_STATE_IN_USE")]
        InUse = 0x0,
        [NativeName("Name", "D3D12_LIFETIME_STATE_NOT_IN_USE")]
        NotInUse = 0x1,
    }
}
