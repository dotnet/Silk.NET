// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_BLEND_OPERATIONS")]
    public enum AllegroBlendOperations
    {
        [NativeName("Name", "ALLEGRO_ADD")]
        AllegroAdd = 0x0,
        [NativeName("Name", "ALLEGRO_SRC_MINUS_DEST")]
        AllegroSrcMinusDest = 0x1,
        [NativeName("Name", "ALLEGRO_DEST_MINUS_SRC")]
        AllegroDestMinusSrc = 0x2,
        [NativeName("Name", "ALLEGRO_NUM_BLEND_OPERATIONS")]
        AllegroNumBlendOperations = 0x3,
    }
}
