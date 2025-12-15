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
    [NativeName("Name", "WGPUVertexAttribute")]
    public unsafe partial struct VertexAttribute
    {
        public VertexAttribute
        (
            VertexFormat? format = null,
            ulong? offset = null,
            uint? shaderLocation = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (shaderLocation is not null)
            {
                ShaderLocation = shaderLocation.Value;
            }
        }


        [NativeName("Type", "WGPUVertexFormat")]
        [NativeName("Type.Name", "WGPUVertexFormat")]
        [NativeName("Name", "format")]
        public VertexFormat Format;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderLocation")]
        public uint ShaderLocation;
    }
}
