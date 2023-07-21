// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus"]/*' />
public enum DISPID_SpeechVoiceStatus
{
    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSCurrentStreamNumber"]/*' />
    DISPID_SVSCurrentStreamNumber = 1,

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSLastStreamNumberQueued"]/*' />
    DISPID_SVSLastStreamNumberQueued = (DISPID_SVSCurrentStreamNumber + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSLastResult"]/*' />
    DISPID_SVSLastResult = (DISPID_SVSLastStreamNumberQueued + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSRunningState"]/*' />
    DISPID_SVSRunningState = (DISPID_SVSLastResult + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSInputWordPosition"]/*' />
    DISPID_SVSInputWordPosition = (DISPID_SVSRunningState + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSInputWordLength"]/*' />
    DISPID_SVSInputWordLength = (DISPID_SVSInputWordPosition + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSInputSentencePosition"]/*' />
    DISPID_SVSInputSentencePosition = (DISPID_SVSInputWordLength + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSInputSentenceLength"]/*' />
    DISPID_SVSInputSentenceLength = (DISPID_SVSInputSentencePosition + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSLastBookmark"]/*' />
    DISPID_SVSLastBookmark = (DISPID_SVSInputSentenceLength + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSLastBookmarkId"]/*' />
    DISPID_SVSLastBookmarkId = (DISPID_SVSLastBookmark + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSPhonemeId"]/*' />
    DISPID_SVSPhonemeId = (DISPID_SVSLastBookmarkId + 1),

    /// <include file='DISPID_SpeechVoiceStatus.xml' path='doc/member[@name="DISPID_SpeechVoiceStatus.DISPID_SVSVisemeId"]/*' />
    DISPID_SVSVisemeId = (DISPID_SVSPhonemeId + 1),
}
