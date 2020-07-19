// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_JOYFLAGS")]
    public enum AllegroJoyflags
    {
        [NativeName("Name", "ALLEGRO_JOYFLAG_DIGITAL")]
        AllegroJoyflagDigital = 0x1,
        [NativeName("Name", "ALLEGRO_JOYFLAG_ANALOGUE")]
        AllegroJoyflagAnalogue = 0x2,
    }
}
