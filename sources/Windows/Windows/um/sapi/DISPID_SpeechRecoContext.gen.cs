// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext"]/*' />
public enum DISPID_SpeechRecoContext
{
    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCRecognizer"]/*' />
    DISPID_SRCRecognizer = 1,

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCAudioInInterferenceStatus"]/*' />
    DISPID_SRCAudioInInterferenceStatus = (DISPID_SRCRecognizer + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCRequestedUIType"]/*' />
    DISPID_SRCRequestedUIType = (DISPID_SRCAudioInInterferenceStatus + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCVoice"]/*' />
    DISPID_SRCVoice = (DISPID_SRCRequestedUIType + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRAllowVoiceFormatMatchingOnNextSet"]/*' />
    DISPID_SRAllowVoiceFormatMatchingOnNextSet = (DISPID_SRCVoice + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCVoicePurgeEvent"]/*' />
    DISPID_SRCVoicePurgeEvent = (DISPID_SRAllowVoiceFormatMatchingOnNextSet + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCEventInterests"]/*' />
    DISPID_SRCEventInterests = (DISPID_SRCVoicePurgeEvent + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCCmdMaxAlternates"]/*' />
    DISPID_SRCCmdMaxAlternates = (DISPID_SRCEventInterests + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCState"]/*' />
    DISPID_SRCState = (DISPID_SRCCmdMaxAlternates + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCRetainedAudio"]/*' />
    DISPID_SRCRetainedAudio = (DISPID_SRCState + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCRetainedAudioFormat"]/*' />
    DISPID_SRCRetainedAudioFormat = (DISPID_SRCRetainedAudio + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCPause"]/*' />
    DISPID_SRCPause = (DISPID_SRCRetainedAudioFormat + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCResume"]/*' />
    DISPID_SRCResume = (DISPID_SRCPause + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCCreateGrammar"]/*' />
    DISPID_SRCCreateGrammar = (DISPID_SRCResume + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCCreateResultFromMemory"]/*' />
    DISPID_SRCCreateResultFromMemory = (DISPID_SRCCreateGrammar + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCBookmark"]/*' />
    DISPID_SRCBookmark = (DISPID_SRCCreateResultFromMemory + 1),

    /// <include file='DISPID_SpeechRecoContext.xml' path='doc/member[@name="DISPID_SpeechRecoContext.DISPID_SRCSetAdaptationData"]/*' />
    DISPID_SRCSetAdaptationData = (DISPID_SRCBookmark + 1),
}
