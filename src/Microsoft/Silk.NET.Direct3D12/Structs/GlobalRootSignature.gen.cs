// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_GLOBAL_ROOT_SIGNATURE")]
    public unsafe partial struct GlobalRootSignature
    {
        public GlobalRootSignature
        (
            ID3D12RootSignature* pGlobalRootSignature = null
        ) : this()
        {
            if (pGlobalRootSignature is not null)
            {
                PGlobalRootSignature = pGlobalRootSignature;
            }
        }


        [NativeName("Type", "ID3D12RootSignature *")]
        [NativeName("Type.Name", "ID3D12RootSignature *")]
        [NativeName("Name", "pGlobalRootSignature")]
        public ID3D12RootSignature* PGlobalRootSignature;
    }
}
