// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechGrammarRuleStateTransition
{
    DISPID_SGRSTType = 1,
    DISPID_SGRSTText = (DISPID_SGRSTType + 1),
    DISPID_SGRSTRule = (DISPID_SGRSTText + 1),
    DISPID_SGRSTWeight = (DISPID_SGRSTRule + 1),
    DISPID_SGRSTPropertyName = (DISPID_SGRSTWeight + 1),
    DISPID_SGRSTPropertyId = (DISPID_SGRSTPropertyName + 1),
    DISPID_SGRSTPropertyValue = (DISPID_SGRSTPropertyId + 1),
    DISPID_SGRSTNextState = (DISPID_SGRSTPropertyValue + 1),
}
