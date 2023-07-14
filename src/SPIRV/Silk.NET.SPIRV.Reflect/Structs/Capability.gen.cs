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
    [NativeName("Name", "SpvReflectCapability")]
    public unsafe partial struct Capability
    {
        public Capability
        (
            Silk.NET.SPIRV.Capability? value = null,
            uint? wordOffset = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }

            if (wordOffset is not null)
            {
                WordOffset = wordOffset.Value;
            }
        }


        [NativeName("Type", "SpvCapability")]
        [NativeName("Type.Name", "SpvCapability")]
        [NativeName("Name", "value")]
        public Silk.NET.SPIRV.Capability Value;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "word_offset")]
        public uint WordOffset;
    }
}
