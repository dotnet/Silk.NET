// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_LOCAL_ROOT_SIGNATURE")]
    public unsafe partial struct LocalRootSignature
    {
        public LocalRootSignature
        (
            ID3D12RootSignature* pLocalRootSignature = null
        ) : this()
        {
            if (pLocalRootSignature is not null)
            {
                PLocalRootSignature = pLocalRootSignature;
            }
        }


        [NativeName("Type", "ID3D12RootSignature *")]
        [NativeName("Type.Name", "ID3D12RootSignature *")]
        [NativeName("Name", "pLocalRootSignature")]
        public ID3D12RootSignature* PLocalRootSignature;
    }
}
