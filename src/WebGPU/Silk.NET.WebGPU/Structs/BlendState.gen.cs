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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBlendState")]
    public unsafe partial struct BlendState
    {
        public BlendState
        (
            BlendComponent? color = null,
            BlendComponent? alpha = null
        ) : this()
        {
            if (color is not null)
            {
                Color = color.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }
        }


        [NativeName("Type", "WGPUBlendComponent")]
        [NativeName("Type.Name", "WGPUBlendComponent")]
        [NativeName("Name", "color")]
        public BlendComponent Color;

        [NativeName("Type", "WGPUBlendComponent")]
        [NativeName("Type.Name", "WGPUBlendComponent")]
        [NativeName("Name", "alpha")]
        public BlendComponent Alpha;
    }
}
