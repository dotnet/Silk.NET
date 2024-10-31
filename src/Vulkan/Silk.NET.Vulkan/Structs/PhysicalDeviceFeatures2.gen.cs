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
    [NativeName("Name", "VkPhysicalDeviceFeatures2")]
    [NativeName("Aliases", "VkPhysicalDeviceFeatures2KHR")]
    public unsafe partial struct PhysicalDeviceFeatures2 : IChainStart, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceFeatures2
        (
            StructureType? sType = StructureType.PhysicalDeviceFeatures2,
            void* pNext = null,
            PhysicalDeviceFeatures? features = null
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

            if (features is not null)
            {
                Features = features.Value;
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
        [NativeName("Type", "VkPhysicalDeviceFeatures")]
        [NativeName("Type.Name", "VkPhysicalDeviceFeatures")]
        [NativeName("Name", "features")]
        public PhysicalDeviceFeatures Features;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFeatures2;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref PhysicalDeviceFeatures2 Chain(
            out PhysicalDeviceFeatures2 capture)
        {
            capture = new PhysicalDeviceFeatures2(StructureType.PhysicalDeviceFeatures2);
            return ref capture;
        }
    }
}
