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
    [NativeName("Name", "VkQueryPoolPerformanceCreateInfoKHR")]
    public unsafe partial struct QueryPoolPerformanceCreateInfoKHR : IExtendsChain<QueryPoolCreateInfo>
    {
        public QueryPoolPerformanceCreateInfoKHR
        (
            StructureType? sType = StructureType.QueryPoolPerformanceCreateInfoKhr,
            void* pNext = null,
            uint? queueFamilyIndex = null,
            uint? counterIndexCount = null,
            uint* pCounterIndices = null
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

            if (queueFamilyIndex is not null)
            {
                QueueFamilyIndex = queueFamilyIndex.Value;
            }

            if (counterIndexCount is not null)
            {
                CounterIndexCount = counterIndexCount.Value;
            }

            if (pCounterIndices is not null)
            {
                PCounterIndices = pCounterIndices;
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
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "counterIndexCount")]
        public uint CounterIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCounterIndices")]
        public uint* PCounterIndices;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueryPoolPerformanceCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
