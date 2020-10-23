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
        )
        {
            fixed (AudioCVT* @this = &this)
            {
                // all fields automatically initialized here
            }

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
        public void* Filters_0;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_1;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_2;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_3;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_4;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_5;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_6;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_7;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_8;
        
        [NativeName("Type", "SDL_AudioFilter [10]")]
        [NativeName("Type.Name", "SDL_AudioFilter [10]")]
        [NativeName("Name", "filters")]
        public void* Filters_9;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "filter_index")]
        public int FilterIndex;
    }
}
