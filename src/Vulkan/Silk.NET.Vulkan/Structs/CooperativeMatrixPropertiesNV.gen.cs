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
    [NativeName("Name", "VkCooperativeMatrixPropertiesNV")]
    public unsafe struct CooperativeMatrixPropertiesNV
    {
        public CooperativeMatrixPropertiesNV
        (
            StructureType sType = StructureType.CooperativeMatrixPropertiesNV,
            void* pNext = default,
            uint mSize = default,
            uint nSize = default,
            uint kSize = default,
            ComponentTypeNV aType = default,
            ComponentTypeNV bType = default,
            ComponentTypeNV cType = default,
            ComponentTypeNV dType = default,
            ScopeNV scope = default
        )
        {
           SType = sType;
           PNext = pNext;
           MSize = mSize;
           NSize = nSize;
           KSize = kSize;
           AType = aType;
           BType = bType;
           CType = cType;
           DType = dType;
           Scope = scope;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "MSize")]
        public uint MSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "NSize")]
        public uint NSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "KSize")]
        public uint KSize;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "AType")]
        public ComponentTypeNV AType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "BType")]
        public ComponentTypeNV BType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "CType")]
        public ComponentTypeNV CType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "DType")]
        public ComponentTypeNV DType;
/// <summary></summary>
        [NativeName("Type", "VkScopeNV")]
        [NativeName("Type.Name", "VkScopeNV")]
        [NativeName("Name", "scope")]
        public ScopeNV Scope;
    }
}
