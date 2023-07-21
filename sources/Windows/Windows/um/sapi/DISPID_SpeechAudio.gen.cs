// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio"]/*' />
public enum DISPID_SpeechAudio
{
    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SAStatus"]/*' />
    DISPID_SAStatus = 200,

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SABufferInfo"]/*' />
    DISPID_SABufferInfo = (DISPID_SAStatus + 1),

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SADefaultFormat"]/*' />
    DISPID_SADefaultFormat = (DISPID_SABufferInfo + 1),

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SAVolume"]/*' />
    DISPID_SAVolume = (DISPID_SADefaultFormat + 1),

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SABufferNotifySize"]/*' />
    DISPID_SABufferNotifySize = (DISPID_SAVolume + 1),

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SAEventHandle"]/*' />
    DISPID_SAEventHandle = (DISPID_SABufferNotifySize + 1),

    /// <include file='DISPID_SpeechAudio.xml' path='doc/member[@name="DISPID_SpeechAudio.DISPID_SASetState"]/*' />
    DISPID_SASetState = (DISPID_SAEventHandle + 1),
}
