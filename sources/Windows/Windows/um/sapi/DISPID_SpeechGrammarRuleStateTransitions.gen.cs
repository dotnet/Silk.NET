// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransitions"]/*'/>
public enum DISPID_SpeechGrammarRuleStateTransitions
{
    /// <include file='DISPID_SpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransitions.DISPID_SGRSTsCount"]/*'/>
    DISPID_SGRSTsCount = 1,
    /// <include file='DISPID_SpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransitions.DISPID_SGRSTsItem"]/*'/>
    DISPID_SGRSTsItem = (0),
    /// <include file='DISPID_SpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransitions.DISPID_SGRSTs_NewEnum"]/*'/>
    DISPID_SGRSTs_NewEnum = (-4),
}