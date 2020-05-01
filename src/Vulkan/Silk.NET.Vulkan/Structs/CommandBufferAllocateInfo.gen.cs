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
    public unsafe struct CommandBufferAllocateInfo
    {
        public CommandBufferAllocateInfo
        (
            StructureType sType = StructureType.CommandBufferAllocateInfo,
            void* pNext = default,
            CommandPool commandPool = default,
            CommandBufferLevel level = default,
            uint commandBufferCount = default
        )
        {
           SType = sType;
           PNext = pNext;
           CommandPool = commandPool;
           Level = level;
           CommandBufferCount = commandBufferCount;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public CommandPool CommandPool;
/// <summary></summary>
        public CommandBufferLevel Level;
/// <summary></summary>
        public uint CommandBufferCount;
    }
}
