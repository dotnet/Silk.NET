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

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "_D3D_SHADER_DATA")]
    public unsafe partial struct ShaderData
    {
        public ShaderData
        (
            void* pBytecode = null,
            nuint? bytecodeLength = null
        ) : this()
        {
            if (pBytecode is not null)
            {
                PBytecode = pBytecode;
            }

            if (bytecodeLength is not null)
            {
                BytecodeLength = bytecodeLength.Value;
            }
        }


        [NativeName("Type", "LPCVOID")]
        [NativeName("Type.Name", "LPCVOID")]
        [NativeName("Name", "pBytecode")]
        public void* PBytecode;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "BytecodeLength")]
        public nuint BytecodeLength;
    }
}
