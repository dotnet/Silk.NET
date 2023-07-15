// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle"]/*'/>
public enum HTMLBorderStyle
{
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStyleNormal"]/*'/>
    HTMLBorderStyleNormal = 0,
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStyleRaised"]/*'/>
    HTMLBorderStyleRaised = 0x100,
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStyleSunken"]/*'/>
    HTMLBorderStyleSunken = 0x200,
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStylecombined"]/*'/>
    HTMLBorderStylecombined = 0x300,
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStyleStatic"]/*'/>
    HTMLBorderStyleStatic = 0x20000,
    /// <include file='HTMLBorderStyle.xml' path='doc/member[@name="HTMLBorderStyle.HTMLBorderStyle_Max"]/*'/>
    HTMLBorderStyle_Max = 2147483647,
}