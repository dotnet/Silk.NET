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

namespace Silk.NET.Direct3D9
{
    public unsafe partial class D3D9 : NativeAPI
    {

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 220, Column 21 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\d3d9helper.h")]
        [NativeApi(EntryPoint = "Direct3DCreate9")]
        public unsafe partial IDirect3D9* Direct3DCreate9(uint SDKVersion);


        public D3D9(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

