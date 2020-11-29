// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_FLAGS")]
    public enum DredFlags
    {
        [NativeName("Name", "D3D12_DRED_FLAG_NONE")]
        DredFlagNone = 0x0,
        [NativeName("Name", "D3D12_DRED_FLAG_FORCE_ENABLE")]
        DredFlagForceEnable = 0x1,
        [NativeName("Name", "D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS")]
        DredFlagDisableAutobreadcrumbs = 0x2,
    }
}
