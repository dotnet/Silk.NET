// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig"]/*'/>
public enum eAVAudioChannelConfig
{
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_FRONT_LEFT"]/*'/>
    eAVAudioChannelConfig_FRONT_LEFT = 0x1,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_FRONT_RIGHT"]/*'/>
    eAVAudioChannelConfig_FRONT_RIGHT = 0x2,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_FRONT_CENTER"]/*'/>
    eAVAudioChannelConfig_FRONT_CENTER = 0x4,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_LOW_FREQUENCY"]/*'/>
    eAVAudioChannelConfig_LOW_FREQUENCY = 0x8,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_BACK_LEFT"]/*'/>
    eAVAudioChannelConfig_BACK_LEFT = 0x10,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_BACK_RIGHT"]/*'/>
    eAVAudioChannelConfig_BACK_RIGHT = 0x20,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_FRONT_LEFT_OF_CENTER"]/*'/>
    eAVAudioChannelConfig_FRONT_LEFT_OF_CENTER = 0x40,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_FRONT_RIGHT_OF_CENTER"]/*'/>
    eAVAudioChannelConfig_FRONT_RIGHT_OF_CENTER = 0x80,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_BACK_CENTER"]/*'/>
    eAVAudioChannelConfig_BACK_CENTER = 0x100,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_SIDE_LEFT"]/*'/>
    eAVAudioChannelConfig_SIDE_LEFT = 0x200,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_SIDE_RIGHT"]/*'/>
    eAVAudioChannelConfig_SIDE_RIGHT = 0x400,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_CENTER"]/*'/>
    eAVAudioChannelConfig_TOP_CENTER = 0x800,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_FRONT_LEFT"]/*'/>
    eAVAudioChannelConfig_TOP_FRONT_LEFT = 0x1000,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_FRONT_CENTER"]/*'/>
    eAVAudioChannelConfig_TOP_FRONT_CENTER = 0x2000,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_FRONT_RIGHT"]/*'/>
    eAVAudioChannelConfig_TOP_FRONT_RIGHT = 0x4000,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_BACK_LEFT"]/*'/>
    eAVAudioChannelConfig_TOP_BACK_LEFT = 0x8000,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_BACK_CENTER"]/*'/>
    eAVAudioChannelConfig_TOP_BACK_CENTER = 0x10000,
    /// <include file='eAVAudioChannelConfig.xml' path='doc/member[@name="eAVAudioChannelConfig.eAVAudioChannelConfig_TOP_BACK_RIGHT"]/*'/>
    eAVAudioChannelConfig_TOP_BACK_RIGHT = 0x20000,
}