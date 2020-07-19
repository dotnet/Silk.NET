// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_BLEND_MODE")]
    public enum AllegroBlendMode
    {
        [NativeName("Name", "ALLEGRO_ZERO")]
        AllegroZero = 0x0,
        [NativeName("Name", "ALLEGRO_ONE")]
        AllegroOne = 0x1,
        [NativeName("Name", "ALLEGRO_ALPHA")]
        AllegroAlpha = 0x2,
        [NativeName("Name", "ALLEGRO_INVERSE_ALPHA")]
        AllegroInverseAlpha = 0x3,
        [NativeName("Name", "ALLEGRO_SRC_COLOR")]
        AllegroSrcColor = 0x4,
        [NativeName("Name", "ALLEGRO_DEST_COLOR")]
        AllegroDestColor = 0x5,
        [NativeName("Name", "ALLEGRO_INVERSE_SRC_COLOR")]
        AllegroInverseSrcColor = 0x6,
        [NativeName("Name", "ALLEGRO_INVERSE_DEST_COLOR")]
        AllegroInverseDestColor = 0x7,
        [NativeName("Name", "ALLEGRO_CONST_COLOR")]
        AllegroConstColor = 0x8,
        [NativeName("Name", "ALLEGRO_INVERSE_CONST_COLOR")]
        AllegroInverseConstColor = 0x9,
        [NativeName("Name", "ALLEGRO_NUM_BLEND_MODES")]
        AllegroNumBlendModes = 0xA,
    }
}
