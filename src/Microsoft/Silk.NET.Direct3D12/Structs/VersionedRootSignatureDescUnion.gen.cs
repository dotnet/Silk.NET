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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L4125_C5")]
    public unsafe partial struct VersionedRootSignatureDescUnion
    {
        public VersionedRootSignatureDescUnion
        (
            RootSignatureDesc? desc10 = null,
            RootSignatureDesc1? desc11 = null,
            RootSignatureDesc2? desc12 = null
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

            if (desc12 is not null)
            {
                Desc12 = desc12.Value;
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

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_SIGNATURE_DESC2")]
        [NativeName("Type.Name", "D3D12_ROOT_SIGNATURE_DESC2")]
        [NativeName("Name", "Desc_1_2")]
        public RootSignatureDesc2 Desc12;
    }
}
