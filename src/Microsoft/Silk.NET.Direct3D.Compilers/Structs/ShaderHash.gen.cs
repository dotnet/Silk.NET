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
    [NativeName("Name", "DxcShaderHash")]
    public unsafe partial struct ShaderHash
    {
        public ShaderHash
        (
            uint? flags = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Flags")]
        public uint Flags;
        [NativeName("Type", "BYTE[16]")]
        [NativeName("Type.Name", "BYTE[16]")]
        [NativeName("Name", "HashDigest")]
        public fixed byte HashDigest[16];
    }
}
