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
    [NativeName("Name", "spvc_hlsl_root_constants")]
    public unsafe partial struct HlslRootConstants
    {
        public HlslRootConstants
        (
            uint? start = null,
            uint? end = null,
            uint? binding = null,
            uint? space = null
        ) : this()
        {
            if (start is not null)
            {
                Start = start.Value;
            }

            if (end is not null)
            {
                End = end.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "start")]
        public uint Start;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "end")]
        public uint End;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "binding")]
        public uint Binding;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "space")]
        public uint Space;
    }
}
