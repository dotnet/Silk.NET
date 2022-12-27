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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_JPEG_AC_HUFFMAN_TABLE")]
    public unsafe partial struct JpegACHuffmanTable
    {
        [NativeName("Type", "BYTE[16]")]
        [NativeName("Type.Name", "BYTE[16]")]
        [NativeName("Name", "CodeCounts")]
        public fixed byte CodeCounts[16];
        [NativeName("Type", "BYTE[162]")]
        [NativeName("Type.Name", "BYTE[162]")]
        [NativeName("Name", "CodeValues")]
        public fixed byte CodeValues[162];
    }
}
