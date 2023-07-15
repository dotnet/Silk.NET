// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode"]/*'/>
public enum TVAudioMode
{
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_MODE_MONO"]/*'/>
    AMTVAUDIO_MODE_MONO = 0x1,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_MODE_STEREO"]/*'/>
    AMTVAUDIO_MODE_STEREO = 0x2,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_MODE_LANG_A"]/*'/>
    AMTVAUDIO_MODE_LANG_A = 0x10,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_MODE_LANG_B"]/*'/>
    AMTVAUDIO_MODE_LANG_B = 0x20,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_MODE_LANG_C"]/*'/>
    AMTVAUDIO_MODE_LANG_C = 0x40,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_PRESET_STEREO"]/*'/>
    AMTVAUDIO_PRESET_STEREO = 0x200,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_PRESET_LANG_A"]/*'/>
    AMTVAUDIO_PRESET_LANG_A = 0x1000,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_PRESET_LANG_B"]/*'/>
    AMTVAUDIO_PRESET_LANG_B = 0x2000,
    /// <include file='TVAudioMode.xml' path='doc/member[@name="TVAudioMode.AMTVAUDIO_PRESET_LANG_C"]/*'/>
    AMTVAUDIO_PRESET_LANG_C = 0x4000,
}