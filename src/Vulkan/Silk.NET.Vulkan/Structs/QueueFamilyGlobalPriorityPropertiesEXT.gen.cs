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
    public unsafe partial struct QueueFamilyGlobalPriorityPropertiesEXT : IExtendsChain<QueueFamilyProperties2>, IExtendsChain<QueueFamilyProperties2KHR>
    {
        public QueueFamilyGlobalPriorityPropertiesEXT
        (
            StructureType? sType = StructureType.QueueFamilyGlobalPriorityPropertiesExt,
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
        [NativeName("Type", "VkQueueGlobalPriorityEXT")]
        [NativeName("Type.Name", "VkQueueGlobalPriorityEXT")]
        [NativeName("Name", "priorities")]
        public PrioritiesBuffer Priorities;

        public struct PrioritiesBuffer
        {
            public QueueGlobalPriorityEXT Element0;
            public QueueGlobalPriorityEXT Element1;
            public QueueGlobalPriorityEXT Element2;
            public QueueGlobalPriorityEXT Element3;
            public QueueGlobalPriorityEXT Element4;
            public QueueGlobalPriorityEXT Element5;
            public QueueGlobalPriorityEXT Element6;
            public QueueGlobalPriorityEXT Element7;
            public QueueGlobalPriorityEXT Element8;
            public QueueGlobalPriorityEXT Element9;
            public QueueGlobalPriorityEXT Element10;
            public QueueGlobalPriorityEXT Element11;
            public QueueGlobalPriorityEXT Element12;
            public QueueGlobalPriorityEXT Element13;
            public QueueGlobalPriorityEXT Element14;
            public QueueGlobalPriorityEXT Element15;
            public ref QueueGlobalPriorityEXT this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (QueueGlobalPriorityEXT* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<QueueGlobalPriorityEXT> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyGlobalPriorityPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
