// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct D3D12FenceSubmitInfoKHR
    {
        public D3D12FenceSubmitInfoKHR
        (
            StructureType sType = StructureType.D3D12FenceSubmitInfoKhr,
            void* pNext = default,
            uint waitSemaphoreValuesCount = default,
            ulong* pWaitSemaphoreValues = default,
            uint signalSemaphoreValuesCount = default,
            ulong* pSignalSemaphoreValues = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreValuesCount = waitSemaphoreValuesCount;
           PWaitSemaphoreValues = pWaitSemaphoreValues;
           SignalSemaphoreValuesCount = signalSemaphoreValuesCount;
           PSignalSemaphoreValues = pSignalSemaphoreValues;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreValuesCount;
/// <summary></summary>
        public ulong* PWaitSemaphoreValues;
/// <summary></summary>
        public uint SignalSemaphoreValuesCount;
/// <summary></summary>
        public ulong* PSignalSemaphoreValues;
    }
}
