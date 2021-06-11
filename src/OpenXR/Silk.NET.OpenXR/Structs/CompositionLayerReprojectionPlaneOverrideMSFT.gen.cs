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
    [NativeName("Name", "XrCompositionLayerReprojectionPlaneOverrideMSFT")]
    public unsafe partial struct CompositionLayerReprojectionPlaneOverrideMSFT
    {
        public CompositionLayerReprojectionPlaneOverrideMSFT
        (
            StructureType? type = StructureType.TypeCompositionLayerReprojectionPlaneOverrideMsft,
            void* next = null,
            Vector3f? position = null,
            Vector3f? normal = null,
            Vector3f? velocity = null
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

            if (position is not null)
            {
                Position = position.Value;
            }

            if (normal is not null)
            {
                Normal = normal.Value;
            }

            if (velocity is not null)
            {
                Velocity = velocity.Value;
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
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "position")]
        public Vector3f Position;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "normal")]
        public Vector3f Normal;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "velocity")]
        public Vector3f Velocity;
    }
}
