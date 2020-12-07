// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDeviceToolPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceToolPropertiesEXT
    {
        public PhysicalDeviceToolPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceToolPropertiesExt,
            void* pNext = null,
            ToolPurposeFlagsEXT? purposes = null
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

            if (purposes is not null)
            {
                Purposes = purposes.Value;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "version")]
        public fixed byte Version[256];
/// <summary></summary>
        [NativeName("Type", "VkToolPurposeFlagsEXT")]
        [NativeName("Type.Name", "VkToolPurposeFlagsEXT")]
        [NativeName("Name", "purposes")]
        public ToolPurposeFlagsEXT Purposes;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "layer")]
        public fixed byte Layer[256];
    }
}
