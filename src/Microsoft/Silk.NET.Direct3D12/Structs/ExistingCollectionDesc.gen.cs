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
    [NativeName("Name", "D3D12_EXISTING_COLLECTION_DESC")]
    public unsafe partial struct ExistingCollectionDesc
    {
        public ExistingCollectionDesc
        (
            ID3D12StateObject* pExistingCollection = null,
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


        [NativeName("Type", "ID3D12StateObject *")]
        [NativeName("Type.Name", "ID3D12StateObject *")]
        [NativeName("Name", "pExistingCollection")]
        public ID3D12StateObject* PExistingCollection;

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
