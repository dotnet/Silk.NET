// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT"]/*'/>
public enum SPSTREAMFORMAT
{
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_Default"]/*'/>
    SPSF_Default = -1,
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_NoAssignedFormat"]/*'/>
    SPSF_NoAssignedFormat = 0,
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_Text"]/*'/>
    SPSF_Text = (SPSF_NoAssignedFormat + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_NonStandardFormat"]/*'/>
    SPSF_NonStandardFormat = (SPSF_Text + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ExtendedAudioFormat"]/*'/>
    SPSF_ExtendedAudioFormat = (SPSF_NonStandardFormat + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_8kHz8BitMono"]/*'/>
    SPSF_8kHz8BitMono = (SPSF_ExtendedAudioFormat + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_8kHz8BitStereo"]/*'/>
    SPSF_8kHz8BitStereo = (SPSF_8kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_8kHz16BitMono"]/*'/>
    SPSF_8kHz16BitMono = (SPSF_8kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_8kHz16BitStereo"]/*'/>
    SPSF_8kHz16BitStereo = (SPSF_8kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_11kHz8BitMono"]/*'/>
    SPSF_11kHz8BitMono = (SPSF_8kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_11kHz8BitStereo"]/*'/>
    SPSF_11kHz8BitStereo = (SPSF_11kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_11kHz16BitMono"]/*'/>
    SPSF_11kHz16BitMono = (SPSF_11kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_11kHz16BitStereo"]/*'/>
    SPSF_11kHz16BitStereo = (SPSF_11kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_12kHz8BitMono"]/*'/>
    SPSF_12kHz8BitMono = (SPSF_11kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_12kHz8BitStereo"]/*'/>
    SPSF_12kHz8BitStereo = (SPSF_12kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_12kHz16BitMono"]/*'/>
    SPSF_12kHz16BitMono = (SPSF_12kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_12kHz16BitStereo"]/*'/>
    SPSF_12kHz16BitStereo = (SPSF_12kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_16kHz8BitMono"]/*'/>
    SPSF_16kHz8BitMono = (SPSF_12kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_16kHz8BitStereo"]/*'/>
    SPSF_16kHz8BitStereo = (SPSF_16kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_16kHz16BitMono"]/*'/>
    SPSF_16kHz16BitMono = (SPSF_16kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_16kHz16BitStereo"]/*'/>
    SPSF_16kHz16BitStereo = (SPSF_16kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_22kHz8BitMono"]/*'/>
    SPSF_22kHz8BitMono = (SPSF_16kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_22kHz8BitStereo"]/*'/>
    SPSF_22kHz8BitStereo = (SPSF_22kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_22kHz16BitMono"]/*'/>
    SPSF_22kHz16BitMono = (SPSF_22kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_22kHz16BitStereo"]/*'/>
    SPSF_22kHz16BitStereo = (SPSF_22kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_24kHz8BitMono"]/*'/>
    SPSF_24kHz8BitMono = (SPSF_22kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_24kHz8BitStereo"]/*'/>
    SPSF_24kHz8BitStereo = (SPSF_24kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_24kHz16BitMono"]/*'/>
    SPSF_24kHz16BitMono = (SPSF_24kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_24kHz16BitStereo"]/*'/>
    SPSF_24kHz16BitStereo = (SPSF_24kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_32kHz8BitMono"]/*'/>
    SPSF_32kHz8BitMono = (SPSF_24kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_32kHz8BitStereo"]/*'/>
    SPSF_32kHz8BitStereo = (SPSF_32kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_32kHz16BitMono"]/*'/>
    SPSF_32kHz16BitMono = (SPSF_32kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_32kHz16BitStereo"]/*'/>
    SPSF_32kHz16BitStereo = (SPSF_32kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_44kHz8BitMono"]/*'/>
    SPSF_44kHz8BitMono = (SPSF_32kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_44kHz8BitStereo"]/*'/>
    SPSF_44kHz8BitStereo = (SPSF_44kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_44kHz16BitMono"]/*'/>
    SPSF_44kHz16BitMono = (SPSF_44kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_44kHz16BitStereo"]/*'/>
    SPSF_44kHz16BitStereo = (SPSF_44kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_48kHz8BitMono"]/*'/>
    SPSF_48kHz8BitMono = (SPSF_44kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_48kHz8BitStereo"]/*'/>
    SPSF_48kHz8BitStereo = (SPSF_48kHz8BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_48kHz16BitMono"]/*'/>
    SPSF_48kHz16BitMono = (SPSF_48kHz8BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_48kHz16BitStereo"]/*'/>
    SPSF_48kHz16BitStereo = (SPSF_48kHz16BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_TrueSpeech_8kHz1BitMono"]/*'/>
    SPSF_TrueSpeech_8kHz1BitMono = (SPSF_48kHz16BitStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_8kHzMono"]/*'/>
    SPSF_CCITT_ALaw_8kHzMono = (SPSF_TrueSpeech_8kHz1BitMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_8kHzStereo"]/*'/>
    SPSF_CCITT_ALaw_8kHzStereo = (SPSF_CCITT_ALaw_8kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_11kHzMono"]/*'/>
    SPSF_CCITT_ALaw_11kHzMono = (SPSF_CCITT_ALaw_8kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_11kHzStereo"]/*'/>
    SPSF_CCITT_ALaw_11kHzStereo = (SPSF_CCITT_ALaw_11kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_22kHzMono"]/*'/>
    SPSF_CCITT_ALaw_22kHzMono = (SPSF_CCITT_ALaw_11kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_22kHzStereo"]/*'/>
    SPSF_CCITT_ALaw_22kHzStereo = (SPSF_CCITT_ALaw_22kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_44kHzMono"]/*'/>
    SPSF_CCITT_ALaw_44kHzMono = (SPSF_CCITT_ALaw_22kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_ALaw_44kHzStereo"]/*'/>
    SPSF_CCITT_ALaw_44kHzStereo = (SPSF_CCITT_ALaw_44kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_8kHzMono"]/*'/>
    SPSF_CCITT_uLaw_8kHzMono = (SPSF_CCITT_ALaw_44kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_8kHzStereo"]/*'/>
    SPSF_CCITT_uLaw_8kHzStereo = (SPSF_CCITT_uLaw_8kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_11kHzMono"]/*'/>
    SPSF_CCITT_uLaw_11kHzMono = (SPSF_CCITT_uLaw_8kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_11kHzStereo"]/*'/>
    SPSF_CCITT_uLaw_11kHzStereo = (SPSF_CCITT_uLaw_11kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_22kHzMono"]/*'/>
    SPSF_CCITT_uLaw_22kHzMono = (SPSF_CCITT_uLaw_11kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_22kHzStereo"]/*'/>
    SPSF_CCITT_uLaw_22kHzStereo = (SPSF_CCITT_uLaw_22kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_44kHzMono"]/*'/>
    SPSF_CCITT_uLaw_44kHzMono = (SPSF_CCITT_uLaw_22kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_CCITT_uLaw_44kHzStereo"]/*'/>
    SPSF_CCITT_uLaw_44kHzStereo = (SPSF_CCITT_uLaw_44kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_8kHzMono"]/*'/>
    SPSF_ADPCM_8kHzMono = (SPSF_CCITT_uLaw_44kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_8kHzStereo"]/*'/>
    SPSF_ADPCM_8kHzStereo = (SPSF_ADPCM_8kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_11kHzMono"]/*'/>
    SPSF_ADPCM_11kHzMono = (SPSF_ADPCM_8kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_11kHzStereo"]/*'/>
    SPSF_ADPCM_11kHzStereo = (SPSF_ADPCM_11kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_22kHzMono"]/*'/>
    SPSF_ADPCM_22kHzMono = (SPSF_ADPCM_11kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_22kHzStereo"]/*'/>
    SPSF_ADPCM_22kHzStereo = (SPSF_ADPCM_22kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_44kHzMono"]/*'/>
    SPSF_ADPCM_44kHzMono = (SPSF_ADPCM_22kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_ADPCM_44kHzStereo"]/*'/>
    SPSF_ADPCM_44kHzStereo = (SPSF_ADPCM_44kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_GSM610_8kHzMono"]/*'/>
    SPSF_GSM610_8kHzMono = (SPSF_ADPCM_44kHzStereo + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_GSM610_11kHzMono"]/*'/>
    SPSF_GSM610_11kHzMono = (SPSF_GSM610_8kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_GSM610_22kHzMono"]/*'/>
    SPSF_GSM610_22kHzMono = (SPSF_GSM610_11kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_GSM610_44kHzMono"]/*'/>
    SPSF_GSM610_44kHzMono = (SPSF_GSM610_22kHzMono + 1),
    /// <include file='SPSTREAMFORMAT.xml' path='doc/member[@name="SPSTREAMFORMAT.SPSF_NUM_FORMATS"]/*'/>
    SPSF_NUM_FORMATS = (SPSF_GSM610_44kHzMono + 1),
}