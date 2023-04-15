// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvMemorySemanticsShift_")]
    public enum MemorySemanticsShift : int
    {
        [NativeName("Name", "SpvMemorySemanticsAcquireShift")]
        AcquireShift = 0x1,
        [NativeName("Name", "SpvMemorySemanticsReleaseShift")]
        ReleaseShift = 0x2,
        [NativeName("Name", "SpvMemorySemanticsAcquireReleaseShift")]
        AcquireReleaseShift = 0x3,
        [NativeName("Name", "SpvMemorySemanticsSequentiallyConsistentShift")]
        SequentiallyConsistentShift = 0x4,
        [NativeName("Name", "SpvMemorySemanticsUniformMemoryShift")]
        UniformMemoryShift = 0x6,
        [NativeName("Name", "SpvMemorySemanticsSubgroupMemoryShift")]
        SubgroupMemoryShift = 0x7,
        [NativeName("Name", "SpvMemorySemanticsWorkgroupMemoryShift")]
        WorkgroupMemoryShift = 0x8,
        [NativeName("Name", "SpvMemorySemanticsCrossWorkgroupMemoryShift")]
        CrossWorkgroupMemoryShift = 0x9,
        [NativeName("Name", "SpvMemorySemanticsAtomicCounterMemoryShift")]
        AtomicCounterMemoryShift = 0xA,
        [NativeName("Name", "SpvMemorySemanticsImageMemoryShift")]
        ImageMemoryShift = 0xB,
        [NativeName("Name", "SpvMemorySemanticsOutputMemoryShift")]
        OutputMemoryShift = 0xC,
        [NativeName("Name", "SpvMemorySemanticsOutputMemoryKHRShift")]
        OutputMemoryKhrShift = 0xC,
        [NativeName("Name", "SpvMemorySemanticsMakeAvailableShift")]
        MakeAvailableShift = 0xD,
        [NativeName("Name", "SpvMemorySemanticsMakeAvailableKHRShift")]
        MakeAvailableKhrShift = 0xD,
        [NativeName("Name", "SpvMemorySemanticsMakeVisibleShift")]
        MakeVisibleShift = 0xE,
        [NativeName("Name", "SpvMemorySemanticsMakeVisibleKHRShift")]
        MakeVisibleKhrShift = 0xE,
        [NativeName("Name", "SpvMemorySemanticsVolatileShift")]
        VolatileShift = 0xF,
        [NativeName("Name", "SpvMemorySemanticsMax")]
        Max = 0x7FFFFFFF,
    }
}
