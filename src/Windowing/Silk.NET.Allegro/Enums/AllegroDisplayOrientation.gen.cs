// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION")]
    public enum AllegroDisplayOrientation
    {
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_UNKNOWN")]
        AllegroDisplayOrientationUnknown = 0x0,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_0_DEGREES")]
        AllegroDisplayOrientation0Degrees = 0x1,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_90_DEGREES")]
        AllegroDisplayOrientation90Degrees = 0x2,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_180_DEGREES")]
        AllegroDisplayOrientation180Degrees = 0x4,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_270_DEGREES")]
        AllegroDisplayOrientation270Degrees = 0x8,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_PORTRAIT")]
        AllegroDisplayOrientationPortrait = 0x5,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_LANDSCAPE")]
        AllegroDisplayOrientationLandscape = 0xA,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_ALL")]
        AllegroDisplayOrientationAll = 0xF,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_FACE_UP")]
        AllegroDisplayOrientationFaceUp = 0x10,
        [NativeName("Name", "ALLEGRO_DISPLAY_ORIENTATION_FACE_DOWN")]
        AllegroDisplayOrientationFaceDown = 0x20,
    }
}
