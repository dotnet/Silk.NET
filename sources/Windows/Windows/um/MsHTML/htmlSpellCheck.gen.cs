// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck"]/*'/>
public enum htmlSpellCheck
{
    /// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck.htmlSpellCheckNotSet"]/*'/>
    htmlSpellCheckNotSet = 0,
    /// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck.htmlSpellCheckTrue"]/*'/>
    htmlSpellCheckTrue = 1,
    /// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck.htmlSpellCheckFalse"]/*'/>
    htmlSpellCheckFalse = 2,
    /// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck.htmlSpellCheckDefault"]/*'/>
    htmlSpellCheckDefault = 3,
    /// <include file='htmlSpellCheck.xml' path='doc/member[@name="htmlSpellCheck.htmlSpellCheck_Max"]/*'/>
    htmlSpellCheck_Max = 2147483647,
}