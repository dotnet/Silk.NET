// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate"]/*'/>
public enum DISPID_SpeechPhraseAlternate
{
    /// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate.DISPID_SPARecoResult"]/*'/>
    DISPID_SPARecoResult = 1,
    /// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate.DISPID_SPAStartElementInResult"]/*'/>
    DISPID_SPAStartElementInResult = (DISPID_SPARecoResult + 1),
    /// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate.DISPID_SPANumberOfElementsInResult"]/*'/>
    DISPID_SPANumberOfElementsInResult = (DISPID_SPAStartElementInResult + 1),
    /// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate.DISPID_SPAPhraseInfo"]/*'/>
    DISPID_SPAPhraseInfo = (DISPID_SPANumberOfElementsInResult + 1),
    /// <include file='DISPID_SpeechPhraseAlternate.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternate.DISPID_SPACommit"]/*'/>
    DISPID_SPACommit = (DISPID_SPAPhraseInfo + 1),
}