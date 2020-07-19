// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_SEEK")]
    public enum AllegroSeek
    {
        [NativeName("Name", "ALLEGRO_SEEK_SET")]
        AllegroSeekSet = 0x0,
        [NativeName("Name", "ALLEGRO_SEEK_CUR")]
        AllegroSeekCur = 0x1,
        [NativeName("Name", "ALLEGRO_SEEK_END")]
        AllegroSeekEnd = 0x2,
    }
}
