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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSamplerDescriptor")]
    public unsafe partial struct SamplerDescriptor
    {
        public SamplerDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            AddressMode? addressModeU = null,
            AddressMode? addressModeV = null,
            AddressMode? addressModeW = null,
            FilterMode? magFilter = null,
            FilterMode? minFilter = null,
            MipmapFilterMode? mipmapFilter = null,
            float? lodMinClamp = null,
            float? lodMaxClamp = null,
            CompareFunction? compare = null,
            ushort? maxAnisotropy = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (addressModeU is not null)
            {
                AddressModeU = addressModeU.Value;
            }

            if (addressModeV is not null)
            {
                AddressModeV = addressModeV.Value;
            }

            if (addressModeW is not null)
            {
                AddressModeW = addressModeW.Value;
            }

            if (magFilter is not null)
            {
                MagFilter = magFilter.Value;
            }

            if (minFilter is not null)
            {
                MinFilter = minFilter.Value;
            }

            if (mipmapFilter is not null)
            {
                MipmapFilter = mipmapFilter.Value;
            }

            if (lodMinClamp is not null)
            {
                LodMinClamp = lodMinClamp.Value;
            }

            if (lodMaxClamp is not null)
            {
                LodMaxClamp = lodMaxClamp.Value;
            }

            if (compare is not null)
            {
                Compare = compare.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "WGPUAddressMode")]
        [NativeName("Type.Name", "WGPUAddressMode")]
        [NativeName("Name", "addressModeU")]
        public AddressMode AddressModeU;

        [NativeName("Type", "WGPUAddressMode")]
        [NativeName("Type.Name", "WGPUAddressMode")]
        [NativeName("Name", "addressModeV")]
        public AddressMode AddressModeV;

        [NativeName("Type", "WGPUAddressMode")]
        [NativeName("Type.Name", "WGPUAddressMode")]
        [NativeName("Name", "addressModeW")]
        public AddressMode AddressModeW;

        [NativeName("Type", "WGPUFilterMode")]
        [NativeName("Type.Name", "WGPUFilterMode")]
        [NativeName("Name", "magFilter")]
        public FilterMode MagFilter;

        [NativeName("Type", "WGPUFilterMode")]
        [NativeName("Type.Name", "WGPUFilterMode")]
        [NativeName("Name", "minFilter")]
        public FilterMode MinFilter;

        [NativeName("Type", "WGPUMipmapFilterMode")]
        [NativeName("Type.Name", "WGPUMipmapFilterMode")]
        [NativeName("Name", "mipmapFilter")]
        public MipmapFilterMode MipmapFilter;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lodMinClamp")]
        public float LodMinClamp;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lodMaxClamp")]
        public float LodMaxClamp;

        [NativeName("Type", "WGPUCompareFunction")]
        [NativeName("Type.Name", "WGPUCompareFunction")]
        [NativeName("Name", "compare")]
        public CompareFunction Compare;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "maxAnisotropy")]
        public ushort MaxAnisotropy;
    }
}
