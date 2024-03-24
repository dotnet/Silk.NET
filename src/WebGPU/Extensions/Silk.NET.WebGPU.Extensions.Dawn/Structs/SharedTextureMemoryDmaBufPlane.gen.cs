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
    [NativeName("Name", "WGPUSharedTextureMemoryDmaBufPlane")]
    public unsafe partial struct SharedTextureMemoryDmaBufPlane
    {
        public SharedTextureMemoryDmaBufPlane
        (
            int? fd = null,
            ulong? offset = null,
            uint? stride = null
        ) : this()
        {
            if (fd is not null)
            {
                Fd = fd.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "fd")]
        public int Fd;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
    }
}
