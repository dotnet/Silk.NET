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
    public unsafe struct DebugUtilsObjectTagInfoEXT
    {
        public DebugUtilsObjectTagInfoEXT
        (
            StructureType sType = StructureType.DebugUtilsObjectTagInfoExt,
            void* pNext = default,
            ObjectType objectType = default,
            ulong objectHandle = default,
            ulong tagName = default,
            UIntPtr tagSize = default,
            void* pTag = default
        )
        {
           SType = sType;
           PNext = pNext;
           ObjectType = objectType;
           ObjectHandle = objectHandle;
           TagName = tagName;
           TagSize = tagSize;
           PTag = pTag;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ObjectType ObjectType;
/// <summary></summary>
        public ulong ObjectHandle;
/// <summary></summary>
        public ulong TagName;
/// <summary></summary>
        public UIntPtr TagSize;
/// <summary></summary>
        public void* PTag;
    }
}
