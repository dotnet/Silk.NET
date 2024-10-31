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
    [NativeName("Name", "VkPhysicalDeviceLayeredDriverPropertiesMSFT")]
    public unsafe partial struct PhysicalDeviceLayeredDriverPropertiesMSFT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceLayeredDriverPropertiesMSFT
        (
            StructureType? sType = StructureType.PhysicalDeviceLayeredDriverPropertiesMsft,
            void* pNext = null,
            LayeredDriverUnderlyingApiMSFT? underlyingApi = null
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

            if (underlyingApi is not null)
            {
                UnderlyingApi = underlyingApi.Value;
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
        [NativeName("Type", "VkLayeredDriverUnderlyingApiMSFT")]
        [NativeName("Type.Name", "VkLayeredDriverUnderlyingApiMSFT")]
        [NativeName("Name", "underlyingAPI")]
        public LayeredDriverUnderlyingApiMSFT UnderlyingApi;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceLayeredDriverPropertiesMsft;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
