// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_MACRO")]
    public unsafe partial struct D3DShaderMacro
    {
        public D3DShaderMacro
        (
            byte* name = null,
            byte* definition = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (definition is not null)
            {
                Definition = definition;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Definition")]
        public byte* Definition;
    }
}
