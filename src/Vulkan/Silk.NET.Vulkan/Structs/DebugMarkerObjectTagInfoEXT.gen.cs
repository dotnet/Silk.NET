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
    [NativeName("Name", "VkDebugMarkerObjectTagInfoEXT")]
    public unsafe struct DebugMarkerObjectTagInfoEXT
    {
        public DebugMarkerObjectTagInfoEXT
        (
            StructureType sType = StructureType.DebugMarkerObjectTagInfoExt,
            void* pNext = default,
            DebugReportObjectTypeEXT objectType = default,
            ulong @object = default,
            ulong tagName = default,
            UIntPtr tagSize = default,
            void* pTag = default
        )
        {
           SType = sType;
           PNext = pNext;
           ObjectType = objectType;
           Object = @object;
           TagName = tagName;
           TagSize = tagSize;
           PTag = pTag;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "tagName")]
        public ulong TagName;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "tagSize")]
        public UIntPtr TagSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pTag")]
        public void* PTag;
    }
}
