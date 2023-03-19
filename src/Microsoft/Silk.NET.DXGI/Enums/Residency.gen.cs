// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_RESIDENCY")]
    public enum Residency : int
    {
        [Obsolete("Deprecated in favour of \"FullyResident\"")]
        [NativeName("Name", "DXGI_RESIDENCY_FULLY_RESIDENT")]
        ResidencyFullyResident = 0x1,
        [Obsolete("Deprecated in favour of \"ResidentInSharedMemory\"")]
        [NativeName("Name", "DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY")]
        ResidencyResidentInSharedMemory = 0x2,
        [Obsolete("Deprecated in favour of \"EvictedToDisk\"")]
        [NativeName("Name", "DXGI_RESIDENCY_EVICTED_TO_DISK")]
        ResidencyEvictedToDisk = 0x3,
        [NativeName("Name", "DXGI_RESIDENCY_FULLY_RESIDENT")]
        FullyResident = 0x1,
        [NativeName("Name", "DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY")]
        ResidentInSharedMemory = 0x2,
        [NativeName("Name", "DXGI_RESIDENCY_EVICTED_TO_DISK")]
        EvictedToDisk = 0x3,
    }
}
