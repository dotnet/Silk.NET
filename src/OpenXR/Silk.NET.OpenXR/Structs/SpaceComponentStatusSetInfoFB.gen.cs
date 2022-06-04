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
    [NativeName("Name", "XrSpaceComponentStatusSetInfoFB")]
    public unsafe partial struct SpaceComponentStatusSetInfoFB
    {
        public SpaceComponentStatusSetInfoFB
        (
            StructureType? type = StructureType.TypeSpaceComponentStatusSetInfoFB,
            void* next = null,
            SpaceComponentTypeFB? componentType = null,
            uint? enabled = null,
            long? timeout = null
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

            if (componentType is not null)
            {
                ComponentType = componentType.Value;
            }

            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }

            if (timeout is not null)
            {
                Timeout = timeout.Value;
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
        [NativeName("Type", "XrSpaceComponentTypeFB")]
        [NativeName("Type.Name", "XrSpaceComponentTypeFB")]
        [NativeName("Name", "componentType")]
        public SpaceComponentTypeFB ComponentType;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "enabled")]
        public uint Enabled;
/// <summary></summary>
        [NativeName("Type", "XrDuration")]
        [NativeName("Type.Name", "XrDuration")]
        [NativeName("Name", "timeout")]
        public long Timeout;
    }
}
