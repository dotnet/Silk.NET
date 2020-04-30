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
    public unsafe struct DebugMarkerObjectNameInfoEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DebugReportObjectTypeEXT ObjectType;
/// <summary></summary>
        public ulong Object;
/// <summary></summary>
        public byte* PObjectName;
    }
}
