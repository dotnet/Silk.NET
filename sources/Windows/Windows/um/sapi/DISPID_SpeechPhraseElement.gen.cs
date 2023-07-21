// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement"]/*' />
public enum DISPID_SpeechPhraseElement
{
    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEAudioTimeOffset"]/*' />
    DISPID_SPEAudioTimeOffset = 1,

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEAudioSizeTime"]/*' />
    DISPID_SPEAudioSizeTime = (DISPID_SPEAudioTimeOffset + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEAudioStreamOffset"]/*' />
    DISPID_SPEAudioStreamOffset = (DISPID_SPEAudioSizeTime + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEAudioSizeBytes"]/*' />
    DISPID_SPEAudioSizeBytes = (DISPID_SPEAudioStreamOffset + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPERetainedStreamOffset"]/*' />
    DISPID_SPERetainedStreamOffset = (DISPID_SPEAudioSizeBytes + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPERetainedSizeBytes"]/*' />
    DISPID_SPERetainedSizeBytes = (DISPID_SPERetainedStreamOffset + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEDisplayText"]/*' />
    DISPID_SPEDisplayText = (DISPID_SPERetainedSizeBytes + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPELexicalForm"]/*' />
    DISPID_SPELexicalForm = (DISPID_SPEDisplayText + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEPronunciation"]/*' />
    DISPID_SPEPronunciation = (DISPID_SPELexicalForm + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEDisplayAttributes"]/*' />
    DISPID_SPEDisplayAttributes = (DISPID_SPEPronunciation + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPERequiredConfidence"]/*' />
    DISPID_SPERequiredConfidence = (DISPID_SPEDisplayAttributes + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEActualConfidence"]/*' />
    DISPID_SPEActualConfidence = (DISPID_SPERequiredConfidence + 1),

    /// <include file='DISPID_SpeechPhraseElement.xml' path='doc/member[@name="DISPID_SpeechPhraseElement.DISPID_SPEEngineConfidence"]/*' />
    DISPID_SPEEngineConfidence = (DISPID_SPEActualConfidence + 1),
}
