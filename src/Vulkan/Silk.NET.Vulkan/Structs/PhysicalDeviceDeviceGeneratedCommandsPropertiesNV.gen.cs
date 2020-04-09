// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxGraphicsShaderGroupCount;
/// <summary></summary>
        public uint MaxIndirectSequenceCount;
/// <summary></summary>
        public uint MaxIndirectCommandsTokenCount;
/// <summary></summary>
        public uint MaxIndirectCommandsStreamCount;
/// <summary></summary>
        public uint MaxIndirectCommandsTokenOffset;
/// <summary></summary>
        public uint MaxIndirectCommandsStreamStride;
/// <summary></summary>
        public uint MinSequencesCountBufferOffsetAlignment;
/// <summary></summary>
        public uint MinSequencesIndexBufferOffsetAlignment;
/// <summary></summary>
        public uint MinIndirectCommandsBufferOffsetAlignment;
    }
}
