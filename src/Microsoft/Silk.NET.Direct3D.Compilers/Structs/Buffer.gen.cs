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
    [NativeName("Name", "DxcBuffer")]
    public unsafe partial struct Buffer
    {
        public Buffer
        (
            void* ptr = null,
            nuint? size = null,
            uint? encoding = null
        ) : this()
        {
            if (ptr is not null)
            {
                Ptr = ptr;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (encoding is not null)
            {
                Encoding = encoding.Value;
            }
        }


        [NativeName("Type", "LPCVOID")]
        [NativeName("Type.Name", "LPCVOID")]
        [NativeName("Name", "Ptr")]
        public void* Ptr;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "Size")]
        public nuint Size;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Encoding")]
        public uint Encoding;
    }
}
