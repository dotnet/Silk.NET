// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_display_L75_C1")]
    public enum AllegroImportance
    {
        [NativeName("Name", "ALLEGRO_DONTCARE")]
        AllegroDontcare = 0x0,
        [NativeName("Name", "ALLEGRO_REQUIRE")]
        AllegroRequire = 0x1,
        [NativeName("Name", "ALLEGRO_SUGGEST")]
        AllegroSuggest = 0x2,
    }
}
