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
    [NativeName("Name", "VkQueueFamilyGlobalPriorityPropertiesEXT")]
    [NativeName("AliasOf", "VkQueueFamilyGlobalPriorityProperties")]
    public unsafe partial struct QueueFamilyGlobalPriorityPropertiesEXT : IExtendsChain<QueueFamilyProperties2>, IExtendsChain<QueueFamilyProperties2KHR>
    {
        public QueueFamilyGlobalPriorityPropertiesEXT
        (
            StructureType? sType = StructureType.QueueFamilyGlobalPriorityProperties,
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
        [NativeName("Type", "VkQueueGlobalPriority")]
        [NativeName("Type.Name", "VkQueueGlobalPriority")]
        [NativeName("Name", "priorities")]
        public PrioritiesBuffer Priorities;

        public struct PrioritiesBuffer
        {
            public QueueGlobalPriority Element0;
            public QueueGlobalPriority Element1;
            public QueueGlobalPriority Element2;
            public QueueGlobalPriority Element3;
            public QueueGlobalPriority Element4;
            public QueueGlobalPriority Element5;
            public QueueGlobalPriority Element6;
            public QueueGlobalPriority Element7;
            public QueueGlobalPriority Element8;
            public QueueGlobalPriority Element9;
            public QueueGlobalPriority Element10;
            public QueueGlobalPriority Element11;
            public QueueGlobalPriority Element12;
            public QueueGlobalPriority Element13;
            public QueueGlobalPriority Element14;
            public QueueGlobalPriority Element15;
            public ref QueueGlobalPriority this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (QueueGlobalPriority* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<QueueGlobalPriority> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyGlobalPriorityProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
