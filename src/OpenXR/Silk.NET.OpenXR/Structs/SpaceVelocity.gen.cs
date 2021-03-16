// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            StructureType? type = StructureType.TypeSpaceVelocity,
            void* next = null,
            SpaceVelocityFlags? velocityFlags = null,
            Vector3f? linearVelocity = null,
            Vector3f? angularVelocity = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (velocityFlags is not null)
            {
                VelocityFlags = velocityFlags.Value;
            }

            if (linearVelocity is not null)
            {
                LinearVelocity = linearVelocity.Value;
            }

            if (angularVelocity is not null)
            {
                AngularVelocity = angularVelocity.Value;
            }
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
