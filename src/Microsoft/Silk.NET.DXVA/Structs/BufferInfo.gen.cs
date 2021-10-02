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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVABufferInfo")]
    public unsafe partial struct BufferInfo
    {
        public BufferInfo
        (
            void* pCompSurface = null,
            uint? dataOffset = null,
            uint? dataSize = null
        ) : this()
        {
            if (pCompSurface is not null)
            {
                PCompSurface = pCompSurface;
            }

            if (dataOffset is not null)
            {
                DataOffset = dataOffset.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pCompSurface")]
        public void* PCompSurface;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DataOffset")]
        public uint DataOffset;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;
    }
}
