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
    [NativeName("Name", "VkPhysicalDeviceExternalTensorInfoARM")]
    public unsafe partial struct PhysicalDeviceExternalTensorInfoARM : IChainable
    {
        public PhysicalDeviceExternalTensorInfoARM
        (
            StructureType? sType = StructureType.PhysicalDeviceExternalTensorInfoArm,
            void* pNext = null,
            TensorCreateFlagsARM? flags = null,
            TensorDescriptionARM* pDescription = null,
            ExternalMemoryHandleTypeFlags? handleType = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pDescription is not null)
            {
                PDescription = pDescription;
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
        [NativeName("Type", "VkTensorCreateFlagsARM")]
        [NativeName("Type.Name", "VkTensorCreateFlagsARM")]
        [NativeName("Name", "flags")]
        public TensorCreateFlagsARM Flags;
/// <summary></summary>
        [NativeName("Type", "VkTensorDescriptionARM*")]
        [NativeName("Type.Name", "VkTensorDescriptionARM")]
        [NativeName("Name", "pDescription")]
        public TensorDescriptionARM* PDescription;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalMemoryHandleTypeFlags HandleType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExternalTensorInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
