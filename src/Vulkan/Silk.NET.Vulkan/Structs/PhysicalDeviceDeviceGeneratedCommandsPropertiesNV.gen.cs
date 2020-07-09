// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV")]
    public unsafe struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public PhysicalDeviceDeviceGeneratedCommandsPropertiesNV
        (
            StructureType sType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV,
            void* pNext = default,
            uint maxGraphicsShaderGroupCount = default,
            uint maxIndirectSequenceCount = default,
            uint maxIndirectCommandsTokenCount = default,
            uint maxIndirectCommandsStreamCount = default,
            uint maxIndirectCommandsTokenOffset = default,
            uint maxIndirectCommandsStreamStride = default,
            uint minSequencesCountBufferOffsetAlignment = default,
            uint minSequencesIndexBufferOffsetAlignment = default,
            uint minIndirectCommandsBufferOffsetAlignment = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxGraphicsShaderGroupCount = maxGraphicsShaderGroupCount;
           MaxIndirectSequenceCount = maxIndirectSequenceCount;
           MaxIndirectCommandsTokenCount = maxIndirectCommandsTokenCount;
           MaxIndirectCommandsStreamCount = maxIndirectCommandsStreamCount;
           MaxIndirectCommandsTokenOffset = maxIndirectCommandsTokenOffset;
           MaxIndirectCommandsStreamStride = maxIndirectCommandsStreamStride;
           MinSequencesCountBufferOffsetAlignment = minSequencesCountBufferOffsetAlignment;
           MinSequencesIndexBufferOffsetAlignment = minSequencesIndexBufferOffsetAlignment;
           MinIndirectCommandsBufferOffsetAlignment = minIndirectCommandsBufferOffsetAlignment;
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
    }
}
