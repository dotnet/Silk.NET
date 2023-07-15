// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents"]/*'/>
public enum DISPID_SpeechRecoContextEvents
{
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEStartStream"]/*'/>
    DISPID_SRCEStartStream = 1,
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEEndStream"]/*'/>
    DISPID_SRCEEndStream = (DISPID_SRCEStartStream + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEBookmark"]/*'/>
    DISPID_SRCEBookmark = (DISPID_SRCEEndStream + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCESoundStart"]/*'/>
    DISPID_SRCESoundStart = (DISPID_SRCEBookmark + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCESoundEnd"]/*'/>
    DISPID_SRCESoundEnd = (DISPID_SRCESoundStart + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEPhraseStart"]/*'/>
    DISPID_SRCEPhraseStart = (DISPID_SRCESoundEnd + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCERecognition"]/*'/>
    DISPID_SRCERecognition = (DISPID_SRCEPhraseStart + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEHypothesis"]/*'/>
    DISPID_SRCEHypothesis = (DISPID_SRCERecognition + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEPropertyNumberChange"]/*'/>
    DISPID_SRCEPropertyNumberChange = (DISPID_SRCEHypothesis + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEPropertyStringChange"]/*'/>
    DISPID_SRCEPropertyStringChange = (DISPID_SRCEPropertyNumberChange + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEFalseRecognition"]/*'/>
    DISPID_SRCEFalseRecognition = (DISPID_SRCEPropertyStringChange + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEInterference"]/*'/>
    DISPID_SRCEInterference = (DISPID_SRCEFalseRecognition + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCERequestUI"]/*'/>
    DISPID_SRCERequestUI = (DISPID_SRCEInterference + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCERecognizerStateChange"]/*'/>
    DISPID_SRCERecognizerStateChange = (DISPID_SRCERequestUI + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEAdaptation"]/*'/>
    DISPID_SRCEAdaptation = (DISPID_SRCERecognizerStateChange + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCERecognitionForOtherContext"]/*'/>
    DISPID_SRCERecognitionForOtherContext = (DISPID_SRCEAdaptation + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEAudioLevel"]/*'/>
    DISPID_SRCEAudioLevel = (DISPID_SRCERecognitionForOtherContext + 1),
    /// <include file='DISPID_SpeechRecoContextEvents.xml' path='doc/member[@name="DISPID_SpeechRecoContextEvents.DISPID_SRCEEnginePrivate"]/*'/>
    DISPID_SRCEEnginePrivate = (DISPID_SRCEAudioLevel + 1),
}