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
    [NativeName("Name", "ALLEGRO_TIMEOUT")]
    public unsafe partial struct AllegroTimeout
    {
        public AllegroTimeout
        (
            ulong pad1 = default,
            ulong pad2 = default
        )
        {
            Pad1 = pad1;
            Pad2 = pad2;
        }


        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "__pad1__")]
        public ulong Pad1;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "__pad2__")]
        public ulong Pad2;
    }
}
