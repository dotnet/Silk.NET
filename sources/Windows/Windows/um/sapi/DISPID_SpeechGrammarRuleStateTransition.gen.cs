// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition"]/*' />
public enum DISPID_SpeechGrammarRuleStateTransition
{
    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTType"]/*' />
    DISPID_SGRSTType = 1,

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTText"]/*' />
    DISPID_SGRSTText = (DISPID_SGRSTType + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTRule"]/*' />
    DISPID_SGRSTRule = (DISPID_SGRSTText + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTWeight"]/*' />
    DISPID_SGRSTWeight = (DISPID_SGRSTRule + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTPropertyName"]/*' />
    DISPID_SGRSTPropertyName = (DISPID_SGRSTWeight + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTPropertyId"]/*' />
    DISPID_SGRSTPropertyId = (DISPID_SGRSTPropertyName + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTPropertyValue"]/*' />
    DISPID_SGRSTPropertyValue = (DISPID_SGRSTPropertyId + 1),

    /// <include file='DISPID_SpeechGrammarRuleStateTransition.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleStateTransition.DISPID_SGRSTNextState"]/*' />
    DISPID_SGRSTNextState = (DISPID_SGRSTPropertyValue + 1),
}
