// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType"]/*'/>
public enum SpeechGrammarRuleStateTransitionType
{
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTEpsilon"]/*'/>
    SGRSTTEpsilon = 0,
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTWord"]/*'/>
    SGRSTTWord = (SGRSTTEpsilon + 1),
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTRule"]/*'/>
    SGRSTTRule = (SGRSTTWord + 1),
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTDictation"]/*'/>
    SGRSTTDictation = (SGRSTTRule + 1),
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTWildcard"]/*'/>
    SGRSTTWildcard = (SGRSTTDictation + 1),
    /// <include file='SpeechGrammarRuleStateTransitionType.xml' path='doc/member[@name="SpeechGrammarRuleStateTransitionType.SGRSTTTextBuffer"]/*'/>
    SGRSTTTextBuffer = (SGRSTTWildcard + 1),
}