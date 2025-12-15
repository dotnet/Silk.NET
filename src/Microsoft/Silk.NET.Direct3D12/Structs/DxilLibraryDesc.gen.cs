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
    [NativeName("Name", "D3D12_DXIL_LIBRARY_DESC")]
    public unsafe partial struct DxilLibraryDesc
    {
        public DxilLibraryDesc
        (
            ShaderBytecode? dXILLibrary = null,
            uint? numExports = null,
            ExportDesc* pExports = null
        ) : this()
        {
            if (dXILLibrary is not null)
            {
                DXILLibrary = dXILLibrary.Value;
            }

            if (numExports is not null)
            {
                NumExports = numExports.Value;
            }

            if (pExports is not null)
            {
                PExports = pExports;
            }
        }


        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "DXILLibrary")]
        public ShaderBytecode DXILLibrary;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumExports")]
        public uint NumExports;

        [NativeName("Type", "const D3D12_EXPORT_DESC *")]
        [NativeName("Type.Name", "const D3D12_EXPORT_DESC *")]
        [NativeName("Name", "pExports")]
        public ExportDesc* PExports;
    }
}
