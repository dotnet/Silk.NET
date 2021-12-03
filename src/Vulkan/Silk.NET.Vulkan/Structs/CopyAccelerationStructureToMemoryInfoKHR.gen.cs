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
    [NativeName("Name", "VkCopyAccelerationStructureToMemoryInfoKHR")]
    public unsafe partial struct CopyAccelerationStructureToMemoryInfoKHR : IChainable
    {
        public CopyAccelerationStructureToMemoryInfoKHR
        (
            StructureType? sType = StructureType.CopyAccelerationStructureToMemoryInfoKhr,
            void* pNext = null,
            AccelerationStructureKHR? src = null,
            DeviceOrHostAddressKHR? dst = null,
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
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "src")]
        public AccelerationStructureKHR Src;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressKHR")]
        [NativeName("Name", "dst")]
        public DeviceOrHostAddressKHR Dst;
/// <summary></summary>
        [NativeName("Type", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Type.Name", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Name", "mode")]
        public CopyAccelerationStructureModeKHR Mode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyAccelerationStructureToMemoryInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
