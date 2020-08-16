// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceVelocity")]
    public unsafe partial struct SpaceVelocity
    {
        public SpaceVelocity
        (
            StructureType type = StructureType.TypeSpaceVelocity,
            void* next = default,
            SpaceVelocityFlags velocityFlags = default,
            Vector3f linearVelocity = default,
            Vector3f angularVelocity = default
        )
        {
            Type = type;
            Next = next;
            VelocityFlags = velocityFlags;
            LinearVelocity = linearVelocity;
            AngularVelocity = angularVelocity;
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
        [NativeName("Type", "XrSpaceVelocityFlags")]
        [NativeName("Type.Name", "XrSpaceVelocityFlags")]
        [NativeName("Name", "velocityFlags")]
        public SpaceVelocityFlags VelocityFlags;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "linearVelocity")]
        public Vector3f LinearVelocity;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "angularVelocity")]
        public Vector3f AngularVelocity;
    }
}
