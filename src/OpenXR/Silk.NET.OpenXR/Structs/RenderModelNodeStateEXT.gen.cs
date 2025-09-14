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
    [NativeName("Name", "XrRenderModelNodeStateEXT")]
    public unsafe partial struct RenderModelNodeStateEXT
    {
        public RenderModelNodeStateEXT
        (
            Posef? nodePose = null,
            uint? isVisible = null
        ) : this()
        {
            if (nodePose is not null)
            {
                NodePose = nodePose.Value;
            }

            if (isVisible is not null)
            {
                IsVisible = isVisible.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "nodePose")]
        public Posef NodePose;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isVisible")]
        public uint IsVisible;
    }
}
