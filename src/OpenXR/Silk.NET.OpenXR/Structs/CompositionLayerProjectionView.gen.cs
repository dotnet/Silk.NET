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
    [NativeName("Name", "XrCompositionLayerProjectionView")]
    public unsafe partial struct CompositionLayerProjectionView
    {
        public CompositionLayerProjectionView
        (
            StructureType? type = StructureType.TypeCompositionLayerProjectionView,
            void* next = null,
            Posef? pose = null,
            Fovf? fov = null,
            SwapchainSubImage? subImage = null
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

            if (pose is not null)
            {
                Pose = pose.Value;
            }

            if (fov is not null)
            {
                Fov = fov.Value;
            }

            if (subImage is not null)
            {
                SubImage = subImage.Value;
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
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "fov")]
        public Fovf Fov;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "subImage")]
        public SwapchainSubImage SubImage;
    }
}
