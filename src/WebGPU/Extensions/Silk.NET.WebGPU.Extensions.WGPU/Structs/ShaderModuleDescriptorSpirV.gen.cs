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
    [NativeName("Name", "WGPUShaderModuleDescriptorSpirV")]
    public unsafe partial struct ShaderModuleDescriptorSpirV
    {
        public ShaderModuleDescriptorSpirV
        (
            StringView? label = null,
            uint? sourceSize = null,
            uint* source = null
        ) : this()
        {
            if (label is not null)
            {
                Label = label.Value;
            }

            if (sourceSize is not null)
            {
                SourceSize = sourceSize.Value;
            }

            if (source is not null)
            {
                Source = source;
            }
        }


        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "label")]
        public StringView Label;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sourceSize")]
        public uint SourceSize;

        [NativeName("Type", "const uint32_t *")]
        [NativeName("Type.Name", "const uint32_t *")]
        [NativeName("Name", "source")]
        public uint* Source;
    }
}
