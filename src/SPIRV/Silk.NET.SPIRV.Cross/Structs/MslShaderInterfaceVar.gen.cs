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
    [NativeName("Name", "spvc_msl_shader_interface_var")]
    public unsafe partial struct MslShaderInterfaceVar
    {
        public MslShaderInterfaceVar
        (
            uint? location = null,
            MslShaderVariableFormat? format = null,
            Silk.NET.SPIRV.BuiltIn? builtin = null,
            uint? vecsize = null
        ) : this()
        {
            if (location is not null)
            {
                Location = location.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (builtin is not null)
            {
                Builtin = builtin.Value;
            }

            if (vecsize is not null)
            {
                Vecsize = vecsize.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "location")]
        public uint Location;

        [NativeName("Type", "spvc_msl_vertex_format")]
        [NativeName("Type.Name", "spvc_msl_vertex_format")]
        [NativeName("Name", "format")]
        public MslShaderVariableFormat Format;

        [NativeName("Type", "SpvBuiltIn")]
        [NativeName("Type.Name", "SpvBuiltIn")]
        [NativeName("Name", "builtin")]
        public Silk.NET.SPIRV.BuiltIn Builtin;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "vecsize")]
        public uint Vecsize;
    }
}
