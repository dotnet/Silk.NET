// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDebugMarkerObjectNameInfoEXT")]
    public unsafe partial struct DebugMarkerObjectNameInfoEXT
    {
        public DebugMarkerObjectNameInfoEXT
        (
            StructureType sType = StructureType.DebugMarkerObjectNameInfoExt,
            void* pNext = default,
            DebugReportObjectTypeEXT objectType = default,
            ulong @object = default,
            byte* pObjectName = default
        )
        {
            SType = sType;
            PNext = pNext;
            ObjectType = objectType;
            Object = @object;
            PObjectName = pObjectName;
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
        [NativeName("Type", "VkDebugReportObjectTypeEXT")]
        [NativeName("Type.Name", "VkDebugReportObjectTypeEXT")]
        [NativeName("Name", "objectType")]
        public DebugReportObjectTypeEXT ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "object")]
        public ulong Object;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pObjectName")]
        public byte* PObjectName;
    }
}
