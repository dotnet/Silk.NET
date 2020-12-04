// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "_AUDIO_STREAM_CATEGORY")]
    public enum AudioStreamCategory
    {
        [NativeName("Name", "AudioCategory_Other")]
        AudioCategoryOther = 0x0,
        [NativeName("Name", "AudioCategory_ForegroundOnlyMedia")]
        AudioCategoryForegroundOnlyMedia = 0x1,
        [NativeName("Name", "AudioCategory_Communications")]
        AudioCategoryCommunications = 0x3,
        [NativeName("Name", "AudioCategory_Alerts")]
        AudioCategoryAlerts = 0x4,
        [NativeName("Name", "AudioCategory_SoundEffects")]
        AudioCategorySoundEffects = 0x5,
        [NativeName("Name", "AudioCategory_GameEffects")]
        AudioCategoryGameEffects = 0x6,
        [NativeName("Name", "AudioCategory_GameMedia")]
        AudioCategoryGameMedia = 0x7,
        [NativeName("Name", "AudioCategory_GameChat")]
        AudioCategoryGameChat = 0x8,
        [NativeName("Name", "AudioCategory_Speech")]
        AudioCategorySpeech = 0x9,
        [NativeName("Name", "AudioCategory_Movie")]
        AudioCategoryMovie = 0xA,
        [NativeName("Name", "AudioCategory_Media")]
        AudioCategoryMedia = 0xB,
    }
}
