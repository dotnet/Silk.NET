// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_bitmap_lock_L14_C1")]
    public enum AllegroBitmapLockFlags
    {
        [NativeName("Name", "ALLEGRO_LOCK_READWRITE")]
        AllegroLockReadwrite = 0x0,
        [NativeName("Name", "ALLEGRO_LOCK_READONLY")]
        AllegroLockReadonly = 0x1,
        [NativeName("Name", "ALLEGRO_LOCK_WRITEONLY")]
        AllegroLockWriteonly = 0x2,
    }
}
