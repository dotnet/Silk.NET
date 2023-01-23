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
    [NativeName("Name", "VkDeviceFaultCountsEXT")]
    public unsafe partial struct DeviceFaultCountsEXT : IChainable
    {
        public DeviceFaultCountsEXT
        (
            StructureType? sType = StructureType.DeviceFaultCountsExt,
            void* pNext = null,
            uint? addressInfoCount = null,
            uint? vendorInfoCount = null,
            ulong? vendorBinarySize = null
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

            if (addressInfoCount is not null)
            {
                AddressInfoCount = addressInfoCount.Value;
            }

            if (vendorInfoCount is not null)
            {
                VendorInfoCount = vendorInfoCount.Value;
            }

            if (vendorBinarySize is not null)
            {
                VendorBinarySize = vendorBinarySize.Value;
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
        [NativeName("Name", "addressInfoCount")]
        public uint AddressInfoCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vendorInfoCount")]
        public uint VendorInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "vendorBinarySize")]
        public ulong VendorBinarySize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceFaultCountsExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
