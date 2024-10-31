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
    [NativeName("Name", "VkPhysicalDeviceExternalFormatResolvePropertiesANDROID")]
    public unsafe partial struct PhysicalDeviceExternalFormatResolvePropertiesANDROID : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceExternalFormatResolvePropertiesANDROID
        (
            StructureType? sType = StructureType.PhysicalDeviceExternalFormatResolvePropertiesAndroid,
            void* pNext = null,
            Bool32? nullColorAttachmentWithExternalFormatResolve = null,
            ChromaLocation? externalFormatResolveChromaOffsetX = null,
            ChromaLocation? externalFormatResolveChromaOffsetY = null
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

            if (nullColorAttachmentWithExternalFormatResolve is not null)
            {
                NullColorAttachmentWithExternalFormatResolve = nullColorAttachmentWithExternalFormatResolve.Value;
            }

            if (externalFormatResolveChromaOffsetX is not null)
            {
                ExternalFormatResolveChromaOffsetX = externalFormatResolveChromaOffsetX.Value;
            }

            if (externalFormatResolveChromaOffsetY is not null)
            {
                ExternalFormatResolveChromaOffsetY = externalFormatResolveChromaOffsetY.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nullColorAttachmentWithExternalFormatResolve")]
        public Bool32 NullColorAttachmentWithExternalFormatResolve;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "externalFormatResolveChromaOffsetX")]
        public ChromaLocation ExternalFormatResolveChromaOffsetX;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "externalFormatResolveChromaOffsetY")]
        public ChromaLocation ExternalFormatResolveChromaOffsetY;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExternalFormatResolvePropertiesAndroid;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
