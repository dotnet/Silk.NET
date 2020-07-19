// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_STATE_FLAGS")]
    public enum AllegroStateFlags
    {
        [NativeName("Name", "ALLEGRO_STATE_NEW_DISPLAY_PARAMETERS")]
        AllegroStateNewDisplayParameters = 0x1,
        [NativeName("Name", "ALLEGRO_STATE_NEW_BITMAP_PARAMETERS")]
        AllegroStateNewBitmapParameters = 0x2,
        [NativeName("Name", "ALLEGRO_STATE_DISPLAY")]
        AllegroStateDisplay = 0x4,
        [NativeName("Name", "ALLEGRO_STATE_TARGET_BITMAP")]
        AllegroStateTargetBitmap = 0x8,
        [NativeName("Name", "ALLEGRO_STATE_BLENDER")]
        AllegroStateBlender = 0x10,
        [NativeName("Name", "ALLEGRO_STATE_NEW_FILE_INTERFACE")]
        AllegroStateNewFileInterface = 0x20,
        [NativeName("Name", "ALLEGRO_STATE_TRANSFORM")]
        AllegroStateTransform = 0x40,
        [NativeName("Name", "ALLEGRO_STATE_PROJECTION_TRANSFORM")]
        AllegroStateProjectionTransform = 0x100,
        [NativeName("Name", "ALLEGRO_STATE_BITMAP")]
        AllegroStateBitmap = 0xA,
        [NativeName("Name", "ALLEGRO_STATE_ALL")]
        AllegroStateAll = 0xFFFF,
    }
}
