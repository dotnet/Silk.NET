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

namespace Silk.NET.Allegro
{
    [NativeName("Name", "_al_tagbstring")]
    public unsafe partial struct AllegroString
    {
        public AllegroString
        (
            int mlen = default,
            int slen = default,
            byte* data = default
        )
        {
            Mlen = mlen;
            Slen = slen;
            Data = data;
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "mlen")]
        public int Mlen;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "slen")]
        public int Slen;

        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "data")]
        public byte* Data;
    }
}
