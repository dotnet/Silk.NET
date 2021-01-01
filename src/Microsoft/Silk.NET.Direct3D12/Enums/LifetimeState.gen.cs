// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_LIFETIME_STATE")]
    public enum LifetimeState : int
    {
        [NativeName("Name", "D3D12_LIFETIME_STATE_IN_USE")]
        LifetimeStateInUse = 0x0,
        [NativeName("Name", "D3D12_LIFETIME_STATE_NOT_IN_USE")]
        LifetimeStateNotInUse = 0x1,
    }
}
