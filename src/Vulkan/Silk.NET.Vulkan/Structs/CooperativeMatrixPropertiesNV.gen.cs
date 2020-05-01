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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MSize;
/// <summary></summary>
        public uint NSize;
/// <summary></summary>
        public uint KSize;
/// <summary></summary>
        public ComponentTypeNV AType;
/// <summary></summary>
        public ComponentTypeNV BType;
/// <summary></summary>
        public ComponentTypeNV CType;
/// <summary></summary>
        public ComponentTypeNV DType;
/// <summary></summary>
        public ScopeNV Scope;
    }
}
