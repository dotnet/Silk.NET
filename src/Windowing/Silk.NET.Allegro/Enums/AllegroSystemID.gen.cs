// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_SYSTEM_ID")]
    public enum AllegroSystemID
    {
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_UNKNOWN")]
        AllegroSystemIDUnknown = 0x0,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_XGLX")]
        AllegroSystemIDXglx = 0x58474C58,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_WINDOWS")]
        AllegroSystemIDWindows = 0x57494E44,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_MACOSX")]
        AllegroSystemIDMacosx = 0x4F535820,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_ANDROID")]
        AllegroSystemIDAndroid = 0x414E4452,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_IPHONE")]
        AllegroSystemIDIphone = 0x4950484F,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_GP2XWIZ")]
        AllegroSystemIDGP2Xwiz = 0x57495A20,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_RASPBERRYPI")]
        AllegroSystemIDRaspberrypi = 0x52415350,
        [NativeName("Name", "ALLEGRO_SYSTEM_ID_SDL")]
        AllegroSystemIDSdl = 0x53444C32,
    }
}
