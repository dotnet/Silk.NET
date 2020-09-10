// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SAMPLER_DESC")]
    public unsafe partial struct SamplerDesc
    {
        public SamplerDesc
        (
            Filter filter = default,
            TextureAddressMode addressU = default,
            TextureAddressMode addressV = default,
            TextureAddressMode addressW = default,
            float mipLODBias = default,
            uint maxAnisotropy = default,
            ComparisonFunc comparisonFunc = default,
            float minLOD = default,
            float maxLOD = default
        )
        {
            Filter = filter;
            AddressU = addressU;
            AddressV = addressV;
            AddressW = addressW;
            MipLODBias = mipLODBias;
            MaxAnisotropy = maxAnisotropy;
            ComparisonFunc = comparisonFunc;
            MinLOD = minLOD;
            MaxLOD = maxLOD;
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
        [NativeName("Type", "FLOAT [4]")]
        [NativeName("Type.Name", "FLOAT [4]")]
        [NativeName("Name", "BorderColor")]
        public fixed float BorderColor[4];

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinLOD")]
        public float MinLOD;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxLOD")]
        public float MaxLOD;
    }
}
