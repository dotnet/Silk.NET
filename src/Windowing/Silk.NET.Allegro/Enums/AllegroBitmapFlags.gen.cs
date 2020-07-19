// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_bitmap_L18_C1")]
    public enum AllegroBitmapFlags
    {
        [NativeName("Name", "ALLEGRO_MEMORY_BITMAP")]
        AllegroMemoryBitmap = 0x1,
        [NativeName("Name", "_ALLEGRO_KEEP_BITMAP_FORMAT")]
        AllegroKeepBitmapFormat = 0x2,
        [NativeName("Name", "ALLEGRO_FORCE_LOCKING")]
        AllegroForceLocking = 0x4,
        [NativeName("Name", "ALLEGRO_NO_PRESERVE_TEXTURE")]
        AllegroNoPreserveTexture = 0x8,
        [NativeName("Name", "_ALLEGRO_ALPHA_TEST")]
        AllegroAlphaTest = 0x10,
        [NativeName("Name", "_ALLEGRO_INTERNAL_OPENGL")]
        AllegroInternalOpengl = 0x20,
        [NativeName("Name", "ALLEGRO_MIN_LINEAR")]
        AllegroMinLinear = 0x40,
        [NativeName("Name", "ALLEGRO_MAG_LINEAR")]
        AllegroMagLinear = 0x80,
        [NativeName("Name", "ALLEGRO_MIPMAP")]
        AllegroMipmap = 0x100,
        [NativeName("Name", "_ALLEGRO_NO_PREMULTIPLIED_ALPHA")]
        AllegroNoPremultipliedAlpha = 0x200,
        [NativeName("Name", "ALLEGRO_VIDEO_BITMAP")]
        AllegroVideoBitmap = 0x400,
        [NativeName("Name", "ALLEGRO_CONVERT_BITMAP")]
        AllegroConvertBitmap = 0x1000,
    }
}
