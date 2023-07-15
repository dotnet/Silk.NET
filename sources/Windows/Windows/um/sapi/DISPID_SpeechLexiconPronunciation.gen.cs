// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation"]/*'/>
public enum DISPID_SpeechLexiconPronunciation
{
    /// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation.DISPID_SLPType"]/*'/>
    DISPID_SLPType = 1,
    /// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation.DISPID_SLPLangId"]/*'/>
    DISPID_SLPLangId = (DISPID_SLPType + 1),
    /// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation.DISPID_SLPPartOfSpeech"]/*'/>
    DISPID_SLPPartOfSpeech = (DISPID_SLPLangId + 1),
    /// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation.DISPID_SLPPhoneIds"]/*'/>
    DISPID_SLPPhoneIds = (DISPID_SLPPartOfSpeech + 1),
    /// <include file='DISPID_SpeechLexiconPronunciation.xml' path='doc/member[@name="DISPID_SpeechLexiconPronunciation.DISPID_SLPSymbolic"]/*'/>
    DISPID_SLPSymbolic = (DISPID_SLPPhoneIds + 1),
}