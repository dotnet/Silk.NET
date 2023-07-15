// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult"]/*'/>
public enum DISPID_SpeechRecoResult
{
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRRecoContext"]/*'/>
    DISPID_SRRRecoContext = 1,
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRTimes"]/*'/>
    DISPID_SRRTimes = (DISPID_SRRRecoContext + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRAudioFormat"]/*'/>
    DISPID_SRRAudioFormat = (DISPID_SRRTimes + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRPhraseInfo"]/*'/>
    DISPID_SRRPhraseInfo = (DISPID_SRRAudioFormat + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRAlternates"]/*'/>
    DISPID_SRRAlternates = (DISPID_SRRPhraseInfo + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRAudio"]/*'/>
    DISPID_SRRAudio = (DISPID_SRRAlternates + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRSpeakAudio"]/*'/>
    DISPID_SRRSpeakAudio = (DISPID_SRRAudio + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRSaveToMemory"]/*'/>
    DISPID_SRRSaveToMemory = (DISPID_SRRSpeakAudio + 1),
    /// <include file='DISPID_SpeechRecoResult.xml' path='doc/member[@name="DISPID_SpeechRecoResult.DISPID_SRRDiscardResultInfo"]/*'/>
    DISPID_SRRDiscardResultInfo = (DISPID_SRRSaveToMemory + 1),
}