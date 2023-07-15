// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus"]/*'/>
public enum DISPID_SpeechRecognizerStatus
{
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSAudioStatus"]/*'/>
    DISPID_SRSAudioStatus = 1,
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSCurrentStreamPosition"]/*'/>
    DISPID_SRSCurrentStreamPosition = (DISPID_SRSAudioStatus + 1),
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSCurrentStreamNumber"]/*'/>
    DISPID_SRSCurrentStreamNumber = (DISPID_SRSCurrentStreamPosition + 1),
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSNumberOfActiveRules"]/*'/>
    DISPID_SRSNumberOfActiveRules = (DISPID_SRSCurrentStreamNumber + 1),
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSClsidEngine"]/*'/>
    DISPID_SRSClsidEngine = (DISPID_SRSNumberOfActiveRules + 1),
    /// <include file='DISPID_SpeechRecognizerStatus.xml' path='doc/member[@name="DISPID_SpeechRecognizerStatus.DISPID_SRSSupportedLanguages"]/*'/>
    DISPID_SRSSupportedLanguages = (DISPID_SRSClsidEngine + 1),
}