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
    [NativeName("Name", "spvc_hlsl_resource_binding_mapping")]
    public unsafe partial struct HlslResourceBindingMapping
    {
        public HlslResourceBindingMapping
        (
            uint? registerSpace = null,
            uint? registerBinding = null
        ) : this()
        {
            if (registerSpace is not null)
            {
                RegisterSpace = registerSpace.Value;
            }

            if (registerBinding is not null)
            {
                RegisterBinding = registerBinding.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "register_space")]
        public uint RegisterSpace;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "register_binding")]
        public uint RegisterBinding;
    }
}
