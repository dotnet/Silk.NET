// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_RLDO_FLAGS")]
    public enum RldoFlags
    {
        [NativeName("Name", "D3D11_RLDO_SUMMARY")]
        RldoSummary = 0x1,
        [NativeName("Name", "D3D11_RLDO_DETAIL")]
        RldoDetail = 0x2,
        [NativeName("Name", "D3D11_RLDO_IGNORE_INTERNAL")]
        RldoIgnoreInternal = 0x4,
    }
}
