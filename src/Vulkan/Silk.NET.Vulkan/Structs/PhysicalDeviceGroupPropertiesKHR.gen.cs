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
    [NativeName("Name", "VkPhysicalDeviceGroupPropertiesKHR")]
    [NativeName("AliasOf", "VkPhysicalDeviceGroupProperties")]
    public unsafe partial struct PhysicalDeviceGroupPropertiesKHR : IChainable
    {
        public PhysicalDeviceGroupPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceGroupProperties,
            void* pNext = null,
            uint? physicalDeviceCount = null,
            Bool32? subsetAllocation = null
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

            if (physicalDeviceCount is not null)
            {
                PhysicalDeviceCount = physicalDeviceCount.Value;
            }

            if (subsetAllocation is not null)
            {
                SubsetAllocation = subsetAllocation.Value;
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
        [NativeName("Name", "physicalDeviceCount")]
        public uint PhysicalDeviceCount;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevicesBuffer PhysicalDevices;

        public struct PhysicalDevicesBuffer
        {
            public PhysicalDevice Element0;
            public PhysicalDevice Element1;
            public PhysicalDevice Element2;
            public PhysicalDevice Element3;
            public PhysicalDevice Element4;
            public PhysicalDevice Element5;
            public PhysicalDevice Element6;
            public PhysicalDevice Element7;
            public PhysicalDevice Element8;
            public PhysicalDevice Element9;
            public PhysicalDevice Element10;
            public PhysicalDevice Element11;
            public PhysicalDevice Element12;
            public PhysicalDevice Element13;
            public PhysicalDevice Element14;
            public PhysicalDevice Element15;
            public PhysicalDevice Element16;
            public PhysicalDevice Element17;
            public PhysicalDevice Element18;
            public PhysicalDevice Element19;
            public PhysicalDevice Element20;
            public PhysicalDevice Element21;
            public PhysicalDevice Element22;
            public PhysicalDevice Element23;
            public PhysicalDevice Element24;
            public PhysicalDevice Element25;
            public PhysicalDevice Element26;
            public PhysicalDevice Element27;
            public PhysicalDevice Element28;
            public PhysicalDevice Element29;
            public PhysicalDevice Element30;
            public PhysicalDevice Element31;
            public ref PhysicalDevice this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (PhysicalDevice* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<PhysicalDevice> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subsetAllocation")]
        public Bool32 SubsetAllocation;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceGroupProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
