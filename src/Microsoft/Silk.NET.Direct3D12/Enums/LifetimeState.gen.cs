// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_LIFETIME_STATE")]
    public enum LifetimeState : int
    {
        [NativeName("Name", "D3D12_LIFETIME_STATE_IN_USE")]
        LifetimeStateInUse = 0x0,
        [NativeName("Name", "D3D12_LIFETIME_STATE_NOT_IN_USE")]
        LifetimeStateNotInUse = 0x1,
    }
}
