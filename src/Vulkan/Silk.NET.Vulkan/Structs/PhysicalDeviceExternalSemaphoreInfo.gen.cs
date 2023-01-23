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
    [NativeName("Name", "VkPhysicalDeviceExternalSemaphoreInfo")]
    [NativeName("Aliases", "VkPhysicalDeviceExternalSemaphoreInfoKHR")]
    public unsafe partial struct PhysicalDeviceExternalSemaphoreInfo : IChainStart
    {
        public PhysicalDeviceExternalSemaphoreInfo
        (
            StructureType? sType = StructureType.PhysicalDeviceExternalSemaphoreInfo,
            void* pNext = null,
            ExternalSemaphoreHandleTypeFlags? handleType = null
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

            if (handleType is not null)
            {
                HandleType = handleType.Value;
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
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalSemaphoreHandleTypeFlags HandleType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExternalSemaphoreInfo;
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
        public static unsafe ref PhysicalDeviceExternalSemaphoreInfo Chain(
            out PhysicalDeviceExternalSemaphoreInfo capture)
        {
            capture = new PhysicalDeviceExternalSemaphoreInfo(StructureType.PhysicalDeviceExternalSemaphoreInfo);
            return ref capture;
        }
    }
}
