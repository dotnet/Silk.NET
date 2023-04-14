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

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "__AnonymousRecord_spirv_reflect_L412_C3")]
    public unsafe partial struct ReflectDescriptorBindingWordOffset
    {
        public ReflectDescriptorBindingWordOffset
        (
            uint? binding = null,
            uint? set = null
        ) : this()
        {
            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (set is not null)
            {
                Set = set.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "set")]
        public uint Set;
    }
}
