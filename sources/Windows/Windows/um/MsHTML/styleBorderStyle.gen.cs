// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle"]/*'/>
public enum styleBorderStyle
{
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleNotSet"]/*'/>
    styleBorderStyleNotSet = 0,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleDotted"]/*'/>
    styleBorderStyleDotted = 1,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleDashed"]/*'/>
    styleBorderStyleDashed = 2,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleSolid"]/*'/>
    styleBorderStyleSolid = 3,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleDouble"]/*'/>
    styleBorderStyleDouble = 4,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleGroove"]/*'/>
    styleBorderStyleGroove = 5,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleRidge"]/*'/>
    styleBorderStyleRidge = 6,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleInset"]/*'/>
    styleBorderStyleInset = 7,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleOutset"]/*'/>
    styleBorderStyleOutset = 8,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleWindowInset"]/*'/>
    styleBorderStyleWindowInset = 9,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleNone"]/*'/>
    styleBorderStyleNone = 10,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyleHidden"]/*'/>
    styleBorderStyleHidden = 11,
    /// <include file='styleBorderStyle.xml' path='doc/member[@name="styleBorderStyle.styleBorderStyle_Max"]/*'/>
    styleBorderStyle_Max = 2147483647,
}