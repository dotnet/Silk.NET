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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUExtent2D")]
    public unsafe partial struct Extent2D
    {
        public Extent2D
        (
            uint? width = null,
            uint? height = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;
    }
}
