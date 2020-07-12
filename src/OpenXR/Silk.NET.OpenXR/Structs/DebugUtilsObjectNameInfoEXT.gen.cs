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

namespace Silk.NET.OpenXR
{
    public unsafe struct DebugUtilsObjectNameInfoEXT
    {
        public DebugUtilsObjectNameInfoEXT
        (
            StructureType type = StructureType.TypeDebugUtilsObjectNameInfoExt,
            void* next = default,
            ObjectType objectType = default,
            ulong objectHandle = default,
            byte* objectName = default
        )
        {
           Type = type;
           Next = next;
           ObjectType = objectType;
           ObjectHandle = objectHandle;
           ObjectName = objectName;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ObjectType ObjectType;
/// <summary></summary>
        public ulong ObjectHandle;
/// <summary></summary>
        public byte* ObjectName;
    }
}
