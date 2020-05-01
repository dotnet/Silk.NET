// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public PhysicalDeviceTexelBufferAlignmentPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceTexelBufferAlignmentPropertiesExt,
            void* pNext = default,
            ulong storageTexelBufferOffsetAlignmentBytes = default,
            Bool32 storageTexelBufferOffsetSingleTexelAlignment = default,
            ulong uniformTexelBufferOffsetAlignmentBytes = default,
            Bool32 uniformTexelBufferOffsetSingleTexelAlignment = default
        )
        {
           SType = sType;
           PNext = pNext;
           StorageTexelBufferOffsetAlignmentBytes = storageTexelBufferOffsetAlignmentBytes;
           StorageTexelBufferOffsetSingleTexelAlignment = storageTexelBufferOffsetSingleTexelAlignment;
           UniformTexelBufferOffsetAlignmentBytes = uniformTexelBufferOffsetAlignmentBytes;
           UniformTexelBufferOffsetSingleTexelAlignment = uniformTexelBufferOffsetSingleTexelAlignment;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong StorageTexelBufferOffsetAlignmentBytes;
/// <summary></summary>
        public Bool32 StorageTexelBufferOffsetSingleTexelAlignment;
/// <summary></summary>
        public ulong UniformTexelBufferOffsetAlignmentBytes;
/// <summary></summary>
        public Bool32 UniformTexelBufferOffsetSingleTexelAlignment;
    }
}
