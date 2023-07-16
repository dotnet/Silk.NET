// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPCFGRULEATTRIBUTES;

namespace Silk.NET.Windows;
/// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes"]/*'/>
public enum SpeechRuleAttributes
{
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRATopLevel"]/*'/>
    SRATopLevel = SPRAF_TopLevel,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRADefaultToActive"]/*'/>
    SRADefaultToActive = SPRAF_Active,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRAExport"]/*'/>
    SRAExport = SPRAF_Export,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRAImport"]/*'/>
    SRAImport = SPRAF_Import,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRAInterpreter"]/*'/>
    SRAInterpreter = SPRAF_Interpreter,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRADynamic"]/*'/>
    SRADynamic = SPRAF_Dynamic,
    /// <include file='SpeechRuleAttributes.xml' path='doc/member[@name="SpeechRuleAttributes.SRARoot"]/*'/>
    SRARoot = SPRAF_Root,
}