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
    [NativeName("Name", "XrInstanceCreateInfoAndroidKHR")]
    public unsafe partial struct InstanceCreateInfoAndroidKHR
    {
        public InstanceCreateInfoAndroidKHR
        (
            StructureType type = StructureType.TypeInstanceCreateInfoAndroidKhr,
            void* next = default,
            void* applicationVM = default,
            void* applicationActivity = default
        )
        {
            Type = type;
            Next = next;
            ApplicationVM = applicationVM;
            ApplicationActivity = applicationActivity;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationVM")]
        public void* ApplicationVM;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationActivity")]
        public void* ApplicationActivity;
    }
}
