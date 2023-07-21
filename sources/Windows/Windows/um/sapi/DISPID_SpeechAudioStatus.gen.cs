// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus"]/*' />
public enum DISPID_SpeechAudioStatus
{
    /// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus.DISPID_SASFreeBufferSpace"]/*' />
    DISPID_SASFreeBufferSpace = 1,

    /// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus.DISPID_SASNonBlockingIO"]/*' />
    DISPID_SASNonBlockingIO = (DISPID_SASFreeBufferSpace + 1),

    /// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus.DISPID_SASState"]/*' />
    DISPID_SASState = (DISPID_SASNonBlockingIO + 1),

    /// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus.DISPID_SASCurrentSeekPosition"]/*' />
    DISPID_SASCurrentSeekPosition = (DISPID_SASState + 1),

    /// <include file='DISPID_SpeechAudioStatus.xml' path='doc/member[@name="DISPID_SpeechAudioStatus.DISPID_SASCurrentDevicePosition"]/*' />
    DISPID_SASCurrentDevicePosition = (DISPID_SASCurrentSeekPosition + 1),
}
