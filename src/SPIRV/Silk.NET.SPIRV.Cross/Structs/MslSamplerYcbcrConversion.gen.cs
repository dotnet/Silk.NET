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
    [NativeName("Name", "spvc_msl_sampler_ycbcr_conversion")]
    public unsafe partial struct MslSamplerYcbcrConversion
    {
        public MslSamplerYcbcrConversion
        (
            uint? planes = null,
            MslFormatResolution? resolution = null,
            MslSamplerFilter? chromaFilter = null,
            MslChromaLocation? xChromaOffset = null,
            MslChromaLocation? yChromaOffset = null,
            MslSamplerYcbcrModelConversion? ycbcrModel = null,
            MslSamplerYcbcrRange? ycbcrRange = null,
            uint? bpc = null
        ) : this()
        {
            if (planes is not null)
            {
                Planes = planes.Value;
            }

            if (resolution is not null)
            {
                Resolution = resolution.Value;
            }

            if (chromaFilter is not null)
            {
                ChromaFilter = chromaFilter.Value;
            }

            if (xChromaOffset is not null)
            {
                XChromaOffset = xChromaOffset.Value;
            }

            if (yChromaOffset is not null)
            {
                YChromaOffset = yChromaOffset.Value;
            }

            if (ycbcrModel is not null)
            {
                YcbcrModel = ycbcrModel.Value;
            }

            if (ycbcrRange is not null)
            {
                YcbcrRange = ycbcrRange.Value;
            }

            if (bpc is not null)
            {
                Bpc = bpc.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "planes")]
        public uint Planes;

        [NativeName("Type", "spvc_msl_format_resolution")]
        [NativeName("Type.Name", "spvc_msl_format_resolution")]
        [NativeName("Name", "resolution")]
        public MslFormatResolution Resolution;

        [NativeName("Type", "spvc_msl_sampler_filter")]
        [NativeName("Type.Name", "spvc_msl_sampler_filter")]
        [NativeName("Name", "chroma_filter")]
        public MslSamplerFilter ChromaFilter;

        [NativeName("Type", "spvc_msl_chroma_location")]
        [NativeName("Type.Name", "spvc_msl_chroma_location")]
        [NativeName("Name", "x_chroma_offset")]
        public MslChromaLocation XChromaOffset;

        [NativeName("Type", "spvc_msl_chroma_location")]
        [NativeName("Type.Name", "spvc_msl_chroma_location")]
        [NativeName("Name", "y_chroma_offset")]
        public MslChromaLocation YChromaOffset;
        
        [NativeName("Type", "spvc_msl_component_swizzle[4]")]
        [NativeName("Type.Name", "spvc_msl_component_swizzle[4]")]
        [NativeName("Name", "swizzle")]
        public SwizzleBuffer Swizzle;

        public struct SwizzleBuffer
        {
            public MslComponentSwizzle Element0;
            public MslComponentSwizzle Element1;
            public MslComponentSwizzle Element2;
            public MslComponentSwizzle Element3;
            public ref MslComponentSwizzle this[int index]
            {
                get
                {
                    if (index > 3 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (MslComponentSwizzle* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<MslComponentSwizzle> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 4);
#endif
        }


        [NativeName("Type", "spvc_msl_sampler_ycbcr_model_conversion")]
        [NativeName("Type.Name", "spvc_msl_sampler_ycbcr_model_conversion")]
        [NativeName("Name", "ycbcr_model")]
        public MslSamplerYcbcrModelConversion YcbcrModel;

        [NativeName("Type", "spvc_msl_sampler_ycbcr_range")]
        [NativeName("Type.Name", "spvc_msl_sampler_ycbcr_range")]
        [NativeName("Name", "ycbcr_range")]
        public MslSamplerYcbcrRange YcbcrRange;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "bpc")]
        public uint Bpc;
    }
}
