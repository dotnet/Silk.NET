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
    public unsafe struct CommandBufferBeginInfo
    {
        public CommandBufferBeginInfo
        (
            StructureType sType = StructureType.CommandBufferBeginInfo,
            void* pNext = default,
            CommandBufferUsageFlags flags = default,
            CommandBufferInheritanceInfo* pInheritanceInfo = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PInheritanceInfo = pInheritanceInfo;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public CommandBufferUsageFlags Flags;
/// <summary></summary>
        public CommandBufferInheritanceInfo* PInheritanceInfo;
    }
}
