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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_vertex_attribute")]
    public unsafe partial struct MslVertexAttribute
    {
        public MslVertexAttribute
        (
            uint? location = null,
            uint? mslBuffer = null,
            uint? mslOffset = null,
            uint? mslStride = null,
            byte? perInstance = null,
            MslShaderVariableFormat? format = null,
            Silk.NET.SPIRV.BuiltIn? builtin = null
        ) : this()
        {
            if (location is not null)
            {
                Location = location.Value;
            }

            if (mslBuffer is not null)
            {
                MslBuffer = mslBuffer.Value;
            }

            if (mslOffset is not null)
            {
                MslOffset = mslOffset.Value;
            }

            if (mslStride is not null)
            {
                MslStride = mslStride.Value;
            }

            if (perInstance is not null)
            {
                PerInstance = perInstance.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (builtin is not null)
            {
                Builtin = builtin.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "location")]
        public uint Location;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_buffer")]
        public uint MslBuffer;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_offset")]
        public uint MslOffset;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_stride")]
        public uint MslStride;

        [NativeName("Type", "spvc_bool")]
        [NativeName("Type.Name", "spvc_bool")]
        [NativeName("Name", "per_instance")]
        public byte PerInstance;

        [NativeName("Type", "spvc_msl_vertex_format")]
        [NativeName("Type.Name", "spvc_msl_vertex_format")]
        [NativeName("Name", "format")]
        public MslShaderVariableFormat Format;

        [NativeName("Type", "SpvBuiltIn")]
        [NativeName("Type.Name", "SpvBuiltIn")]
        [NativeName("Name", "builtin")]
        public Silk.NET.SPIRV.BuiltIn Builtin;
    }
}
