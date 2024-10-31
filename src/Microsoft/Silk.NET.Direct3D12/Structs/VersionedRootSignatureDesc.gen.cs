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
    [NativeName("Name", "D3D12_VERSIONED_ROOT_SIGNATURE_DESC")]
    public unsafe partial struct VersionedRootSignatureDesc
    {
        public VersionedRootSignatureDesc
        (
            D3DRootSignatureVersion? version = null,
            VersionedRootSignatureDescUnion? anonymous = null,
            RootSignatureDesc? desc10 = null,
            RootSignatureDesc1? desc11 = null,
            RootSignatureDesc2? desc12 = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Type.Name", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Name", "Version")]
        public D3DRootSignatureVersion Version;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L4125_C5")]
        [NativeName("Name", "anonymous1")]
        public VersionedRootSignatureDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootSignatureDesc Desc10
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Desc10;
        }
#else
        public RootSignatureDesc Desc10
        {
            get => Anonymous.Desc10;
            set => Anonymous.Desc10 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootSignatureDesc1 Desc11
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Desc11;
        }
#else
        public RootSignatureDesc1 Desc11
        {
            get => Anonymous.Desc11;
            set => Anonymous.Desc11 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootSignatureDesc2 Desc12
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Desc12;
        }
#else
        public RootSignatureDesc2 Desc12
        {
            get => Anonymous.Desc12;
            set => Anonymous.Desc12 = value;
        }
#endif

    }
}
