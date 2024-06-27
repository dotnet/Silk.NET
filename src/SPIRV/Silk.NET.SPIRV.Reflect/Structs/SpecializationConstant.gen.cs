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
    [NativeName("Name", "SpvReflectSpecializationConstant")]
    public unsafe partial struct SpecializationConstant
    {
        public SpecializationConstant
        (
            uint? spirvId = null,
            uint? constantId = null,
            byte* name = null
        ) : this()
        {
            if (spirvId is not null)
            {
                SpirvId = spirvId.Value;
            }

            if (constantId is not null)
            {
                ConstantId = constantId.Value;
            }

            if (name is not null)
            {
                Name = name;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "spirv_id")]
        public uint SpirvId;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constant_id")]
        public uint ConstantId;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;
    }
}
