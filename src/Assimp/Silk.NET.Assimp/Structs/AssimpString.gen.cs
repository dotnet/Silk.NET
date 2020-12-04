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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiString")]
    public unsafe partial struct AssimpString
    {
        public AssimpString
        (
            uint? length = null
        ) : this()
        {
            if (length is not null)
            {
                Length = length.Value;
            }
        }


        [NativeName("Type", "ai_uint32")]
        [NativeName("Type.Name", "ai_uint32")]
        [NativeName("Name", "length")]
        public uint Length;
        [NativeName("Type", "char [1024]")]
        [NativeName("Type.Name", "char [1024]")]
        [NativeName("Name", "data")]
        public fixed byte Data[1024];
    }
}
