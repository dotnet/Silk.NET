// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_bitmap_io_L14_C1")]
    public enum AllegroBitmapIOFlags
    {
        [NativeName("Name", "ALLEGRO_KEEP_BITMAP_FORMAT")]
        AllegroKeepBitmapFormat = 0x2,
        [NativeName("Name", "ALLEGRO_NO_PREMULTIPLIED_ALPHA")]
        AllegroNoPremultipliedAlpha = 0x200,
        [NativeName("Name", "ALLEGRO_KEEP_INDEX")]
        AllegroKeepIndex = 0x800,
    }
}
