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
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsInfoNV")]
    public unsafe partial struct AccelerationStructureMemoryRequirementsInfoNV : IChainable
    {
        public AccelerationStructureMemoryRequirementsInfoNV
        (
            StructureType? sType = StructureType.AccelerationStructureMemoryRequirementsInfoNV,
            void* pNext = null,
            AccelerationStructureMemoryRequirementsTypeNV? type = null,
            AccelerationStructureNV? accelerationStructure = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
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
        [NativeName("Type", "VkAccelerationStructureMemoryRequirementsTypeNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMemoryRequirementsTypeNV")]
        [NativeName("Name", "type")]
        public AccelerationStructureMemoryRequirementsTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureNV")]
        [NativeName("Type.Name", "VkAccelerationStructureNV")]
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureNV AccelerationStructure;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureMemoryRequirementsInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
