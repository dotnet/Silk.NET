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

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectDescriptorSet")]
    public unsafe partial struct ReflectDescriptorSet
    {
        public ReflectDescriptorSet
        (
            uint? set = null,
            uint? bindingCount = null,
            DescriptorBinding** bindings = null
        ) : this()
        {
            if (set is not null)
            {
                Set = set.Value;
            }

            if (bindingCount is not null)
            {
                BindingCount = bindingCount.Value;
            }

            if (bindings is not null)
            {
                Bindings = bindings;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "set")]
        public uint Set;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding_count")]
        public uint BindingCount;

        [NativeName("Type", "SpvReflectDescriptorBinding **")]
        [NativeName("Type.Name", "SpvReflectDescriptorBinding **")]
        [NativeName("Name", "bindings")]
        public DescriptorBinding** Bindings;
    }
}
