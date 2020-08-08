// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_AudioCVT")]
    public unsafe partial struct AudioCVT
    {
        public AudioCVT
        (
            int needed = default,
            ushort srcFormat = default,
            ushort dstFormat = default,
            double rateIncr = default,
            byte* buf = default,
            int len = default,
            int lenCvt = default,
            int lenMult = default,
            double lenRatio = default,
            int filterIndex = default
        )
        {
            Needed = needed;
            SrcFormat = srcFormat;
            DstFormat = dstFormat;
            RateIncr = rateIncr;
            Buf = buf;
            Len = len;
            LenCvt = lenCvt;
            LenMult = lenMult;
            LenRatio = lenRatio;
           Filters_0 = default;
           Filters_1 = default;
           Filters_2 = default;
           Filters_3 = default;
           Filters_4 = default;
           Filters_5 = default;
           Filters_6 = default;
           Filters_7 = default;
           Filters_8 = default;
           Filters_9 = default;
            FilterIndex = filterIndex;
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
