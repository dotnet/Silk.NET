// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechPhraseRules.xml' path='doc/member[@name="DISPID_SpeechPhraseRules"]/*' />
public enum DISPID_SpeechPhraseRules
{
    /// <include file='DISPID_SpeechPhraseRules.xml' path='doc/member[@name="DISPID_SpeechPhraseRules.DISPID_SPRulesCount"]/*' />
    DISPID_SPRulesCount = 1,

    /// <include file='DISPID_SpeechPhraseRules.xml' path='doc/member[@name="DISPID_SpeechPhraseRules.DISPID_SPRulesItem"]/*' />
    DISPID_SPRulesItem = (0),

    /// <include file='DISPID_SpeechPhraseRules.xml' path='doc/member[@name="DISPID_SpeechPhraseRules.DISPID_SPRules_NewEnum"]/*' />
    DISPID_SPRules_NewEnum = (-4),
}
