// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            void* pBytecode = default,
            uint bytecodeLength = default
        )
        {
            PBytecode = pBytecode;
            BytecodeLength = bytecodeLength;
        }


        [NativeName("Type", "LPCVOID")]
        [NativeName("Type.Name", "LPCVOID")]
        [NativeName("Name", "pBytecode")]
        public void* PBytecode;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "BytecodeLength")]
        public uint BytecodeLength;
    }
}
