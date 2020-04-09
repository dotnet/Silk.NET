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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DebugReportObjectTypeEXT ObjectType;
/// <summary></summary>
        public ulong Object;
/// <summary></summary>
        public ulong TagName;
/// <summary></summary>
        public UIntPtr TagSize;
/// <summary></summary>
        public void* PTag;
    }
}
