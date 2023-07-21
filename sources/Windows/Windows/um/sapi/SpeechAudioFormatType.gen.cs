// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType"]/*' />
public enum SpeechAudioFormatType
{
    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTDefault"]/*' />
    SAFTDefault = -1,

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTNoAssignedFormat"]/*' />
    SAFTNoAssignedFormat = 0,

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTText"]/*' />
    SAFTText = (SAFTNoAssignedFormat + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTNonStandardFormat"]/*' />
    SAFTNonStandardFormat = (SAFTText + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTExtendedAudioFormat"]/*' />
    SAFTExtendedAudioFormat = (SAFTNonStandardFormat + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT8kHz8BitMono"]/*' />
    SAFT8kHz8BitMono = (SAFTExtendedAudioFormat + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT8kHz8BitStereo"]/*' />
    SAFT8kHz8BitStereo = (SAFT8kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT8kHz16BitMono"]/*' />
    SAFT8kHz16BitMono = (SAFT8kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT8kHz16BitStereo"]/*' />
    SAFT8kHz16BitStereo = (SAFT8kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT11kHz8BitMono"]/*' />
    SAFT11kHz8BitMono = (SAFT8kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT11kHz8BitStereo"]/*' />
    SAFT11kHz8BitStereo = (SAFT11kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT11kHz16BitMono"]/*' />
    SAFT11kHz16BitMono = (SAFT11kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT11kHz16BitStereo"]/*' />
    SAFT11kHz16BitStereo = (SAFT11kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT12kHz8BitMono"]/*' />
    SAFT12kHz8BitMono = (SAFT11kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT12kHz8BitStereo"]/*' />
    SAFT12kHz8BitStereo = (SAFT12kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT12kHz16BitMono"]/*' />
    SAFT12kHz16BitMono = (SAFT12kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT12kHz16BitStereo"]/*' />
    SAFT12kHz16BitStereo = (SAFT12kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT16kHz8BitMono"]/*' />
    SAFT16kHz8BitMono = (SAFT12kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT16kHz8BitStereo"]/*' />
    SAFT16kHz8BitStereo = (SAFT16kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT16kHz16BitMono"]/*' />
    SAFT16kHz16BitMono = (SAFT16kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT16kHz16BitStereo"]/*' />
    SAFT16kHz16BitStereo = (SAFT16kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT22kHz8BitMono"]/*' />
    SAFT22kHz8BitMono = (SAFT16kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT22kHz8BitStereo"]/*' />
    SAFT22kHz8BitStereo = (SAFT22kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT22kHz16BitMono"]/*' />
    SAFT22kHz16BitMono = (SAFT22kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT22kHz16BitStereo"]/*' />
    SAFT22kHz16BitStereo = (SAFT22kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT24kHz8BitMono"]/*' />
    SAFT24kHz8BitMono = (SAFT22kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT24kHz8BitStereo"]/*' />
    SAFT24kHz8BitStereo = (SAFT24kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT24kHz16BitMono"]/*' />
    SAFT24kHz16BitMono = (SAFT24kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT24kHz16BitStereo"]/*' />
    SAFT24kHz16BitStereo = (SAFT24kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT32kHz8BitMono"]/*' />
    SAFT32kHz8BitMono = (SAFT24kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT32kHz8BitStereo"]/*' />
    SAFT32kHz8BitStereo = (SAFT32kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT32kHz16BitMono"]/*' />
    SAFT32kHz16BitMono = (SAFT32kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT32kHz16BitStereo"]/*' />
    SAFT32kHz16BitStereo = (SAFT32kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT44kHz8BitMono"]/*' />
    SAFT44kHz8BitMono = (SAFT32kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT44kHz8BitStereo"]/*' />
    SAFT44kHz8BitStereo = (SAFT44kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT44kHz16BitMono"]/*' />
    SAFT44kHz16BitMono = (SAFT44kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT44kHz16BitStereo"]/*' />
    SAFT44kHz16BitStereo = (SAFT44kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT48kHz8BitMono"]/*' />
    SAFT48kHz8BitMono = (SAFT44kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT48kHz8BitStereo"]/*' />
    SAFT48kHz8BitStereo = (SAFT48kHz8BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT48kHz16BitMono"]/*' />
    SAFT48kHz16BitMono = (SAFT48kHz8BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFT48kHz16BitStereo"]/*' />
    SAFT48kHz16BitStereo = (SAFT48kHz16BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTTrueSpeech_8kHz1BitMono"]/*' />
    SAFTTrueSpeech_8kHz1BitMono = (SAFT48kHz16BitStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_8kHzMono"]/*' />
    SAFTCCITT_ALaw_8kHzMono = (SAFTTrueSpeech_8kHz1BitMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_8kHzStereo"]/*' />
    SAFTCCITT_ALaw_8kHzStereo = (SAFTCCITT_ALaw_8kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_11kHzMono"]/*' />
    SAFTCCITT_ALaw_11kHzMono = (SAFTCCITT_ALaw_8kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_11kHzStereo"]/*' />
    SAFTCCITT_ALaw_11kHzStereo = (SAFTCCITT_ALaw_11kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_22kHzMono"]/*' />
    SAFTCCITT_ALaw_22kHzMono = (SAFTCCITT_ALaw_11kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_22kHzStereo"]/*' />
    SAFTCCITT_ALaw_22kHzStereo = (SAFTCCITT_ALaw_22kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_44kHzMono"]/*' />
    SAFTCCITT_ALaw_44kHzMono = (SAFTCCITT_ALaw_22kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_ALaw_44kHzStereo"]/*' />
    SAFTCCITT_ALaw_44kHzStereo = (SAFTCCITT_ALaw_44kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_8kHzMono"]/*' />
    SAFTCCITT_uLaw_8kHzMono = (SAFTCCITT_ALaw_44kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_8kHzStereo"]/*' />
    SAFTCCITT_uLaw_8kHzStereo = (SAFTCCITT_uLaw_8kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_11kHzMono"]/*' />
    SAFTCCITT_uLaw_11kHzMono = (SAFTCCITT_uLaw_8kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_11kHzStereo"]/*' />
    SAFTCCITT_uLaw_11kHzStereo = (SAFTCCITT_uLaw_11kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_22kHzMono"]/*' />
    SAFTCCITT_uLaw_22kHzMono = (SAFTCCITT_uLaw_11kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_22kHzStereo"]/*' />
    SAFTCCITT_uLaw_22kHzStereo = (SAFTCCITT_uLaw_22kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_44kHzMono"]/*' />
    SAFTCCITT_uLaw_44kHzMono = (SAFTCCITT_uLaw_22kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTCCITT_uLaw_44kHzStereo"]/*' />
    SAFTCCITT_uLaw_44kHzStereo = (SAFTCCITT_uLaw_44kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_8kHzMono"]/*' />
    SAFTADPCM_8kHzMono = (SAFTCCITT_uLaw_44kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_8kHzStereo"]/*' />
    SAFTADPCM_8kHzStereo = (SAFTADPCM_8kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_11kHzMono"]/*' />
    SAFTADPCM_11kHzMono = (SAFTADPCM_8kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_11kHzStereo"]/*' />
    SAFTADPCM_11kHzStereo = (SAFTADPCM_11kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_22kHzMono"]/*' />
    SAFTADPCM_22kHzMono = (SAFTADPCM_11kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_22kHzStereo"]/*' />
    SAFTADPCM_22kHzStereo = (SAFTADPCM_22kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_44kHzMono"]/*' />
    SAFTADPCM_44kHzMono = (SAFTADPCM_22kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTADPCM_44kHzStereo"]/*' />
    SAFTADPCM_44kHzStereo = (SAFTADPCM_44kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTGSM610_8kHzMono"]/*' />
    SAFTGSM610_8kHzMono = (SAFTADPCM_44kHzStereo + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTGSM610_11kHzMono"]/*' />
    SAFTGSM610_11kHzMono = (SAFTGSM610_8kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTGSM610_22kHzMono"]/*' />
    SAFTGSM610_22kHzMono = (SAFTGSM610_11kHzMono + 1),

    /// <include file='SpeechAudioFormatType.xml' path='doc/member[@name="SpeechAudioFormatType.SAFTGSM610_44kHzMono"]/*' />
    SAFTGSM610_44kHzMono = (SAFTGSM610_22kHzMono + 1),
}
