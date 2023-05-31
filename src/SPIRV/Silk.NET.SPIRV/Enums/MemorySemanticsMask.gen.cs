// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvMemorySemanticsMask_")]
    public enum MemorySemanticsMask : int
    {
        [NativeName("Name", "SpvMemorySemanticsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvMemorySemanticsAcquireMask")]
        AcquireMask = 0x2,
        [NativeName("Name", "SpvMemorySemanticsReleaseMask")]
        ReleaseMask = 0x4,
        [NativeName("Name", "SpvMemorySemanticsAcquireReleaseMask")]
        AcquireReleaseMask = 0x8,
        [NativeName("Name", "SpvMemorySemanticsSequentiallyConsistentMask")]
        SequentiallyConsistentMask = 0x10,
        [NativeName("Name", "SpvMemorySemanticsUniformMemoryMask")]
        UniformMemoryMask = 0x40,
        [NativeName("Name", "SpvMemorySemanticsSubgroupMemoryMask")]
        SubgroupMemoryMask = 0x80,
        [NativeName("Name", "SpvMemorySemanticsWorkgroupMemoryMask")]
        WorkgroupMemoryMask = 0x100,
        [NativeName("Name", "SpvMemorySemanticsCrossWorkgroupMemoryMask")]
        CrossWorkgroupMemoryMask = 0x200,
        [NativeName("Name", "SpvMemorySemanticsAtomicCounterMemoryMask")]
        AtomicCounterMemoryMask = 0x400,
        [NativeName("Name", "SpvMemorySemanticsImageMemoryMask")]
        ImageMemoryMask = 0x800,
        [NativeName("Name", "SpvMemorySemanticsOutputMemoryMask")]
        OutputMemoryMask = 0x1000,
        [NativeName("Name", "SpvMemorySemanticsOutputMemoryKHRMask")]
        OutputMemoryKhrMask = 0x1000,
        [NativeName("Name", "SpvMemorySemanticsMakeAvailableMask")]
        MakeAvailableMask = 0x2000,
        [NativeName("Name", "SpvMemorySemanticsMakeAvailableKHRMask")]
        MakeAvailableKhrMask = 0x2000,
        [NativeName("Name", "SpvMemorySemanticsMakeVisibleMask")]
        MakeVisibleMask = 0x4000,
        [NativeName("Name", "SpvMemorySemanticsMakeVisibleKHRMask")]
        MakeVisibleKhrMask = 0x4000,
        [NativeName("Name", "SpvMemorySemanticsVolatileMask")]
        VolatileMask = 0x8000,
    }
}
