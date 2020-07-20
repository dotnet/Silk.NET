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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrDebugUtilsObjectNameInfoEXT")]
    public unsafe partial struct DebugUtilsObjectNameInfoEXT
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrObjectType")]
        [NativeName("Type.Name", "XrObjectType")]
        [NativeName("Name", "objectType")]
        public ObjectType ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "objectHandle")]
        public ulong ObjectHandle;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "objectName")]
        public byte* ObjectName;
    }
}
