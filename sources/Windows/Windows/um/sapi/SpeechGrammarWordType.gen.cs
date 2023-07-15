// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPGRAMMARWORDTYPE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechGrammarWordType.xml' path='doc/member[@name="SpeechGrammarWordType"]/*'/>
public enum SpeechGrammarWordType
{
    /// <include file='SpeechGrammarWordType.xml' path='doc/member[@name="SpeechGrammarWordType.SGDisplay"]/*'/>
    SGDisplay = SPWT_DISPLAY,
    /// <include file='SpeechGrammarWordType.xml' path='doc/member[@name="SpeechGrammarWordType.SGLexical"]/*'/>
    SGLexical = SPWT_LEXICAL,
    /// <include file='SpeechGrammarWordType.xml' path='doc/member[@name="SpeechGrammarWordType.SGPronounciation"]/*'/>
    SGPronounciation = SPWT_PRONUNCIATION,
    /// <include file='SpeechGrammarWordType.xml' path='doc/member[@name="SpeechGrammarWordType.SGLexicalNoSpecialChars"]/*'/>
    SGLexicalNoSpecialChars = SPWT_LEXICAL_NO_SPECIAL_CHARS,
}