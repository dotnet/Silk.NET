// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlListType.xml' path='doc/member[@name="htmlListType"]/*'/>
public enum htmlListType
{
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeNotSet"]/*'/>
    htmlListTypeNotSet = 0,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeLargeAlpha"]/*'/>
    htmlListTypeLargeAlpha = 1,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeSmallAlpha"]/*'/>
    htmlListTypeSmallAlpha = 2,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeLargeRoman"]/*'/>
    htmlListTypeLargeRoman = 3,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeSmallRoman"]/*'/>
    htmlListTypeSmallRoman = 4,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeNumbers"]/*'/>
    htmlListTypeNumbers = 5,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeDisc"]/*'/>
    htmlListTypeDisc = 6,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeCircle"]/*'/>
    htmlListTypeCircle = 7,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListTypeSquare"]/*'/>
    htmlListTypeSquare = 8,
    /// <include file='htmlListType.xml' path='doc/member[@name="htmlListType.htmlListType_Max"]/*'/>
    htmlListType_Max = 2147483647,
}