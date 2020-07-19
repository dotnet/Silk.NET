// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_system_L39_C1")]
    public enum AllegroSystemPath
    {
        [NativeName("Name", "ALLEGRO_RESOURCES_PATH")]
        AllegroResourcesPath = 0x0,
        [NativeName("Name", "ALLEGRO_TEMP_PATH")]
        AllegroTempPath = 0x1,
        [NativeName("Name", "ALLEGRO_USER_DATA_PATH")]
        AllegroUserDataPath = 0x2,
        [NativeName("Name", "ALLEGRO_USER_HOME_PATH")]
        AllegroUserHomePath = 0x3,
        [NativeName("Name", "ALLEGRO_USER_SETTINGS_PATH")]
        AllegroUserSettingsPath = 0x4,
        [NativeName("Name", "ALLEGRO_USER_DOCUMENTS_PATH")]
        AllegroUserDocumentsPath = 0x5,
        [NativeName("Name", "ALLEGRO_EXENAME_PATH")]
        AllegroExenamePath = 0x6,
        [NativeName("Name", "ALLEGRO_LAST_PATH")]
        AllegroLastPath = 0x7,
    }
}
