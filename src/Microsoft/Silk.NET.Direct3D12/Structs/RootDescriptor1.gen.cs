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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR1")]
    public unsafe partial struct RootDescriptor1
    {
        public RootDescriptor1
        (
            uint? shaderRegister = null,
            uint? registerSpace = null,
            RootDescriptorFlags? flags = null
        ) : this()
        {
            if (shaderRegister is not null)
            {
                ShaderRegister = shaderRegister.Value;
            }

            if (registerSpace is not null)
            {
                RegisterSpace = registerSpace.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ShaderRegister")]
        public uint ShaderRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RegisterSpace")]
        public uint RegisterSpace;

        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
        [NativeName("Name", "Flags")]
        public RootDescriptorFlags Flags;
    }
}
