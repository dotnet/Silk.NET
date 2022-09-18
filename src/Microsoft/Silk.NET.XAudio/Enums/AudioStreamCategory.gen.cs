// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "_AUDIO_STREAM_CATEGORY")]
    public enum AudioStreamCategory : int
    {
        [Obsolete("Deprecated in favour of \"Other\"")]
        [NativeName("Name", "AudioCategory_Other")]
        AudioCategoryOther = 0x0,
        [Obsolete("Deprecated in favour of \"ForegroundOnlyMedia\"")]
        [NativeName("Name", "AudioCategory_ForegroundOnlyMedia")]
        AudioCategoryForegroundOnlyMedia = 0x1,
        [Obsolete("Deprecated in favour of \"Communications\"")]
        [NativeName("Name", "AudioCategory_Communications")]
        AudioCategoryCommunications = 0x3,
        [Obsolete("Deprecated in favour of \"Alerts\"")]
        [NativeName("Name", "AudioCategory_Alerts")]
        AudioCategoryAlerts = 0x4,
        [Obsolete("Deprecated in favour of \"SoundEffects\"")]
        [NativeName("Name", "AudioCategory_SoundEffects")]
        AudioCategorySoundEffects = 0x5,
        [Obsolete("Deprecated in favour of \"GameEffects\"")]
        [NativeName("Name", "AudioCategory_GameEffects")]
        AudioCategoryGameEffects = 0x6,
        [Obsolete("Deprecated in favour of \"GameMedia\"")]
        [NativeName("Name", "AudioCategory_GameMedia")]
        AudioCategoryGameMedia = 0x7,
        [Obsolete("Deprecated in favour of \"GameChat\"")]
        [NativeName("Name", "AudioCategory_GameChat")]
        AudioCategoryGameChat = 0x8,
        [Obsolete("Deprecated in favour of \"Speech\"")]
        [NativeName("Name", "AudioCategory_Speech")]
        AudioCategorySpeech = 0x9,
        [Obsolete("Deprecated in favour of \"Movie\"")]
        [NativeName("Name", "AudioCategory_Movie")]
        AudioCategoryMovie = 0xA,
        [Obsolete("Deprecated in favour of \"Media\"")]
        [NativeName("Name", "AudioCategory_Media")]
        AudioCategoryMedia = 0xB,
        [Obsolete("Deprecated in favour of \"FarFieldSpeech\"")]
        [NativeName("Name", "AudioCategory_FarFieldSpeech")]
        AudioCategoryFarFieldSpeech = 0xC,
        [Obsolete("Deprecated in favour of \"UniformSpeech\"")]
        [NativeName("Name", "AudioCategory_UniformSpeech")]
        AudioCategoryUniformSpeech = 0xD,
        [Obsolete("Deprecated in favour of \"VoiceTyping\"")]
        [NativeName("Name", "AudioCategory_VoiceTyping")]
        AudioCategoryVoiceTyping = 0xE,
        [NativeName("Name", "AudioCategory_Other")]
        Other = 0x0,
        [NativeName("Name", "AudioCategory_ForegroundOnlyMedia")]
        ForegroundOnlyMedia = 0x1,
        [NativeName("Name", "AudioCategory_Communications")]
        Communications = 0x3,
        [NativeName("Name", "AudioCategory_Alerts")]
        Alerts = 0x4,
        [NativeName("Name", "AudioCategory_SoundEffects")]
        SoundEffects = 0x5,
        [NativeName("Name", "AudioCategory_GameEffects")]
        GameEffects = 0x6,
        [NativeName("Name", "AudioCategory_GameMedia")]
        GameMedia = 0x7,
        [NativeName("Name", "AudioCategory_GameChat")]
        GameChat = 0x8,
        [NativeName("Name", "AudioCategory_Speech")]
        Speech = 0x9,
        [NativeName("Name", "AudioCategory_Movie")]
        Movie = 0xA,
        [NativeName("Name", "AudioCategory_Media")]
        Media = 0xB,
        [NativeName("Name", "AudioCategory_FarFieldSpeech")]
        FarFieldSpeech = 0xC,
        [NativeName("Name", "AudioCategory_UniformSpeech")]
        UniformSpeech = 0xD,
        [NativeName("Name", "AudioCategory_VoiceTyping")]
        VoiceTyping = 0xE,
    }
}
