// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlRules.xml' path='doc/member[@name="htmlRules"]/*' />
public enum htmlRules
{
    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulesNotSet"]/*' />
    htmlRulesNotSet = 0,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulesnone"]/*' />
    htmlRulesnone = 1,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulesgroups"]/*' />
    htmlRulesgroups = 2,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulesrows"]/*' />
    htmlRulesrows = 3,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulescols"]/*' />
    htmlRulescols = 4,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRulesall"]/*' />
    htmlRulesall = 5,

    /// <include file='htmlRules.xml' path='doc/member[@name="htmlRules.htmlRules_Max"]/*' />
    htmlRules_Max = 2147483647,
}
