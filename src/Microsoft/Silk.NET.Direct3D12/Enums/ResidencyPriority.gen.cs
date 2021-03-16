// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESIDENCY_PRIORITY")]
    public enum ResidencyPriority : int
    {
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MINIMUM")]
        ResidencyPriorityMinimum = 0x28000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_LOW")]
        ResidencyPriorityLow = 0x50000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_NORMAL")]
        ResidencyPriorityNormal = 0x78000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_HIGH")]
        ResidencyPriorityHigh = unchecked((int) 0xFFFFFFFFA0010000),
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MAXIMUM")]
        ResidencyPriorityMaximum = unchecked((int) 0xFFFFFFFFC8000000),
    }
}
