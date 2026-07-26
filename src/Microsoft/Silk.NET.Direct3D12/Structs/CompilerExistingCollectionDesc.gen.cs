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
    [NativeName("Name", "D3D12_COMPILER_EXISTING_COLLECTION_DESC")]
    public unsafe partial struct CompilerExistingCollectionDesc
    {
        public CompilerExistingCollectionDesc
        (
            ID3D12CompilerStateObject* pExistingCollection = null,
            uint? numExports = null,
            ExportDesc* pExports = null
        ) : this()
        {
            if (pExistingCollection is not null)
            {
                PExistingCollection = pExistingCollection;
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


        [NativeName("Type", "ID3D12CompilerStateObject *")]
        [NativeName("Type.Name", "ID3D12CompilerStateObject *")]
        [NativeName("Name", "pExistingCollection")]
        public ID3D12CompilerStateObject* PExistingCollection;

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
