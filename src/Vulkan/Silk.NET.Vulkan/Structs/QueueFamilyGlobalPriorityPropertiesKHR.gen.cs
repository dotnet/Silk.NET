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
    [NativeName("Name", "VkQueueFamilyGlobalPriorityPropertiesKHR")]
    [NativeName("Aliases", "VkQueueFamilyGlobalPriorityPropertiesEXT")]
    public unsafe partial struct QueueFamilyGlobalPriorityPropertiesKHR : IExtendsChain<QueueFamilyProperties2>, IExtendsChain<QueueFamilyProperties2KHR>
    {
        public QueueFamilyGlobalPriorityPropertiesKHR
        (
            StructureType? sType = StructureType.QueueFamilyGlobalPriorityPropertiesKhr,
            void* pNext = null,
            uint? priorityCount = null
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

            if (priorityCount is not null)
            {
                PriorityCount = priorityCount.Value;
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
        [NativeName("Name", "priorityCount")]
        public uint PriorityCount;
        /// <summary></summary>
        [NativeName("Type", "VkQueueGlobalPriorityKHR")]
        [NativeName("Type.Name", "VkQueueGlobalPriorityKHR")]
        [NativeName("Name", "priorities")]
        public PrioritiesBuffer Priorities;

        public struct PrioritiesBuffer
        {
            public QueueGlobalPriorityKHR Element0;
            public QueueGlobalPriorityKHR Element1;
            public QueueGlobalPriorityKHR Element2;
            public QueueGlobalPriorityKHR Element3;
            public QueueGlobalPriorityKHR Element4;
            public QueueGlobalPriorityKHR Element5;
            public QueueGlobalPriorityKHR Element6;
            public QueueGlobalPriorityKHR Element7;
            public QueueGlobalPriorityKHR Element8;
            public QueueGlobalPriorityKHR Element9;
            public QueueGlobalPriorityKHR Element10;
            public QueueGlobalPriorityKHR Element11;
            public QueueGlobalPriorityKHR Element12;
            public QueueGlobalPriorityKHR Element13;
            public QueueGlobalPriorityKHR Element14;
            public QueueGlobalPriorityKHR Element15;
            public ref QueueGlobalPriorityKHR this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (QueueGlobalPriorityKHR* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<QueueGlobalPriorityKHR> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }

        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyGlobalPriorityPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
