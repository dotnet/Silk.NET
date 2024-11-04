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
    [NativeName("Name", "D3D12_STATIC_SAMPLER_DESC1")]
    public unsafe partial struct StaticSamplerDesc1
    {
        public StaticSamplerDesc1
        (
            Filter? filter = null,
            TextureAddressMode? addressU = null,
            TextureAddressMode? addressV = null,
            TextureAddressMode? addressW = null,
            float? mipLODBias = null,
            uint? maxAnisotropy = null,
            ComparisonFunc? comparisonFunc = null,
            StaticBorderColor? borderColor = null,
            float? minLOD = null,
            float? maxLOD = null,
            uint? shaderRegister = null,
            uint? registerSpace = null,
            ShaderVisibility? shaderVisibility = null,
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

            if (borderColor is not null)
            {
                BorderColor = borderColor.Value;
            }

            if (minLOD is not null)
            {
                MinLOD = minLOD.Value;
            }

            if (maxLOD is not null)
            {
                MaxLOD = maxLOD.Value;
            }

            if (shaderRegister is not null)
            {
                ShaderRegister = shaderRegister.Value;
            }

            if (registerSpace is not null)
            {
                RegisterSpace = registerSpace.Value;
            }

            if (shaderVisibility is not null)
            {
                ShaderVisibility = shaderVisibility.Value;
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

        [NativeName("Type", "D3D12_STATIC_BORDER_COLOR")]
        [NativeName("Type.Name", "D3D12_STATIC_BORDER_COLOR")]
        [NativeName("Name", "BorderColor")]
        public StaticBorderColor BorderColor;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinLOD")]
        public float MinLOD;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxLOD")]
        public float MaxLOD;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ShaderRegister")]
        public uint ShaderRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RegisterSpace")]
        public uint RegisterSpace;

        [NativeName("Type", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Type.Name", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Name", "ShaderVisibility")]
        public ShaderVisibility ShaderVisibility;

        [NativeName("Type", "D3D12_SAMPLER_FLAGS")]
        [NativeName("Type.Name", "D3D12_SAMPLER_FLAGS")]
        [NativeName("Name", "Flags")]
        public SamplerFlags Flags;
    }
}
