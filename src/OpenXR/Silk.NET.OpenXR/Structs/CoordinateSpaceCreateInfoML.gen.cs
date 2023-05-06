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
    [NativeName("Name", "XrCoordinateSpaceCreateInfoML")]
    public unsafe partial struct CoordinateSpaceCreateInfoML
    {
        public CoordinateSpaceCreateInfoML
        (
            StructureType? type = StructureType.TypeCoordinateSpaceCreateInfoML,
            void* next = null,
            MLCoordinateFrameUID? cfuid = null,
            Posef? poseInCoordinateSpace = null
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

            if (cfuid is not null)
            {
                Cfuid = cfuid.Value;
            }

            if (poseInCoordinateSpace is not null)
            {
                PoseInCoordinateSpace = poseInCoordinateSpace.Value;
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
        [NativeName("Type", "MLCoordinateFrameUID")]
        [NativeName("Type.Name", "MLCoordinateFrameUID")]
        [NativeName("Name", "cfuid")]
        public MLCoordinateFrameUID Cfuid;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInCoordinateSpace")]
        public Posef PoseInCoordinateSpace;
    }
}
