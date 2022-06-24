// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESIDENCY_PRIORITY")]
    public enum ResidencyPriority : int
    {
        [Obsolete("Deprecated in favour of \"Minimum\"")]
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MINIMUM")]
        ResidencyPriorityMinimum = 0x28000000,
        [Obsolete("Deprecated in favour of \"Low\"")]
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_LOW")]
        ResidencyPriorityLow = 0x50000000,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_NORMAL")]
        ResidencyPriorityNormal = 0x78000000,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_HIGH")]
        ResidencyPriorityHigh = unchecked((int) 0xFFFFFFFFA0010000),
        [Obsolete("Deprecated in favour of \"Maximum\"")]
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MAXIMUM")]
        ResidencyPriorityMaximum = unchecked((int) 0xFFFFFFFFC8000000),
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MINIMUM")]
        Minimum = 0x28000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_LOW")]
        Low = 0x50000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_NORMAL")]
        Normal = 0x78000000,
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_HIGH")]
        High = unchecked((int) 0xFFFFFFFFA0010000),
        [NativeName("Name", "D3D12_RESIDENCY_PRIORITY_MAXIMUM")]
        Maximum = unchecked((int) 0xFFFFFFFFC8000000),
    }
}
