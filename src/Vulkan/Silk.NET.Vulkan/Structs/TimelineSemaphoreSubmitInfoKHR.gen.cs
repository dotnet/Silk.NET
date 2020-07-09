// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkTimelineSemaphoreSubmitInfoKHR")]
    public unsafe struct TimelineSemaphoreSubmitInfoKHR
    {
        public TimelineSemaphoreSubmitInfoKHR
        (
            StructureType sType = StructureType.TimelineSemaphoreSubmitInfo,
            void* pNext = default,
            uint waitSemaphoreValueCount = default,
            ulong* pWaitSemaphoreValues = default,
            uint signalSemaphoreValueCount = default,
            ulong* pSignalSemaphoreValues = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreValueCount = waitSemaphoreValueCount;
           PWaitSemaphoreValues = pWaitSemaphoreValues;
           SignalSemaphoreValueCount = signalSemaphoreValueCount;
           PSignalSemaphoreValues = pSignalSemaphoreValues;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "waitSemaphoreValueCount")]
        public uint WaitSemaphoreValueCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pWaitSemaphoreValues")]
        public ulong* PWaitSemaphoreValues;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreValueCount")]
        public uint SignalSemaphoreValueCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pSignalSemaphoreValues")]
        public ulong* PSignalSemaphoreValues;
    }
}
