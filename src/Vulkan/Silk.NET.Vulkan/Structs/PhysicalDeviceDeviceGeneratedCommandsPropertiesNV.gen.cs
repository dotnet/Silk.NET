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
    [NativeName("Name", "VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV")]
    public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDeviceGeneratedCommandsPropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV,
            void* pNext = null,
            uint? maxGraphicsShaderGroupCount = null,
            uint? maxIndirectSequenceCount = null,
            uint? maxIndirectCommandsTokenCount = null,
            uint? maxIndirectCommandsStreamCount = null,
            uint? maxIndirectCommandsTokenOffset = null,
            uint? maxIndirectCommandsStreamStride = null,
            uint? minSequencesCountBufferOffsetAlignment = null,
            uint? minSequencesIndexBufferOffsetAlignment = null,
            uint? minIndirectCommandsBufferOffsetAlignment = null
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

            if (maxGraphicsShaderGroupCount is not null)
            {
                MaxGraphicsShaderGroupCount = maxGraphicsShaderGroupCount.Value;
            }

            if (maxIndirectSequenceCount is not null)
            {
                MaxIndirectSequenceCount = maxIndirectSequenceCount.Value;
            }

            if (maxIndirectCommandsTokenCount is not null)
            {
                MaxIndirectCommandsTokenCount = maxIndirectCommandsTokenCount.Value;
            }

            if (maxIndirectCommandsStreamCount is not null)
            {
                MaxIndirectCommandsStreamCount = maxIndirectCommandsStreamCount.Value;
            }

            if (maxIndirectCommandsTokenOffset is not null)
            {
                MaxIndirectCommandsTokenOffset = maxIndirectCommandsTokenOffset.Value;
            }

            if (maxIndirectCommandsStreamStride is not null)
            {
                MaxIndirectCommandsStreamStride = maxIndirectCommandsStreamStride.Value;
            }

            if (minSequencesCountBufferOffsetAlignment is not null)
            {
                MinSequencesCountBufferOffsetAlignment = minSequencesCountBufferOffsetAlignment.Value;
            }

            if (minSequencesIndexBufferOffsetAlignment is not null)
            {
                MinSequencesIndexBufferOffsetAlignment = minSequencesIndexBufferOffsetAlignment.Value;
            }

            if (minIndirectCommandsBufferOffsetAlignment is not null)
            {
                MinIndirectCommandsBufferOffsetAlignment = minIndirectCommandsBufferOffsetAlignment.Value;
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
        [NativeName("Name", "maxGraphicsShaderGroupCount")]
        public uint MaxGraphicsShaderGroupCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectSequenceCount")]
        public uint MaxIndirectSequenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsTokenCount")]
        public uint MaxIndirectCommandsTokenCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsStreamCount")]
        public uint MaxIndirectCommandsStreamCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsTokenOffset")]
        public uint MaxIndirectCommandsTokenOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIndirectCommandsStreamStride")]
        public uint MaxIndirectCommandsStreamStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minSequencesCountBufferOffsetAlignment")]
        public uint MinSequencesCountBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minSequencesIndexBufferOffsetAlignment")]
        public uint MinSequencesIndexBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minIndirectCommandsBufferOffsetAlignment")]
        public uint MinIndirectCommandsBufferOffsetAlignment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
