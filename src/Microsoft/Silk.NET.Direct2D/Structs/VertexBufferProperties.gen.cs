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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_VERTEX_BUFFER_PROPERTIES")]
    public unsafe partial struct VertexBufferProperties
    {
        public VertexBufferProperties
        (
            uint? inputCount = null,
            VertexUsage? usage = null,
            byte* data = null,
            uint? byteWidth = null
        ) : this()
        {
            if (inputCount is not null)
            {
                InputCount = inputCount.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (data is not null)
            {
                Data = data;
            }

            if (byteWidth is not null)
            {
                ByteWidth = byteWidth.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "inputCount")]
        public uint InputCount;

        [NativeName("Type", "D2D1_VERTEX_USAGE")]
        [NativeName("Type.Name", "D2D1_VERTEX_USAGE")]
        [NativeName("Name", "usage")]
        public VertexUsage Usage;

        [NativeName("Type", "const BYTE *")]
        [NativeName("Type.Name", "const BYTE *")]
        [NativeName("Name", "data")]
        public byte* Data;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "byteWidth")]
        public uint ByteWidth;
    }
}
