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
    [NativeName("Name", "WGPUBlendComponent")]
    public unsafe partial struct BlendComponent
    {
        public BlendComponent
        (
            BlendOperation? operation = null,
            BlendFactor? srcFactor = null,
            BlendFactor? dstFactor = null
        ) : this()
        {
            if (operation is not null)
            {
                Operation = operation.Value;
            }

            if (srcFactor is not null)
            {
                SrcFactor = srcFactor.Value;
            }

            if (dstFactor is not null)
            {
                DstFactor = dstFactor.Value;
            }
        }


        [NativeName("Type", "WGPUBlendOperation")]
        [NativeName("Type.Name", "WGPUBlendOperation")]
        [NativeName("Name", "operation")]
        public BlendOperation Operation;

        [NativeName("Type", "WGPUBlendFactor")]
        [NativeName("Type.Name", "WGPUBlendFactor")]
        [NativeName("Name", "srcFactor")]
        public BlendFactor SrcFactor;

        [NativeName("Type", "WGPUBlendFactor")]
        [NativeName("Type.Name", "WGPUBlendFactor")]
        [NativeName("Name", "dstFactor")]
        public BlendFactor DstFactor;
    }
}
