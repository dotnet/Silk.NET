// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkTimelineSemaphoreSubmitInfo")]
    [NativeName("Aliases", "VkTimelineSemaphoreSubmitInfoKHR")]
    public unsafe partial struct TimelineSemaphoreSubmitInfo : IExtendsChain<SubmitInfo>, IExtendsChain<BindSparseInfo>
    {
        public TimelineSemaphoreSubmitInfo
        (
            StructureType? sType = StructureType.TimelineSemaphoreSubmitInfo,
            void* pNext = null,
            uint? waitSemaphoreValueCount = null,
            ulong* pWaitSemaphoreValues = null,
            uint? signalSemaphoreValueCount = null,
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

            if (waitSemaphoreValueCount is not null)
            {
                WaitSemaphoreValueCount = waitSemaphoreValueCount.Value;
            }

            if (pWaitSemaphoreValues is not null)
            {
                PWaitSemaphoreValues = pWaitSemaphoreValues;
            }

            if (signalSemaphoreValueCount is not null)
            {
                SignalSemaphoreValueCount = signalSemaphoreValueCount.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TimelineSemaphoreSubmitInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
