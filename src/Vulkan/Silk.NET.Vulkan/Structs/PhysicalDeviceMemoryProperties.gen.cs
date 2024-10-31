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
    [NativeName("Name", "VkPhysicalDeviceMemoryProperties")]
    public unsafe partial struct PhysicalDeviceMemoryProperties
    {
        public PhysicalDeviceMemoryProperties
        (
            uint? memoryTypeCount = null,
            uint? memoryHeapCount = null
        ) : this()
        {
            if (memoryTypeCount is not null)
            {
                MemoryTypeCount = memoryTypeCount.Value;
            }

            if (memoryHeapCount is not null)
            {
                MemoryHeapCount = memoryHeapCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeCount")]
        public uint MemoryTypeCount;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryTypesBuffer MemoryTypes;

        public struct MemoryTypesBuffer
        {
            public MemoryType Element0;
            public MemoryType Element1;
            public MemoryType Element2;
            public MemoryType Element3;
            public MemoryType Element4;
            public MemoryType Element5;
            public MemoryType Element6;
            public MemoryType Element7;
            public MemoryType Element8;
            public MemoryType Element9;
            public MemoryType Element10;
            public MemoryType Element11;
            public MemoryType Element12;
            public MemoryType Element13;
            public MemoryType Element14;
            public MemoryType Element15;
            public MemoryType Element16;
            public MemoryType Element17;
            public MemoryType Element18;
            public MemoryType Element19;
            public MemoryType Element20;
            public MemoryType Element21;
            public MemoryType Element22;
            public MemoryType Element23;
            public MemoryType Element24;
            public MemoryType Element25;
            public MemoryType Element26;
            public MemoryType Element27;
            public MemoryType Element28;
            public MemoryType Element29;
            public MemoryType Element30;
            public MemoryType Element31;
            public ref MemoryType this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (MemoryType* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<MemoryType> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryHeapCount")]
        public uint MemoryHeapCount;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeapsBuffer MemoryHeaps;

        public struct MemoryHeapsBuffer
        {
            public MemoryHeap Element0;
            public MemoryHeap Element1;
            public MemoryHeap Element2;
            public MemoryHeap Element3;
            public MemoryHeap Element4;
            public MemoryHeap Element5;
            public MemoryHeap Element6;
            public MemoryHeap Element7;
            public MemoryHeap Element8;
            public MemoryHeap Element9;
            public MemoryHeap Element10;
            public MemoryHeap Element11;
            public MemoryHeap Element12;
            public MemoryHeap Element13;
            public MemoryHeap Element14;
            public MemoryHeap Element15;
            public ref MemoryHeap this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (MemoryHeap* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<MemoryHeap> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }

        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
