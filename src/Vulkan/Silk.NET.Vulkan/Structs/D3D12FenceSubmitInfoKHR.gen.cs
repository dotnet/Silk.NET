// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkD3D12FenceSubmitInfoKHR")]
    public unsafe partial struct D3D12FenceSubmitInfoKHR
    {
        public D3D12FenceSubmitInfoKHR
        (
            StructureType? sType = StructureType.D3D12FenceSubmitInfoKhr,
            void* pNext = null,
            uint? waitSemaphoreValuesCount = null,
            ulong* pWaitSemaphoreValues = null,
            uint? signalSemaphoreValuesCount = null,
            ulong* pSignalSemaphoreValues = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (waitSemaphoreValuesCount is not null)
            {
                WaitSemaphoreValuesCount = waitSemaphoreValuesCount.Value;
            }

            if (pWaitSemaphoreValues is not null)
            {
                PWaitSemaphoreValues = pWaitSemaphoreValues;
            }

            if (signalSemaphoreValuesCount is not null)
            {
                SignalSemaphoreValuesCount = signalSemaphoreValuesCount.Value;
            }

            if (pSignalSemaphoreValues is not null)
            {
                PSignalSemaphoreValues = pSignalSemaphoreValues;
            }
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
        [NativeName("Name", "waitSemaphoreValuesCount")]
        public uint WaitSemaphoreValuesCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pWaitSemaphoreValues")]
        public ulong* PWaitSemaphoreValues;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreValuesCount")]
        public uint SignalSemaphoreValuesCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pSignalSemaphoreValues")]
        public ulong* PSignalSemaphoreValues;
    }
}
