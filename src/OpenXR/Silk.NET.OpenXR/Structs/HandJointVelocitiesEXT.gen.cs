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
    public unsafe struct HandJointVelocitiesEXT
    {
        public HandJointVelocitiesEXT
        (
            StructureType type = StructureType.TypeHandJointVelocitiesExt,
            void* next = default,
            uint jointCount = default,
            HandJointVelocityEXT* jointVelocities = default
        )
        {
           Type = type;
           Next = next;
           JointCount = jointCount;
           JointVelocities = jointVelocities;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint JointCount;
/// <summary></summary>
        public HandJointVelocityEXT* JointVelocities;
    }
}
