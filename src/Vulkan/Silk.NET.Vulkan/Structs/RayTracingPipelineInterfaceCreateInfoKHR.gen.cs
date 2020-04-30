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
    public unsafe struct RayTracingPipelineInterfaceCreateInfoKHR
    {
        public RayTracingPipelineInterfaceCreateInfoKHR
        (
            StructureType sType = StructureType.RayTracingPipelineInterfaceCreateInfoKhr,
            void* pNext = default,
            uint maxPayloadSize = default,
            uint maxAttributeSize = default,
            uint maxCallableSize = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxPayloadSize = maxPayloadSize;
           MaxAttributeSize = maxAttributeSize;
           MaxCallableSize = maxCallableSize;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxPayloadSize;
/// <summary></summary>
        public uint MaxAttributeSize;
/// <summary></summary>
        public uint MaxCallableSize;
    }
}
