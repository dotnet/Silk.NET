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
    public unsafe struct PhysicalDeviceToolPropertiesEXT
    {
        public PhysicalDeviceToolPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceToolPropertiesExt,
            void* pNext = default,
            ToolPurposeFlagsEXT purposes = default
        )
        {
           SType = sType;
           PNext = pNext;
           Purposes = purposes;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed byte Name[256];
        /// <summary></summary>
       public fixed byte Version[256];
/// <summary></summary>
        public ToolPurposeFlagsEXT Purposes;
        /// <summary></summary>
       public fixed byte Description[256];
        /// <summary></summary>
       public fixed byte Layer[256];
    }
}
