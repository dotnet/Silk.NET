// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule"]/*'/>
public enum DISPID_SpeechGrammarRule
{
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRAttributes"]/*'/>
    DISPID_SGRAttributes = 1,
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRInitialState"]/*'/>
    DISPID_SGRInitialState = (DISPID_SGRAttributes + 1),
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRName"]/*'/>
    DISPID_SGRName = (DISPID_SGRInitialState + 1),
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRId"]/*'/>
    DISPID_SGRId = (DISPID_SGRName + 1),
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRClear"]/*'/>
    DISPID_SGRClear = (DISPID_SGRId + 1),
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRAddResource"]/*'/>
    DISPID_SGRAddResource = (DISPID_SGRClear + 1),
    /// <include file='DISPID_SpeechGrammarRule.xml' path='doc/member[@name="DISPID_SpeechGrammarRule.DISPID_SGRAddState"]/*'/>
    DISPID_SGRAddState = (DISPID_SGRAddResource + 1),
}