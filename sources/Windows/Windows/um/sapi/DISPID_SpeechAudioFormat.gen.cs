// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechAudioFormat.xml' path='doc/member[@name="DISPID_SpeechAudioFormat"]/*' />
public enum DISPID_SpeechAudioFormat
{
    /// <include file='DISPID_SpeechAudioFormat.xml' path='doc/member[@name="DISPID_SpeechAudioFormat.DISPID_SAFType"]/*' />
    DISPID_SAFType = 1,

    /// <include file='DISPID_SpeechAudioFormat.xml' path='doc/member[@name="DISPID_SpeechAudioFormat.DISPID_SAFGuid"]/*' />
    DISPID_SAFGuid = (DISPID_SAFType + 1),

    /// <include file='DISPID_SpeechAudioFormat.xml' path='doc/member[@name="DISPID_SpeechAudioFormat.DISPID_SAFGetWaveFormatEx"]/*' />
    DISPID_SAFGetWaveFormatEx = (DISPID_SAFGuid + 1),

    /// <include file='DISPID_SpeechAudioFormat.xml' path='doc/member[@name="DISPID_SpeechAudioFormat.DISPID_SAFSetWaveFormatEx"]/*' />
    DISPID_SAFSetWaveFormatEx = (DISPID_SAFGetWaveFormatEx + 1),
}
