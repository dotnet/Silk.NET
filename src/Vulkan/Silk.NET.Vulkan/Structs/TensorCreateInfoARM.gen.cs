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
    [NativeName("Name", "VkTensorCreateInfoARM")]
    public unsafe partial struct TensorCreateInfoARM : IChainStart
    {
        public TensorCreateInfoARM
        (
            StructureType? sType = StructureType.TensorCreateInfoArm,
            void* pNext = null,
            TensorCreateFlagsARM? flags = null,
            TensorDescriptionARM* pDescription = null,
            SharingMode? sharingMode = null,
            uint? queueFamilyIndexCount = null,
            uint* pQueueFamilyIndices = null
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

            if (sharingMode is not null)
            {
                SharingMode = sharingMode.Value;
            }

            if (queueFamilyIndexCount is not null)
            {
                QueueFamilyIndexCount = queueFamilyIndexCount.Value;
            }

            if (pQueueFamilyIndices is not null)
            {
                PQueueFamilyIndices = pQueueFamilyIndices;
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
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "sharingMode")]
        public SharingMode SharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TensorCreateInfoArm;
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
        public static unsafe ref TensorCreateInfoARM Chain(
            out TensorCreateInfoARM capture)
        {
            capture = new TensorCreateInfoARM(StructureType.TensorCreateInfoArm);
            return ref capture;
        }
    }
}
