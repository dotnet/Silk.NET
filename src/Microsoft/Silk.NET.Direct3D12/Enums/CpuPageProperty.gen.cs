// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY")]
    public enum CpuPageProperty : int
    {
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_UNKNOWN")]
        CpuPagePropertyUnknown = 0x0,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE")]
        CpuPagePropertyNotAvailable = 0x1,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE")]
        CpuPagePropertyWriteCombine = 0x2,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_WRITE_BACK")]
        CpuPagePropertyWriteBack = 0x3,
    }
}
