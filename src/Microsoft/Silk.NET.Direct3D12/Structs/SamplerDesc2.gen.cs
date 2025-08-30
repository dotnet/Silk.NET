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
    [NativeName("Name", "D3D12_SAMPLER_DESC2")]
    public unsafe partial struct SamplerDesc2
    {
        public SamplerDesc2
        (
            Filter? filter = null,
            TextureAddressMode? addressU = null,
            TextureAddressMode? addressV = null,
            TextureAddressMode? addressW = null,
            float? mipLODBias = null,
            uint? maxAnisotropy = null,
            ComparisonFunc? comparisonFunc = null,
            SamplerDesc2Union? anonymous = null,
            float? minLOD = null,
            float? maxLOD = null,
            SamplerFlags? flags = null
        ) : this()
        {
            if (filter is not null)
            {
                Filter = filter.Value;
            }

            if (addressU is not null)
            {
                AddressU = addressU.Value;
            }

            if (addressV is not null)
            {
                AddressV = addressV.Value;
            }

            if (addressW is not null)
            {
                AddressW = addressW.Value;
            }

            if (mipLODBias is not null)
            {
                MipLODBias = mipLODBias.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }

            if (comparisonFunc is not null)
            {
                ComparisonFunc = comparisonFunc.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (minLOD is not null)
            {
                MinLOD = minLOD.Value;
            }

            if (maxLOD is not null)
            {
                MaxLOD = maxLOD.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "D3D12_FILTER")]
        [NativeName("Type.Name", "D3D12_FILTER")]
        [NativeName("Name", "Filter")]
        public Filter Filter;

        [NativeName("Type", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Type.Name", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Name", "AddressU")]
        public TextureAddressMode AddressU;

        [NativeName("Type", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Type.Name", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Name", "AddressV")]
        public TextureAddressMode AddressV;

        [NativeName("Type", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Type.Name", "D3D12_TEXTURE_ADDRESS_MODE")]
        [NativeName("Name", "AddressW")]
        public TextureAddressMode AddressW;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MipLODBias")]
        public float MipLODBias;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxAnisotropy")]
        public uint MaxAnisotropy;

        [NativeName("Type", "D3D12_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D12_COMPARISON_FUNC")]
        [NativeName("Name", "ComparisonFunc")]
        public ComparisonFunc ComparisonFunc;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3603_C5")]
        [NativeName("Name", "anonymous1")]
        public SamplerDesc2Union Anonymous;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinLOD")]
        public float MinLOD;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxLOD")]
        public float MaxLOD;

        [NativeName("Type", "D3D12_SAMPLER_FLAGS")]
        [NativeName("Type.Name", "D3D12_SAMPLER_FLAGS")]
        [NativeName("Name", "Flags")]
        public SamplerFlags Flags;
    }
}
