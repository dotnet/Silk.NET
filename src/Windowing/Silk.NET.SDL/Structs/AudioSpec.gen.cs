// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_AudioSpec")]
    public unsafe partial struct AudioSpec
    {
        public AudioSpec
        (
            int? freq = null,
            ushort? format = null,
            byte? channels = null,
            byte? silence = null,
            ushort? samples = null,
            ushort? padding = null,
            uint? size = null,
            void* callback = null,
            void* userdata = null
        ) : this()
        {
            if (freq is not null)
            {
                Freq = freq.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (channels is not null)
            {
                Channels = channels.Value;
            }

            if (silence is not null)
            {
                Silence = silence.Value;
            }

            if (samples is not null)
            {
                Samples = samples.Value;
            }

            if (padding is not null)
            {
                Padding = padding.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (callback is not null)
            {
                Callback = callback;
            }

            if (userdata is not null)
            {
                Userdata = userdata;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "freq")]
        public int Freq;

        [NativeName("Type", "SDL_AudioFormat")]
        [NativeName("Type.Name", "SDL_AudioFormat")]
        [NativeName("Name", "format")]
        public ushort Format;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "channels")]
        public byte Channels;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "silence")]
        public byte Silence;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "samples")]
        public ushort Samples;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "padding")]
        public ushort Padding;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "size")]
        public uint Size;

        [NativeName("Type", "SDL_AudioCallback")]
        [NativeName("Type.Name", "SDL_AudioCallback")]
        [NativeName("Name", "callback")]
        public void* Callback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;
    }
}
