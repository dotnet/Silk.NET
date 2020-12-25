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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_AudioCVT")]
    public unsafe partial struct AudioCVT
    {
        public AudioCVT
        (
            int? needed = null,
            ushort? srcFormat = null,
            ushort? dstFormat = null,
            double? rateIncr = null,
            byte* buf = null,
            int? len = null,
            int? lenCvt = null,
            int? lenMult = null,
            double? lenRatio = null,
            int? filterIndex = null
        ) : this()
        {
            if (needed is not null)
            {
                Needed = needed.Value;
            }

            if (srcFormat is not null)
            {
                SrcFormat = srcFormat.Value;
            }

            if (dstFormat is not null)
            {
                DstFormat = dstFormat.Value;
            }

            if (rateIncr is not null)
            {
                RateIncr = rateIncr.Value;
            }

            if (buf is not null)
            {
                Buf = buf;
            }

            if (len is not null)
            {
                Len = len.Value;
            }

            if (lenCvt is not null)
            {
                LenCvt = lenCvt.Value;
            }

            if (lenMult is not null)
            {
                LenMult = lenMult.Value;
            }

            if (lenRatio is not null)
            {
                LenRatio = lenRatio.Value;
            }

            if (filterIndex is not null)
            {
                FilterIndex = filterIndex.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "needed")]
        public int Needed;

        [NativeName("Type", "SDL_AudioFormat")]
        [NativeName("Type.Name", "SDL_AudioFormat")]
        [NativeName("Name", "src_format")]
        public ushort SrcFormat;

        [NativeName("Type", "SDL_AudioFormat")]
        [NativeName("Type.Name", "SDL_AudioFormat")]
        [NativeName("Name", "dst_format")]
        public ushort DstFormat;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "rate_incr")]
        public double RateIncr;

        [NativeName("Type", "Uint8 *")]
        [NativeName("Type.Name", "Uint8 *")]
        [NativeName("Name", "buf")]
        public byte* Buf;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "len")]
        public int Len;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "len_cvt")]
        public int LenCvt;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "len_mult")]
        public int LenMult;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "len_ratio")]
        public double LenRatio;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public FiltersBuffer Filters;

        public struct FiltersBuffer
        {
            public PfnSDLAudioCVTvUsV Element0;
            public PfnSDLAudioCVTvUsV Element1;
            public PfnSDLAudioCVTvUsV Element2;
            public PfnSDLAudioCVTvUsV Element3;
            public PfnSDLAudioCVTvUsV Element4;
            public PfnSDLAudioCVTvUsV Element5;
            public PfnSDLAudioCVTvUsV Element6;
            public PfnSDLAudioCVTvUsV Element7;
            public PfnSDLAudioCVTvUsV Element8;
            public PfnSDLAudioCVTvUsV Element9;
            public ref PfnSDLAudioCVTvUsV this[int index]
            {
                get
                {
                    if (index > 9 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (PfnSDLAudioCVTvUsV* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1
            public Span<PfnSDLAudioCVTvUsV> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 10);
#endif
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "filter_index")]
        public int FilterIndex;
    }
}
