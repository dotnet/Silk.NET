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
    [NativeName("Name", "spvc_hlsl_vertex_attribute_remap")]
    public unsafe partial struct HlslVertexAttributeRemap
    {
        public HlslVertexAttributeRemap
        (
            uint? location = null,
            byte* semantic = null
        ) : this()
        {
            if (location is not null)
            {
                Location = location.Value;
            }

            if (semantic is not null)
            {
                Semantic = semantic;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "location")]
        public uint Location;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "semantic")]
        public byte* Semantic;
    }
}
