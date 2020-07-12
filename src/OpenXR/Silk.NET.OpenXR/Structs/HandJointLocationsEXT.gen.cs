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
    [NativeName("Name", "XrHandJointLocationsEXT")]
    public unsafe partial struct HandJointLocationsEXT
    {
        public HandJointLocationsEXT
        (
            StructureType type = StructureType.TypeHandJointLocationsExt,
            void* next = default,
            uint isActive = default,
            uint jointCount = default,
            HandJointLocationEXT* jointLocations = default
        )
        {
            Type = type;
            Next = next;
            IsActive = isActive;
            JointCount = jointCount;
            JointLocations = jointLocations;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCount")]
        public uint JointCount;
/// <summary></summary>
        [NativeName("Type", "XrHandJointLocationEXT*")]
        [NativeName("Type.Name", "XrHandJointLocationEXT")]
        [NativeName("Name", "jointLocations")]
        public HandJointLocationEXT* JointLocations;
    }
}
