// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION")]
    public unsafe partial struct DxilSubobjectToExportsAssociation
    {
        public DxilSubobjectToExportsAssociation
        (
            char* subobjectToAssociate = null,
            uint? numExports = null,
            char** pExports = null
        ) : this()
        {
            if (subobjectToAssociate is not null)
            {
                SubobjectToAssociate = subobjectToAssociate;
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


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "SubobjectToAssociate")]
        public char* SubobjectToAssociate;

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
