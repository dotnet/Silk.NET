// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAGS")]
    public enum ViewInstancingFlags
    {
        [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAG_NONE")]
        ViewInstancingFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING")]
        ViewInstancingFlagEnableViewInstanceMasking = 0x1,
    }
}
