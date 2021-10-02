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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STREAM_OUTPUT_DESC")]
    public unsafe partial struct StreamOutputDesc
    {
        public StreamOutputDesc
        (
            SODeclarationEntry* pSODeclaration = null,
            uint? numEntries = null,
            uint* pBufferStrides = null,
            uint? numStrides = null,
            uint? rasterizedStream = null
        ) : this()
        {
            if (pSODeclaration is not null)
            {
                PSODeclaration = pSODeclaration;
            }

            if (numEntries is not null)
            {
                NumEntries = numEntries.Value;
            }

            if (pBufferStrides is not null)
            {
                PBufferStrides = pBufferStrides;
            }

            if (numStrides is not null)
            {
                NumStrides = numStrides.Value;
            }

            if (rasterizedStream is not null)
            {
                RasterizedStream = rasterizedStream.Value;
            }
        }


        [NativeName("Type", "const D3D12_SO_DECLARATION_ENTRY *")]
        [NativeName("Type.Name", "const D3D12_SO_DECLARATION_ENTRY *")]
        [NativeName("Name", "pSODeclaration")]
        public SODeclarationEntry* PSODeclaration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumEntries")]
        public uint NumEntries;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pBufferStrides")]
        public uint* PBufferStrides;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumStrides")]
        public uint NumStrides;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RasterizedStream")]
        public uint RasterizedStream;
    }
}
