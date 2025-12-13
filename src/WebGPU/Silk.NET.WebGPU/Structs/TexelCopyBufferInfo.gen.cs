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
    [NativeName("Name", "WGPUTexelCopyBufferInfo")]
    public unsafe partial struct TexelCopyBufferInfo
    {
        public TexelCopyBufferInfo
        (
            TexelCopyBufferLayout? layout = null,
            Buffer* buffer = null
        ) : this()
        {
            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }
        }


        [NativeName("Type", "WGPUTexelCopyBufferLayout")]
        [NativeName("Type.Name", "WGPUTexelCopyBufferLayout")]
        [NativeName("Name", "layout")]
        public TexelCopyBufferLayout Layout;

        [NativeName("Type", "WGPUBuffer")]
        [NativeName("Type.Name", "WGPUBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer* Buffer;
    }
}
