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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUShaderDefine")]
    public unsafe partial struct ShaderDefine
    {
        public ShaderDefine
        (
            StringView? name = null,
            StringView? value = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "name")]
        public StringView Name;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "value")]
        public StringView Value;
    }
}
