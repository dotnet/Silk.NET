// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit"]/*'/>
public enum htmlUnit
{
    /// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit.htmlUnitCharacter"]/*'/>
    htmlUnitCharacter = 1,
    /// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit.htmlUnitWord"]/*'/>
    htmlUnitWord = 2,
    /// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit.htmlUnitSentence"]/*'/>
    htmlUnitSentence = 3,
    /// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit.htmlUnitTextEdit"]/*'/>
    htmlUnitTextEdit = 6,
    /// <include file='htmlUnit.xml' path='doc/member[@name="htmlUnit.htmlUnit_Max"]/*'/>
    htmlUnit_Max = 2147483647,
}