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
    [NativeName("Name", "SpvReflectArrayTraits")]
    public unsafe partial struct ArrayTraits
    {
        public ArrayTraits
        (
            uint? dimsCount = null,
            uint? stride = null
        ) : this()
        {
            if (dimsCount is not null)
            {
                DimsCount = dimsCount.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dims_count")]
        public uint DimsCount;
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "dims")]
        public fixed uint Dims[32];
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "spec_constant_op_ids")]
        public fixed uint SpecConstantOpIds[32];

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
    }
}
