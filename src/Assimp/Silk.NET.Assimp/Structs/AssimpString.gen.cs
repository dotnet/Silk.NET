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
        [NativeName("Type", "char[1024]")]
        [NativeName("Type.Name", "char[1024]")]
        [NativeName("Name", "data")]
        public fixed byte Data[1024];
    }
}
