// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule"]/*' />
public enum DISPID_SpeechPhraseRule
{
    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleName"]/*' />
    DISPID_SPRuleName = 1,

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleId"]/*' />
    DISPID_SPRuleId = (DISPID_SPRuleName + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleFirstElement"]/*' />
    DISPID_SPRuleFirstElement = (DISPID_SPRuleId + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleNumberOfElements"]/*' />
    DISPID_SPRuleNumberOfElements = (DISPID_SPRuleFirstElement + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleParent"]/*' />
    DISPID_SPRuleParent = (DISPID_SPRuleNumberOfElements + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleChildren"]/*' />
    DISPID_SPRuleChildren = (DISPID_SPRuleParent + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleConfidence"]/*' />
    DISPID_SPRuleConfidence = (DISPID_SPRuleChildren + 1),

    /// <include file='DISPID_SpeechPhraseRule.xml' path='doc/member[@name="DISPID_SpeechPhraseRule.DISPID_SPRuleEngineConfidence"]/*' />
    DISPID_SPRuleEngineConfidence = (DISPID_SPRuleConfidence + 1),
}
