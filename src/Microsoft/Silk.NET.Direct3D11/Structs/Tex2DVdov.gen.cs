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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEX2D_VDOV")]
    public unsafe partial struct Tex2DVdov
    {
        public Tex2DVdov
        (
            uint? arraySlice = null
        ) : this()
        {
            if (arraySlice is not null)
            {
                ArraySlice = arraySlice.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySlice")]
        public uint ArraySlice;
    }
}
