// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechLexiconWord.xml' path='doc/member[@name="DISPID_SpeechLexiconWord"]/*'/>
public enum DISPID_SpeechLexiconWord
{
    /// <include file='DISPID_SpeechLexiconWord.xml' path='doc/member[@name="DISPID_SpeechLexiconWord.DISPID_SLWLangId"]/*'/>
    DISPID_SLWLangId = 1,
    /// <include file='DISPID_SpeechLexiconWord.xml' path='doc/member[@name="DISPID_SpeechLexiconWord.DISPID_SLWType"]/*'/>
    DISPID_SLWType = (DISPID_SLWLangId + 1),
    /// <include file='DISPID_SpeechLexiconWord.xml' path='doc/member[@name="DISPID_SpeechLexiconWord.DISPID_SLWWord"]/*'/>
    DISPID_SLWWord = (DISPID_SLWType + 1),
    /// <include file='DISPID_SpeechLexiconWord.xml' path='doc/member[@name="DISPID_SpeechLexiconWord.DISPID_SLWPronunciations"]/*'/>
    DISPID_SLWPronunciations = (DISPID_SLWWord + 1),
}