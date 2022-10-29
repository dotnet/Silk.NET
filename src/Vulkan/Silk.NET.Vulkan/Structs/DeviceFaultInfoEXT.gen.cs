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
    [NativeName("Name", "VkDeviceFaultInfoEXT")]
    public unsafe partial struct DeviceFaultInfoEXT : IChainable
    {
        public DeviceFaultInfoEXT
        (
            StructureType? sType = StructureType.DeviceFaultInfoExt,
            void* pNext = null,
            DeviceFaultAddressInfoEXT* pAddressInfos = null,
            DeviceFaultVendorInfoEXT* pVendorInfos = null,
            void* pVendorBinaryData = null
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

            if (pAddressInfos is not null)
            {
                PAddressInfos = pAddressInfos;
            }

            if (pVendorInfos is not null)
            {
                PVendorInfos = pVendorInfos;
            }

            if (pVendorBinaryData is not null)
            {
                PVendorBinaryData = pVendorBinaryData;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
/// <summary></summary>
        [NativeName("Type", "VkDeviceFaultAddressInfoEXT*")]
        [NativeName("Type.Name", "VkDeviceFaultAddressInfoEXT")]
        [NativeName("Name", "pAddressInfos")]
        public DeviceFaultAddressInfoEXT* PAddressInfos;
/// <summary></summary>
        [NativeName("Type", "VkDeviceFaultVendorInfoEXT*")]
        [NativeName("Type.Name", "VkDeviceFaultVendorInfoEXT")]
        [NativeName("Name", "pVendorInfos")]
        public DeviceFaultVendorInfoEXT* PVendorInfos;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pVendorBinaryData")]
        public void* PVendorBinaryData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceFaultInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
