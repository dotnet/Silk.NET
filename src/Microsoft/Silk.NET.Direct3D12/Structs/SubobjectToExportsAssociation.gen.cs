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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
    public unsafe partial struct SubobjectToExportsAssociation
    {
        public SubobjectToExportsAssociation
        (
            StateSubobject* pSubobjectToAssociate = null,
            uint? numExports = null,
            char** pExports = null
        ) : this()
        {
            if (pSubobjectToAssociate is not null)
            {
                PSubobjectToAssociate = pSubobjectToAssociate;
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


        [NativeName("Type", "const D3D12_STATE_SUBOBJECT *")]
        [NativeName("Type.Name", "const D3D12_STATE_SUBOBJECT *")]
        [NativeName("Name", "pSubobjectToAssociate")]
        public StateSubobject* PSubobjectToAssociate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumExports")]
        public uint NumExports;

        [NativeName("Type", "LPCWSTR *")]
        [NativeName("Type.Name", "LPCWSTR *")]
        [NativeName("Name", "pExports")]
        public char** PExports;
    }
}
