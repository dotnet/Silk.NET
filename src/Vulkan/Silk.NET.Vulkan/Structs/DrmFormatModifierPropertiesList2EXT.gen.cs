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
    [NativeName("Name", "VkDrmFormatModifierPropertiesList2EXT")]
    public unsafe partial struct DrmFormatModifierPropertiesList2EXT : IExtendsChain<FormatProperties2>, IExtendsChain<FormatProperties2KHR>
    {
        public DrmFormatModifierPropertiesList2EXT
        (
            StructureType? sType = StructureType.DrmFormatModifierPropertiesList2Ext,
            void* pNext = null,
            uint? drmFormatModifierCount = null,
            DrmFormatModifierProperties2EXT* pDrmFormatModifierProperties = null
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

            if (drmFormatModifierCount is not null)
            {
                DrmFormatModifierCount = drmFormatModifierCount.Value;
            }

            if (pDrmFormatModifierProperties is not null)
            {
                PDrmFormatModifierProperties = pDrmFormatModifierProperties;
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
        [NativeName("Name", "drmFormatModifierCount")]
        public uint DrmFormatModifierCount;
/// <summary></summary>
        [NativeName("Type", "VkDrmFormatModifierProperties2EXT*")]
        [NativeName("Type.Name", "VkDrmFormatModifierProperties2EXT")]
        [NativeName("Name", "pDrmFormatModifierProperties")]
        public DrmFormatModifierProperties2EXT* PDrmFormatModifierProperties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DrmFormatModifierPropertiesList2Ext;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
