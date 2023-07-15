// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules"]/*'/>
public enum DISPID_SpeechGrammarRules
{
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsCount"]/*'/>
    DISPID_SGRsCount = 1,
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsDynamic"]/*'/>
    DISPID_SGRsDynamic = (DISPID_SGRsCount + 1),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsAdd"]/*'/>
    DISPID_SGRsAdd = (DISPID_SGRsDynamic + 1),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsCommit"]/*'/>
    DISPID_SGRsCommit = (DISPID_SGRsAdd + 1),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsCommitAndSave"]/*'/>
    DISPID_SGRsCommitAndSave = (DISPID_SGRsCommit + 1),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsFindRule"]/*'/>
    DISPID_SGRsFindRule = (DISPID_SGRsCommitAndSave + 1),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRsItem"]/*'/>
    DISPID_SGRsItem = (0),
    /// <include file='DISPID_SpeechGrammarRules.xml' path='doc/member[@name="DISPID_SpeechGrammarRules.DISPID_SGRs_NewEnum"]/*'/>
    DISPID_SGRs_NewEnum = (-4),
}