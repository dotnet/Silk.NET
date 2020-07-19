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
    [NativeName("Name", "ALLEGRO_EVENT_SOURCE")]
    public unsafe partial struct AllegroEventSource
    {
        [NativeName("Type", "int [32]")]
        [NativeName("Type.Name", "int [32]")]
        [NativeName("Name", "__pad")]
        public fixed int Pad[32];
    }
}
