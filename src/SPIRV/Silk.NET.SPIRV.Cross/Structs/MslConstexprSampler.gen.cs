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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_constexpr_sampler")]
    public unsafe partial struct MslConstexprSampler
    {
        public MslConstexprSampler
        (
            MslSamplerCoord? coord = null,
            MslSamplerFilter? minFilter = null,
            MslSamplerFilter? magFilter = null,
            MslSamplerMipFilter? mipFilter = null,
            MslSamplerAddress? sAddress = null,
            MslSamplerAddress? tAddress = null,
            MslSamplerAddress? rAddress = null,
            MslSamplerCompareFunc? compareFunc = null,
            MslSamplerBorderColor? borderColor = null,
            float? lodClampMin = null,
            float? lodClampMax = null,
            int? maxAnisotropy = null,
            byte? compareEnable = null,
            byte? lodClampEnable = null,
            byte? anisotropyEnable = null
        ) : this()
        {
            if (coord is not null)
            {
                Coord = coord.Value;
            }

            if (minFilter is not null)
            {
                MinFilter = minFilter.Value;
            }

            if (magFilter is not null)
            {
                MagFilter = magFilter.Value;
            }

            if (mipFilter is not null)
            {
                MipFilter = mipFilter.Value;
            }

            if (sAddress is not null)
            {
                SAddress = sAddress.Value;
            }

            if (tAddress is not null)
            {
                TAddress = tAddress.Value;
            }

            if (rAddress is not null)
            {
                RAddress = rAddress.Value;
            }

            if (compareFunc is not null)
            {
                CompareFunc = compareFunc.Value;
            }

            if (borderColor is not null)
            {
                BorderColor = borderColor.Value;
            }

            if (lodClampMin is not null)
            {
                LodClampMin = lodClampMin.Value;
            }

            if (lodClampMax is not null)
            {
                LodClampMax = lodClampMax.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }

            if (compareEnable is not null)
            {
                CompareEnable = compareEnable.Value;
            }

            if (lodClampEnable is not null)
            {
                LodClampEnable = lodClampEnable.Value;
            }

            if (anisotropyEnable is not null)
            {
                AnisotropyEnable = anisotropyEnable.Value;
            }
        }


        [NativeName("Type", "spvc_msl_sampler_coord")]
        [NativeName("Type.Name", "spvc_msl_sampler_coord")]
        [NativeName("Name", "coord")]
        public MslSamplerCoord Coord;

        [NativeName("Type", "spvc_msl_sampler_filter")]
        [NativeName("Type.Name", "spvc_msl_sampler_filter")]
        [NativeName("Name", "min_filter")]
        public MslSamplerFilter MinFilter;

        [NativeName("Type", "spvc_msl_sampler_filter")]
        [NativeName("Type.Name", "spvc_msl_sampler_filter")]
        [NativeName("Name", "mag_filter")]
        public MslSamplerFilter MagFilter;

        [NativeName("Type", "spvc_msl_sampler_mip_filter")]
        [NativeName("Type.Name", "spvc_msl_sampler_mip_filter")]
        [NativeName("Name", "mip_filter")]
        public MslSamplerMipFilter MipFilter;

        [NativeName("Type", "spvc_msl_sampler_address")]
        [NativeName("Type.Name", "spvc_msl_sampler_address")]
        [NativeName("Name", "s_address")]
        public MslSamplerAddress SAddress;

        [NativeName("Type", "spvc_msl_sampler_address")]
        [NativeName("Type.Name", "spvc_msl_sampler_address")]
        [NativeName("Name", "t_address")]
        public MslSamplerAddress TAddress;

        [NativeName("Type", "spvc_msl_sampler_address")]
        [NativeName("Type.Name", "spvc_msl_sampler_address")]
        [NativeName("Name", "r_address")]
        public MslSamplerAddress RAddress;

        [NativeName("Type", "spvc_msl_sampler_compare_func")]
        [NativeName("Type.Name", "spvc_msl_sampler_compare_func")]
        [NativeName("Name", "compare_func")]
        public MslSamplerCompareFunc CompareFunc;

        [NativeName("Type", "spvc_msl_sampler_border_color")]
        [NativeName("Type.Name", "spvc_msl_sampler_border_color")]
        [NativeName("Name", "border_color")]
        public MslSamplerBorderColor BorderColor;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lod_clamp_min")]
        public float LodClampMin;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lod_clamp_max")]
        public float LodClampMax;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "max_anisotropy")]
        public int MaxAnisotropy;

        [NativeName("Type", "spvc_bool")]
        [NativeName("Type.Name", "spvc_bool")]
        [NativeName("Name", "compare_enable")]
        public byte CompareEnable;

        [NativeName("Type", "spvc_bool")]
        [NativeName("Type.Name", "spvc_bool")]
        [NativeName("Name", "lod_clamp_enable")]
        public byte LodClampEnable;

        [NativeName("Type", "spvc_bool")]
        [NativeName("Type.Name", "spvc_bool")]
        [NativeName("Name", "anisotropy_enable")]
        public byte AnisotropyEnable;
    }
}
