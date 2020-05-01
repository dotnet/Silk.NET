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
    public unsafe struct GeometryAABBNV
    {
        public GeometryAABBNV
        (
            StructureType sType = StructureType.GeometryAabbNV,
            void* pNext = default,
            Buffer aabbData = default,
            uint numAabbs = default,
            uint stride = default,
            ulong offset = default
        )
        {
           SType = sType;
           PNext = pNext;
           AabbData = aabbData;
           NumAabbs = numAabbs;
           Stride = stride;
           Offset = offset;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Buffer AabbData;
/// <summary></summary>
        public uint NumAabbs;
/// <summary></summary>
        public uint Stride;
/// <summary></summary>
        public ulong Offset;
    }
}
