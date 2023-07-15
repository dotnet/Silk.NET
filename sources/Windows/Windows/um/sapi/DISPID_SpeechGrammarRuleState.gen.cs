// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState"]/*'/>
public enum DISPID_SpeechGrammarRuleState
{
    /// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState.DISPID_SGRSRule"]/*'/>
    DISPID_SGRSRule = 1,
    /// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState.DISPID_SGRSTransitions"]/*'/>
    DISPID_SGRSTransitions = (DISPID_SGRSRule + 1),
    /// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState.DISPID_SGRSAddWordTransition"]/*'/>
    DISPID_SGRSAddWordTransition = (DISPID_SGRSTransitions + 1),
    /// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState.DISPID_SGRSAddRuleTransition"]/*'/>
    DISPID_SGRSAddRuleTransition = (DISPID_SGRSAddWordTransition + 1),
    /// <include file='DISPID_SpeechGrammarRuleState.xml' path='doc/member[@name="DISPID_SpeechGrammarRuleState.DISPID_SGRSAddSpecialTransition"]/*'/>
    DISPID_SGRSAddSpecialTransition = (DISPID_SGRSAddRuleTransition + 1),
}