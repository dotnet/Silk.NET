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
    [NativeName("Name", "SpvReflectBindingArrayTraits")]
    public unsafe partial struct BindingArrayTraits
    {
        public BindingArrayTraits
        (
            uint? dimsCount = null
        ) : this()
        {
            if (dimsCount is not null)
            {
                DimsCount = dimsCount.Value;
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
    }
}
