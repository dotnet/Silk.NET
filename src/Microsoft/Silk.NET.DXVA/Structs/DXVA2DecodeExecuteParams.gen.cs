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
    [NativeName("Name", "_DXVA2_DecodeExecuteParams")]
    public unsafe partial struct DXVA2DecodeExecuteParams
    {
        public DXVA2DecodeExecuteParams
        (
            uint? numCompBuffers = null,
            DXVA2DecodeBufferDesc* pCompressedBuffers = null,
            DXVA2DecodeExtensionData* pExtensionData = null
        ) : this()
        {
            if (numCompBuffers is not null)
            {
                NumCompBuffers = numCompBuffers.Value;
            }

            if (pCompressedBuffers is not null)
            {
                PCompressedBuffers = pCompressedBuffers;
            }

            if (pExtensionData is not null)
            {
                PExtensionData = pExtensionData;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumCompBuffers")]
        public uint NumCompBuffers;

        [NativeName("Type", "DXVA2_DecodeBufferDesc *")]
        [NativeName("Type.Name", "DXVA2_DecodeBufferDesc *")]
        [NativeName("Name", "pCompressedBuffers")]
        public DXVA2DecodeBufferDesc* PCompressedBuffers;

        [NativeName("Type", "DXVA2_DecodeExtensionData *")]
        [NativeName("Type.Name", "DXVA2_DecodeExtensionData *")]
        [NativeName("Name", "pExtensionData")]
        public DXVA2DecodeExtensionData* PExtensionData;
    }
}
