// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechPhraseRule
{
    DISPID_SPRuleName = 1,
    DISPID_SPRuleId = (DISPID_SPRuleName + 1),
    DISPID_SPRuleFirstElement = (DISPID_SPRuleId + 1),
    DISPID_SPRuleNumberOfElements = (DISPID_SPRuleFirstElement + 1),
    DISPID_SPRuleParent = (DISPID_SPRuleNumberOfElements + 1),
    DISPID_SPRuleChildren = (DISPID_SPRuleParent + 1),
    DISPID_SPRuleConfidence = (DISPID_SPRuleChildren + 1),
    DISPID_SPRuleEngineConfidence = (DISPID_SPRuleConfidence + 1),
}
