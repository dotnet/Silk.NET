// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "_D3D12_LIBRARY_DESC")]
    public unsafe partial struct LibraryDesc
    {
        public LibraryDesc
        (
            byte* creator = null,
            uint? flags = null,
            uint? functionCount = null
        ) : this()
        {
            if (creator is not null)
            {
                Creator = creator;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (functionCount is not null)
            {
                FunctionCount = functionCount.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Creator")]
        public byte* Creator;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FunctionCount")]
        public uint FunctionCount;
    }
}
