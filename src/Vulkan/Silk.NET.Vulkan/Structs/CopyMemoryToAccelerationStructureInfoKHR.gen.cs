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
    [NativeName("Name", "VkCopyMemoryToAccelerationStructureInfoKHR")]
    public unsafe partial struct CopyMemoryToAccelerationStructureInfoKHR : IChainable
    {
        public CopyMemoryToAccelerationStructureInfoKHR
        (
            StructureType? sType = StructureType.CopyMemoryToAccelerationStructureInfoKhr,
            void* pNext = null,
            DeviceOrHostAddressConstKHR? src = null,
            AccelerationStructureKHR? dst = null,
            CopyAccelerationStructureModeKHR? mode = null
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

            if (src is not null)
            {
                Src = src.Value;
            }

            if (dst is not null)
            {
                Dst = dst.Value;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
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
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "src")]
        public DeviceOrHostAddressConstKHR Src;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "dst")]
        public AccelerationStructureKHR Dst;
/// <summary></summary>
        [NativeName("Type", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Type.Name", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Name", "mode")]
        public CopyAccelerationStructureModeKHR Mode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyMemoryToAccelerationStructureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
