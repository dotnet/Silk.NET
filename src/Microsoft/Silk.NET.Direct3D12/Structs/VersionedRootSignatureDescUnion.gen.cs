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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3580_C5")]
    public unsafe partial struct VersionedRootSignatureDescUnion
    {
        public VersionedRootSignatureDescUnion
        (
            RootSignatureDesc? desc10 = null,
            RootSignatureDesc1? desc11 = null
        ) : this()
        {
            if (desc10 is not null)
            {
                Desc10 = desc10.Value;
            }

            if (desc11 is not null)
            {
                Desc11 = desc11.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_SIGNATURE_DESC")]
        [NativeName("Type.Name", "D3D12_ROOT_SIGNATURE_DESC")]
        [NativeName("Name", "Desc_1_0")]
        public RootSignatureDesc Desc10;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_SIGNATURE_DESC1")]
        [NativeName("Type.Name", "D3D12_ROOT_SIGNATURE_DESC1")]
        [NativeName("Name", "Desc_1_1")]
        public RootSignatureDesc1 Desc11;
    }
}
