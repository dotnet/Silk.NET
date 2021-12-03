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
    [NativeName("Name", "VkVideoDecodeH264CapabilitiesEXT")]
    public unsafe partial struct VideoDecodeH264CapabilitiesEXT : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoDecodeH264CapabilitiesEXT
        (
            StructureType? sType = StructureType.VideoDecodeH264CapabilitiesExt,
            void* pNext = null,
            uint? maxLevel = null,
            Offset2D? fieldOffsetGranularity = null,
            ExtensionProperties? stdExtensionVersion = null
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

            if (maxLevel is not null)
            {
                MaxLevel = maxLevel.Value;
            }

            if (fieldOffsetGranularity is not null)
            {
                FieldOffsetGranularity = fieldOffsetGranularity.Value;
            }

            if (stdExtensionVersion is not null)
            {
                StdExtensionVersion = stdExtensionVersion.Value;
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
        [NativeName("Name", "maxLevel")]
        public uint MaxLevel;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "fieldOffsetGranularity")]
        public Offset2D FieldOffsetGranularity;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "stdExtensionVersion")]
        public ExtensionProperties StdExtensionVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH264CapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
