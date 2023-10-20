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
    [NativeName("Name", "XrVirtualKeyboardSpaceCreateInfoMETA")]
    public unsafe partial struct VirtualKeyboardSpaceCreateInfoMETA
    {
        public VirtualKeyboardSpaceCreateInfoMETA
        (
            StructureType? type = StructureType.TypeVirtualKeyboardSpaceCreateInfoMeta,
            void* next = null,
            VirtualKeyboardLocationTypeMETA? locationType = null,
            Space? space = null,
            Posef? poseInSpace = null
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

            if (locationType is not null)
            {
                LocationType = locationType.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (poseInSpace is not null)
            {
                PoseInSpace = poseInSpace.Value;
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
        [NativeName("Type", "XrVirtualKeyboardLocationTypeMETA")]
        [NativeName("Type.Name", "XrVirtualKeyboardLocationTypeMETA")]
        [NativeName("Name", "locationType")]
        public VirtualKeyboardLocationTypeMETA LocationType;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInSpace")]
        public Posef PoseInSpace;
    }
}
