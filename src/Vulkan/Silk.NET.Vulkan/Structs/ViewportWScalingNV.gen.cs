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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkViewportWScalingNV")]
    public unsafe partial struct ViewportWScalingNV
    {
        public ViewportWScalingNV
        (
            float? xcoeff = null,
            float? ycoeff = null
        ) : this()
        {
            if (xcoeff is not null)
            {
                Xcoeff = xcoeff.Value;
            }

            if (ycoeff is not null)
            {
                Ycoeff = ycoeff.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "xcoeff")]
        public float Xcoeff;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ycoeff")]
        public float Ycoeff;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
