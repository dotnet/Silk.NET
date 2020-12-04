// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_VERSION")]
    public enum DredVersion
    {
        [NativeName("Name", "D3D12_DRED_VERSION_1_0")]
        DredVersion10 = 0x1,
        [NativeName("Name", "D3D12_DRED_VERSION_1_1")]
        DredVersion11 = 0x2,
        [NativeName("Name", "D3D12_DRED_VERSION_1_2")]
        DredVersion12 = 0x3,
    }
}
