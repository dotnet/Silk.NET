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
    [NativeName("Name", "VkAccelerationStructureCaptureDescriptorDataInfoEXT")]
    public unsafe partial struct AccelerationStructureCaptureDescriptorDataInfoEXT : IChainable
    {
        public AccelerationStructureCaptureDescriptorDataInfoEXT
        (
            StructureType? sType = StructureType.AccelerationStructureCaptureDescriptorDataInfoExt,
            void* pNext = null,
            AccelerationStructureKHR? accelerationStructure = null,
            AccelerationStructureNV? accelerationStructureNV = null
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

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }

            if (accelerationStructureNV is not null)
            {
                AccelerationStructureNV = accelerationStructureNV.Value;
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
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureKHR AccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureNV")]
        [NativeName("Type.Name", "VkAccelerationStructureNV")]
        [NativeName("Name", "accelerationStructureNV")]
        public AccelerationStructureNV AccelerationStructureNV;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureCaptureDescriptorDataInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
