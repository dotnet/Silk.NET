// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer"]/*'/>
public enum DISPID_SpeechRecognizer
{
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRRecognizer"]/*'/>
    DISPID_SRRecognizer = 1,
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRAllowAudioInputFormatChangesOnNextSet"]/*'/>
    DISPID_SRAllowAudioInputFormatChangesOnNextSet = (DISPID_SRRecognizer + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRAudioInput"]/*'/>
    DISPID_SRAudioInput = (DISPID_SRAllowAudioInputFormatChangesOnNextSet + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRAudioInputStream"]/*'/>
    DISPID_SRAudioInputStream = (DISPID_SRAudioInput + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRIsShared"]/*'/>
    DISPID_SRIsShared = (DISPID_SRAudioInputStream + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRState"]/*'/>
    DISPID_SRState = (DISPID_SRIsShared + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRStatus"]/*'/>
    DISPID_SRStatus = (DISPID_SRState + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRProfile"]/*'/>
    DISPID_SRProfile = (DISPID_SRStatus + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SREmulateRecognition"]/*'/>
    DISPID_SREmulateRecognition = (DISPID_SRProfile + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRCreateRecoContext"]/*'/>
    DISPID_SRCreateRecoContext = (DISPID_SREmulateRecognition + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRGetFormat"]/*'/>
    DISPID_SRGetFormat = (DISPID_SRCreateRecoContext + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRSetPropertyNumber"]/*'/>
    DISPID_SRSetPropertyNumber = (DISPID_SRGetFormat + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRGetPropertyNumber"]/*'/>
    DISPID_SRGetPropertyNumber = (DISPID_SRSetPropertyNumber + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRSetPropertyString"]/*'/>
    DISPID_SRSetPropertyString = (DISPID_SRGetPropertyNumber + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRGetPropertyString"]/*'/>
    DISPID_SRGetPropertyString = (DISPID_SRSetPropertyString + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRIsUISupported"]/*'/>
    DISPID_SRIsUISupported = (DISPID_SRGetPropertyString + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRDisplayUI"]/*'/>
    DISPID_SRDisplayUI = (DISPID_SRIsUISupported + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SRGetRecognizers"]/*'/>
    DISPID_SRGetRecognizers = (DISPID_SRDisplayUI + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SVGetAudioInputs"]/*'/>
    DISPID_SVGetAudioInputs = (DISPID_SRGetRecognizers + 1),
    /// <include file='DISPID_SpeechRecognizer.xml' path='doc/member[@name="DISPID_SpeechRecognizer.DISPID_SVGetProfiles"]/*'/>
    DISPID_SVGetProfiles = (DISPID_SVGetAudioInputs + 1),
}