// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct TimelineSemaphoreSubmitInfo
    {
        public TimelineSemaphoreSubmitInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreValueCount;
/// <summary></summary>
        public ulong* PWaitSemaphoreValues;
/// <summary></summary>
        public uint SignalSemaphoreValueCount;
/// <summary></summary>
        public ulong* PSignalSemaphoreValues;
    }
}
