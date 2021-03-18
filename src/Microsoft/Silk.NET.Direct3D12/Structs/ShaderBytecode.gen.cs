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
    [NativeName("Name", "D3D12_SHADER_BYTECODE")]
    public unsafe partial struct ShaderBytecode
    {
        public ShaderBytecode
        (
            void* pShaderBytecode = null,
            nuint? bytecodeLength = null
        ) : this()
        {
            if (pShaderBytecode is not null)
            {
                PShaderBytecode = pShaderBytecode;
            }

            if (bytecodeLength is not null)
            {
                BytecodeLength = bytecodeLength.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pShaderBytecode")]
        public void* PShaderBytecode;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "BytecodeLength")]
        public nuint BytecodeLength;
    }
}
