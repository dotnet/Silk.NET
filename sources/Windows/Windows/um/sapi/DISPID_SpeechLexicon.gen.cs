// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon"]/*'/>
public enum DISPID_SpeechLexicon
{
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLGenerationId"]/*'/>
    DISPID_SLGenerationId = 1,
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLGetWords"]/*'/>
    DISPID_SLGetWords = (DISPID_SLGenerationId + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLAddPronunciation"]/*'/>
    DISPID_SLAddPronunciation = (DISPID_SLGetWords + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLAddPronunciationByPhoneIds"]/*'/>
    DISPID_SLAddPronunciationByPhoneIds = (DISPID_SLAddPronunciation + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLRemovePronunciation"]/*'/>
    DISPID_SLRemovePronunciation = (DISPID_SLAddPronunciationByPhoneIds + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLRemovePronunciationByPhoneIds"]/*'/>
    DISPID_SLRemovePronunciationByPhoneIds = (DISPID_SLRemovePronunciation + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLGetPronunciations"]/*'/>
    DISPID_SLGetPronunciations = (DISPID_SLRemovePronunciationByPhoneIds + 1),
    /// <include file='DISPID_SpeechLexicon.xml' path='doc/member[@name="DISPID_SpeechLexicon.DISPID_SLGetGenerationChange"]/*'/>
    DISPID_SLGetGenerationChange = (DISPID_SLGetPronunciations + 1),
}