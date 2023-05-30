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
    [NativeName("Name", "spvc_specialization_constant")]
    public unsafe partial struct SpecializationConstant
    {
        public SpecializationConstant
        (
            uint? id = null,
            uint? constantId = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (constantId is not null)
            {
                ConstantId = constantId.Value;
            }
        }


        [NativeName("Type", "spvc_constant_id")]
        [NativeName("Type.Name", "spvc_constant_id")]
        [NativeName("Name", "id")]
        public uint Id;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "constant_id")]
        public uint ConstantId;
    }
}
