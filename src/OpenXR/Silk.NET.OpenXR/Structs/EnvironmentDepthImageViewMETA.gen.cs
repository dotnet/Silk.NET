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
    [NativeName("Name", "XrEnvironmentDepthImageViewMETA")]
    public unsafe partial struct EnvironmentDepthImageViewMETA
    {
        public EnvironmentDepthImageViewMETA
        (
            StructureType? type = StructureType.TypeEnvironmentDepthImageViewMeta,
            void* next = null,
            Fovf? fov = null,
            Posef? pose = null
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

            if (fov is not null)
            {
                Fov = fov.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
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
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "fov")]
        public Fovf Fov;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
    }
}
