// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESIDENCY_FLAGS")]
    public enum ResidencyFlags
    {
        [NativeName("Name", "D3D12_RESIDENCY_FLAG_NONE")]
        ResidencyFlagNone = 0x0,
        [NativeName("Name", "D3D12_RESIDENCY_FLAG_DENY_OVERBUDGET")]
        ResidencyFlagDenyOverbudget = 0x1,
    }
}
